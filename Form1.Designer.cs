namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemParagraph = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolBtnCreate = new System.Windows.Forms.ToolStripButton();
            this.toolBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFont = new System.Windows.Forms.ToolStripButton();
            this.toolBtnParagraph = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeTabPageContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuItemFile,
            this.menuItemEdit,
            this.menuItemFormat,
            this.menuItemView,
            this.menuItemAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(780, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreate,
            this.menuItemOpen,
            this.toolStripMenuItem2,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.toolStripMenuItem3,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(48, 20);
            this.menuItemFile.Text = "Файл";
            // 
            // menuItemCreate
            // 
            this.menuItemCreate.Name = "menuItemCreate";
            this.menuItemCreate.Size = new System.Drawing.Size(163, 22);
            this.menuItemCreate.Text = "Создать";
            this.menuItemCreate.Click += new System.EventHandler(this.menuItemCreate_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(163, 22);
            this.menuItemOpen.Text = "Открыть";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(163, 22);
            this.menuItemSave.Text = "Сохранить";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(163, 22);
            this.menuItemSaveAs.Text = "Сохранить как...";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(163, 22);
            this.menuItemExit.Text = "Выход";
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCopy,
            this.menuItemCut,
            this.menuItemPaste});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(59, 20);
            this.menuItemEdit.Text = "Правка";
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.Size = new System.Drawing.Size(139, 22);
            this.menuItemCopy.Text = "Копировать";
            // 
            // menuItemCut
            // 
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.Size = new System.Drawing.Size(139, 22);
            this.menuItemCut.Text = "Вырезать";
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.Size = new System.Drawing.Size(139, 22);
            this.menuItemPaste.Text = "Вставить";
            // 
            // menuItemFormat
            // 
            this.menuItemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFont,
            this.menuItemColor,
            this.menuItemParagraph});
            this.menuItemFormat.Name = "menuItemFormat";
            this.menuItemFormat.Size = new System.Drawing.Size(62, 20);
            this.menuItemFormat.Text = "Формат";
            // 
            // menuItemFont
            // 
            this.menuItemFont.Name = "menuItemFont";
            this.menuItemFont.Size = new System.Drawing.Size(113, 22);
            this.menuItemFont.Text = "Шрифт";
            // 
            // menuItemColor
            // 
            this.menuItemColor.Name = "menuItemColor";
            this.menuItemColor.Size = new System.Drawing.Size(113, 22);
            this.menuItemColor.Text = "Цвет";
            // 
            // menuItemParagraph
            // 
            this.menuItemParagraph.Name = "menuItemParagraph";
            this.menuItemParagraph.Size = new System.Drawing.Size(113, 22);
            this.menuItemParagraph.Text = "Абзац";
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemToolBar,
            this.menuItemStatusBar});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(39, 20);
            this.menuItemView.Text = "Вид";
            // 
            // menuItemToolBar
            // 
            this.menuItemToolBar.Name = "menuItemToolBar";
            this.menuItemToolBar.Size = new System.Drawing.Size(196, 22);
            this.menuItemToolBar.Text = "Панель инструментов";
            // 
            // menuItemStatusBar
            // 
            this.menuItemStatusBar.Name = "menuItemStatusBar";
            this.menuItemStatusBar.Size = new System.Drawing.Size(196, 22);
            this.menuItemStatusBar.Text = "Строка состояния";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(94, 20);
            this.menuItemAbout.Text = "О программе";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 411);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(780, 22);
            this.statusBar.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnCreate,
            this.toolBtnOpen,
            this.toolBtnSave,
            this.toolBtnFont,
            this.toolBtnParagraph});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(780, 25);
            this.toolBar.TabIndex = 2;
            // 
            // toolBtnCreate
            // 
            this.toolBtnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnCreate.Image")));
            this.toolBtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCreate.Name = "toolBtnCreate";
            this.toolBtnCreate.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCreate.Text = "Создать";
            this.toolBtnCreate.Click += new System.EventHandler(this.toolBtnCreate_Click);
            // 
            // toolBtnOpen
            // 
            this.toolBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnOpen.Image")));
            this.toolBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnOpen.Name = "toolBtnOpen";
            this.toolBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.toolBtnOpen.Text = "Открыть";
            // 
            // toolBtnSave
            // 
            this.toolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSave.Image")));
            this.toolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSave.Name = "toolBtnSave";
            this.toolBtnSave.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSave.Text = "Сохранить";
            // 
            // toolBtnFont
            // 
            this.toolBtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFont.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnFont.Image")));
            this.toolBtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFont.Name = "toolBtnFont";
            this.toolBtnFont.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFont.Text = "Шрифт";
            this.toolBtnFont.Click += new System.EventHandler(this.toolBtnFont_Click);
            // 
            // toolBtnParagraph
            // 
            this.toolBtnParagraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnParagraph.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnParagraph.Image")));
            this.toolBtnParagraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnParagraph.Name = "toolBtnParagraph";
            this.toolBtnParagraph.Size = new System.Drawing.Size(23, 22);
            this.toolBtnParagraph.Text = "Абзац";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(780, 362);
            this.tabControl.TabIndex = 3;
            this.tabControl.Visible = false;
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlRemoved);
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabPageContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(121, 26);
            // 
            // closeTabPageContextMenuItem
            // 
            this.closeTabPageContextMenuItem.Name = "closeTabPageContextMenuItem";
            this.closeTabPageContextMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeTabPageContextMenuItem.Text = "Закрыть";
            this.closeTabPageContextMenuItem.Click += new System.EventHandler(this.closeTabPageContextMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 433);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemFormat;
        private System.Windows.Forms.ToolStripMenuItem menuItemFont;
        private System.Windows.Forms.ToolStripMenuItem menuItemColor;
        private System.Windows.Forms.ToolStripMenuItem menuItemParagraph;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemStatusBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolBtnCreate;
        private System.Windows.Forms.ToolStripButton toolBtnOpen;
        private System.Windows.Forms.ToolStripButton toolBtnSave;
        private System.Windows.Forms.ToolStripButton toolBtnFont;
        private System.Windows.Forms.ToolStripButton toolBtnParagraph;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeTabPageContextMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

