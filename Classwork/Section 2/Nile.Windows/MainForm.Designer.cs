namespace Nile.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MIFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MIProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._MIProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._MIProductDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MIHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Size = new System.Drawing.Size(959, 24);
            this._mainMenu.TabIndex = 0;
            this._mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MIFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _MIFileExit
            // 
            this._MIFileExit.Name = "_MIFileExit";
            this._MIFileExit.Size = new System.Drawing.Size(152, 22);
            this._MIFileExit.Text = "E&xit";
            this._MIFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MIProductAdd,
            this._MIProductEdit,
            this.toolStripSeparator1,
            this._MIProductDelete});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.dToolStripMenuItem.Text = "&Product";
            // 
            // _MIProductAdd
            // 
            this._MIProductAdd.Name = "_MIProductAdd";
            this._MIProductAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._MIProductAdd.Size = new System.Drawing.Size(152, 22);
            this._MIProductAdd.Text = "&Add";
            this._MIProductAdd.Click += new System.EventHandler(this.OnProductAdd);
            // 
            // _MIProductEdit
            // 
            this._MIProductEdit.Name = "_MIProductEdit";
            this._MIProductEdit.Size = new System.Drawing.Size(152, 22);
            this._MIProductEdit.Text = "&Edit";
            this._MIProductEdit.Click += new System.EventHandler(this.OnProductEdit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // _MIProductDelete
            // 
            this._MIProductDelete.Name = "_MIProductDelete";
            this._MIProductDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._MIProductDelete.Size = new System.Drawing.Size(152, 22);
            this._MIProductDelete.Text = "&Delete";
            this._MIProductDelete.Click += new System.EventHandler(this.OnProductDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._MIHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _MIHelpAbout
            // 
            this._MIHelpAbout.Name = "_MIHelpAbout";
            this._MIHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._MIHelpAbout.Size = new System.Drawing.Size(152, 22);
            this._MIHelpAbout.Text = "About";
            this._MIHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 493);
            this.Controls.Add(this._mainMenu);
            this.MainMenuStrip = this._mainMenu;
            this.Name = "MainForm";
            this.Text = "Nile";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._mainMenu.ResumeLayout(false);
            this._mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MIFileExit;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MIProductAdd;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MIProductEdit;
        private System.Windows.Forms.ToolStripMenuItem _MIProductDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _MIHelpAbout;
    }
}

