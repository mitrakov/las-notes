using System.ComponentModel;

namespace LasNotes;

internal class MainViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    private readonly SQLiteDatabase db = new();
    private readonly ComponentResourceManager resources = new (typeof(MainViewModel));
    internal string? CurrentPath { get; set; }

    internal void OpenFile(string path) {
        if (File.Exists(path)) {
            Console.WriteLine($"Opening file {path}");
            db.OpenDb(path);
            CurrentPath = path;
            AddToRecentFilesList(path);
            FirePropertyChanged();
        } else {
            MessageBox.Show($"{resources.GetString("msg-file-not-found")}\n{path}", resources.GetString("msg-error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            RemoveFromRecentFilesList(path);
        }
    }

    internal void OpenFile() {
        var dialog = new OpenFileDialog() { Title = resources.GetString("dlg-select-file"), Filter = resources.GetString("dlg-filter-open") };
        if (dialog.ShowDialog() == DialogResult.OK)
            OpenFile(dialog.FileName);
    }

    internal void NewFile() {
        var dialog = new SaveFileDialog() { Title = resources.GetString("dlg-new-file"), FileName = "mydb", DefaultExt = "db", Filter = resources.GetString("dlg-filter-save") };
        if (dialog.ShowDialog() == DialogResult.OK) {
            var path = dialog.FileName;
            if (File.Exists(path)) {
                if (MessageBox.Show(resources.GetString("dlg-file-exists"), resources.GetString("msg-warning"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                    db.CloseDb();
                    File.Delete(path);
                } else return;
            }

            Console.WriteLine($"Creating file {path}");
            db.CreateDb(path);
            CurrentPath = path;
            AddToRecentFilesList(path);
            FirePropertyChanged();
        }
    }

    internal void CloseFile() {
        db.CloseDb();
        CurrentPath = null;
        FirePropertyChanged();
    }

    internal static IEnumerable<string> RecentFiles => User.Default.recentFiles.Cast<string>();

    internal IEnumerable<string> GetTags() {
        if (!db.IsConnected) return [];
        return db.GetTags();
    }

    internal IEnumerable<Note> GetNotes(bool showArchive) {
        if (!db.IsConnected) return [];
        return db.GetNotes(showArchive);
    }

    internal Note? SearchByID(long noteId) {
        if (!db.IsConnected) return null;
        return db.SearchByID(noteId);
    }

    internal IEnumerable<Note> SearchByTag(string tag, bool showArchive) {
        if (tag.Length == 0) return [];
        if (!db.IsConnected) return [];
        return db.SearchByTag(tag, showArchive);
    }

    internal IEnumerable<Note> SearchByKeyword(string word, bool showArchive) {
        if (word.Length == 0) return [];
        if (!db.IsConnected) return [];
        return db.SearchByKeyword(word, showArchive);
    }

    internal void ArchiveNoteById(long noteId) {
        if (!db.IsConnected) return;
        if (MessageBox.Show(resources.GetString("msg-archive-note"), "Archive note", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            db.SoftDeleteNote(noteId, true);
    }

    internal void RestoreNoteById(long noteId) {
        if (!db.IsConnected) return;
        db.SoftDeleteNote(noteId, false);
    }

    internal void DeleteNoteById(long noteId) {
        if (!db.IsConnected) return;
        if (MessageBox.Show(resources.GetString("msg-delete-note"), "Delete note", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            db.DeleteNote(noteId);
    }

    internal long? SaveNote(long? noteId, string data, string newTags, string oldTags) {
        var tags = newTags.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (!db.IsConnected) return null;
        if (data.Length == 0) return null;
        if (tags.Length == 0) {
            MessageBox.Show(resources.GetString("msg-tag-needed-txt"), resources.GetString("msg-tag-needed-hdr"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        if (noteId is long id) {
            // UPDATE
            db.UpdateNote(id, data);
            UpdateTags(id, newTags, oldTags);
            MessageBox.Show(resources.GetString("msg-note-updated"), resources.GetString("msg-done"));
            return noteId;
        } else {
            // INSERT
            var newNoteId = db.InsertNote(data);
            db.LinkTagsToNote(newNoteId, tags);
            MessageBox.Show(resources.GetString("msg-note-added"), resources.GetString("msg-done"));
            return newNoteId;
        }
    }

    private void UpdateTags(long noteId, string newTags, string oldTags) {
        var oldtags = oldTags.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToHashSet();
        var newtags = newTags.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToHashSet();
        var rmTags = oldtags.Except(newtags);
        var addTags = newtags.Except(oldtags);

        db.UnlinkTagsFromNote(noteId, rmTags);
        db.LinkTagsToNote(noteId, addTags);
    }

    private static void AddToRecentFilesList(string item) {
        User.Default.recentFiles.Remove(item);
        User.Default.recentFiles.Insert(0, item);
        User.Default.Save();
    }

    private static void RemoveFromRecentFilesList(string item) {
        User.Default.recentFiles.Remove(item);
        User.Default.Save();
    }

    protected void FirePropertyChanged() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(CurrentPath));
}
