using System.ComponentModel;
using System.Windows.Forms.Integration;
using MdControl;

namespace LasNotes {
    internal partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLeft = new Panel();
            tagsPanel = new FlowLayoutPanel();
            panelTop = new Panel();
            checkShowArchive = new CheckBox();
            textboxSearch = new TextBox();
            buttonNew = new Button();
            imagesNew = new ImageList(components);
            contentPanel = new Panel();
            editModePanel = new Panel();
            editSplitPanel = new SplitContainer();
            textboxEdit = new RichTextBox();
            panelBottom = new Panel();
            labelTags = new Label();
            textboxTags = new TextBox();
            buttonSave = new Button();
            imagesSave = new ImageList(components);
            mainMenu = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            openRecentMenuItem = new ToolStripMenuItem();
            separator1 = new ToolStripSeparator();
            newFileMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            separator2 = new ToolStripSeparator();
            closeFileMenuItem = new ToolStripMenuItem();
            separator3 = new ToolStripSeparator();
            quitMenuItem = new ToolStripMenuItem();
            helpMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            panelLeft.SuspendLayout();
            panelTop.SuspendLayout();
            contentPanel.SuspendLayout();
            editModePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editSplitPanel).BeginInit();
            editSplitPanel.Panel1.SuspendLayout();
            editSplitPanel.SuspendLayout();
            panelBottom.SuspendLayout();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(tagsPanel);
            panelLeft.Controls.Add(panelTop);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 28);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(229, 693);
            panelLeft.TabIndex = 0;
            // 
            // tagsPanel
            // 
            tagsPanel.AutoScroll = true;
            tagsPanel.Dock = DockStyle.Fill;
            tagsPanel.Location = new Point(0, 70);
            tagsPanel.Name = "tagsPanel";
            tagsPanel.Size = new Size(229, 623);
            tagsPanel.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(checkShowArchive);
            panelTop.Controls.Add(textboxSearch);
            panelTop.Controls.Add(buttonNew);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(229, 70);
            panelTop.TabIndex = 0;
            // 
            // checkShowArchive
            // 
            checkShowArchive.AutoSize = true;
            checkShowArchive.Location = new Point(76, 36);
            checkShowArchive.Name = "checkShowArchive";
            checkShowArchive.Size = new Size(120, 24);
            checkShowArchive.TabIndex = 2;
            checkShowArchive.Text = resources.GetString("show-archive");
            checkShowArchive.UseVisualStyleBackColor = true;
            checkShowArchive.CheckedChanged += OnCheckboxShowArchiveChange;
            // 
            // textboxSearch
            // 
            textboxSearch.Location = new Point(79, 3);
            textboxSearch.Name = "textboxSearch";
            textboxSearch.PlaceholderText = resources.GetString("global-search");
            textboxSearch.Size = new Size(144, 27);
            textboxSearch.TabIndex = 1;
            textboxSearch.WordWrap = false;
            textboxSearch.KeyDown += OnTextboxSearchKeyDown;
            // 
            // buttonNew
            // 
            buttonNew.ImageList = imagesNew;
            buttonNew.Location = new Point(3, 3);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(67, 59);
            buttonNew.TabIndex = 0;
            buttonNew.Text = resources.GetString("new");
            buttonNew.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += OnNewButtonClick;
            // 
            // imagesNew
            // 
            imagesNew.ColorDepth = ColorDepth.Depth32Bit;
            imagesNew.ImageSize = new Size(28, 32);
            imagesNew.TransparentColor = Color.Transparent;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(editModePanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(229, 28);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(777, 693);
            contentPanel.TabIndex = 4;
            // 
            // editModePanel
            // 
            editModePanel.Controls.Add(editSplitPanel);
            editModePanel.Controls.Add(panelBottom);
            editModePanel.Dock = DockStyle.Fill;
            editModePanel.Location = new Point(0, 0);
            editModePanel.Name = "editModePanel";
            editModePanel.Size = new Size(777, 693);
            editModePanel.TabIndex = 2;
            // 
            // editSplitPanel
            // 
            editSplitPanel.Dock = DockStyle.Fill;
            editSplitPanel.Location = new Point(0, 0);
            editSplitPanel.Name = "editSplitPanel";
            // 
            // editSplitPanel.Panel1
            // 
            editSplitPanel.Panel1.Controls.Add(textboxEdit);
            editSplitPanel.Size = new Size(777, 653);
            editSplitPanel.SplitterDistance = 388;
            editSplitPanel.TabIndex = 1;
            // 
            // textboxEdit
            // 
            textboxEdit.Dock = DockStyle.Fill;
            textboxEdit.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textboxEdit.Location = new Point(0, 0);
            textboxEdit.Name = "textboxEdit";
            textboxEdit.Size = new Size(388, 653);
            textboxEdit.TabIndex = 5;
            textboxEdit.Text = "";
            textboxEdit.TextChanged += OnTextboxEditChange;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(labelTags);
            panelBottom.Controls.Add(textboxTags);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 653);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(777, 40);
            panelBottom.TabIndex = 6;
            // 
            // labelTags
            // 
            labelTags.AutoSize = true;
            labelTags.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTags.Location = new Point(6, 8);
            labelTags.Name = "labelTags";
            labelTags.Size = new Size(47, 23);
            labelTags.TabIndex = 3;
            labelTags.Text = resources.GetString("tags");
            // 
            // textboxTags
            // 
            textboxTags.Location = new Point(96, 7);
            textboxTags.Name = "textboxTags";
            textboxTags.PlaceholderText = resources.GetString("tag1-tag2");
            textboxTags.Size = new Size(248, 27);
            textboxTags.TabIndex = 1;
            textboxTags.KeyDown += OnTextboxTagsKeyDown;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.ImageList = imagesSave;
            buttonSave.Location = new Point(375, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(190, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = resources.GetString("add-note");
            buttonSave.TextAlign = ContentAlignment.MiddleRight;
            buttonSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += SaveNote;
            // 
            // imagesSave
            // 
            imagesSave.ColorDepth = ColorDepth.Depth32Bit;
            imagesSave.ImageSize = new Size(18, 18);
            imagesSave.TransparentColor = Color.Transparent;
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileMenuItem, helpMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1006, 28);
            mainMenu.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openRecentMenuItem, separator1, newFileMenuItem, openMenuItem, separator2, closeFileMenuItem, separator3, quitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(46, 24);
            fileMenuItem.Text = resources.GetString("menu-file");
            // 
            // openRecentMenuItem
            // 
            openRecentMenuItem.Name = "openRecentMenuItem";
            openRecentMenuItem.Size = new Size(188, 26);
            openRecentMenuItem.Text = resources.GetString("menu-open-recent");
            // 
            // separator1
            // 
            separator1.Name = "separator1";
            separator1.Size = new Size(185, 6);
            // 
            // newFileMenuItem
            // 
            newFileMenuItem.Name = "newFileMenuItem";
            newFileMenuItem.Size = new Size(188, 26);
            newFileMenuItem.Text = resources.GetString("menu-new");
            newFileMenuItem.Click += OnNewFileClick;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(188, 26);
            openMenuItem.Text = resources.GetString("menu-open");
            openMenuItem.Click += OnOpenFileClick;
            // 
            // separator2
            // 
            separator2.Name = "separator2";
            separator2.Size = new Size(185, 6);
            // 
            // closeFileMenuItem
            // 
            closeFileMenuItem.Name = "closeFileMenuItem";
            closeFileMenuItem.Size = new Size(188, 26);
            closeFileMenuItem.Text = resources.GetString("menu-close");
            closeFileMenuItem.Click += OnCloseFileClick;
            // 
            // separator3
            // 
            separator3.Name = "separator3";
            separator3.Size = new Size(185, 6);
            // 
            // quitMenuItem
            // 
            quitMenuItem.Name = "quitMenuItem";
            quitMenuItem.Size = new Size(188, 26);
            quitMenuItem.Text = resources.GetString("menu-exit");
            quitMenuItem.Click += OnQuitClick;
            // 
            // helpMenuItem
            // 
            helpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMenuItem });
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Size = new Size(55, 24);
            helpMenuItem.Text = resources.GetString("menu-help");
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(210, 26);
            aboutMenuItem.Text = resources.GetString("menu-about");
            aboutMenuItem.Click += OnAboutClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(contentPanel);
            Controls.Add(panelLeft);
            Controls.Add(mainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            Text = "Las Notes";
            WindowState = FormWindowState.Maximized;
            panelLeft.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            contentPanel.ResumeLayout(false);
            editModePanel.ResumeLayout(false);
            editSplitPanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editSplitPanel).EndInit();
            editSplitPanel.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentResourceManager resources;
        private ElementHost wpfHostSingle;
        private ElementHost wpfHostMulti;
        private MarkdownMulti markdownMulti;
        private MarkdownSingle markdownSingle;
        private Panel panelLeft;
        private Panel contentPanel;
        private Panel panelTop;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem openRecentMenuItem;
        private ToolStripSeparator separator1;
        private ToolStripMenuItem newFileMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripSeparator separator2;
        private ToolStripMenuItem closeFileMenuItem;
        private ToolStripSeparator separator3;
        private ToolStripMenuItem quitMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private Button buttonNew;
        private CheckBox checkShowArchive;
        private TextBox textboxSearch;
        private ImageList imagesNew;
        private ImageList imagesSave;
        private SplitContainer editSplitPanel;
        private Panel panelBottom;
        private TextBox textboxTags;
        private Button buttonSave;
        private RichTextBox textboxEdit;
        private Panel editModePanel;
        private FlowLayoutPanel tagsPanel;
        private Label labelTags;
    }
}
