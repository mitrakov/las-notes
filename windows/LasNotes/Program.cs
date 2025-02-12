namespace LasNotes;

// build:
// 1) raise Version, AssemblyVersion and FileVersion in LasNotes.csproj
// 2) run: dotnet publish --self-contained --output "Las Notes"
// 3) compile _installer/LasNotes.aip with Advanced Installer v20.9
internal static class Program {
    [STAThread]
    internal static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(new()));
    }
}
