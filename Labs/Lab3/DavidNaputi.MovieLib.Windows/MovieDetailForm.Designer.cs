namespace DavidNaputi.MovieLib.Windows
{
    partial class MovieDetailForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._txtTitle = new System.Windows.Forms.TextBox();
            this._labelTitle = new System.Windows.Forms.Label();
            this._labelDescription = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtLength = new System.Windows.Forms.TextBox();
            this._labelLength = new System.Windows.Forms.Label();
            this._chkOwned = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(323, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnCancel);
            // 
            // _txtTitle
            // 
            this._txtTitle.Location = new System.Drawing.Point(93, 12);
            this._txtTitle.Name = "_txtTitle";
            this._txtTitle.Size = new System.Drawing.Size(305, 20);
            this._txtTitle.TabIndex = 2;
            this._txtTitle.TextChanged += new System.EventHandler(this.TextTitle);
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Location = new System.Drawing.Point(60, 15);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(27, 13);
            this._labelTitle.TabIndex = 3;
            this._labelTitle.Text = "Title";
            this._labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // _labelDescription
            // 
            this._labelDescription.AutoSize = true;
            this._labelDescription.Location = new System.Drawing.Point(27, 41);
            this._labelDescription.Name = "_labelDescription";
            this._labelDescription.Size = new System.Drawing.Size(60, 13);
            this._labelDescription.TabIndex = 5;
            this._labelDescription.Text = "Description";
            this._labelDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(93, 38);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(305, 99);
            this._txtDescription.TabIndex = 6;
            this._txtDescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // _txtLength
            // 
            this._txtLength.Location = new System.Drawing.Point(93, 143);
            this._txtLength.Name = "_txtLength";
            this._txtLength.Size = new System.Drawing.Size(60, 20);
            this._txtLength.TabIndex = 7;
            this._txtLength.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // _labelLength
            // 
            this._labelLength.AutoSize = true;
            this._labelLength.Location = new System.Drawing.Point(47, 145);
            this._labelLength.Name = "_labelLength";
            this._labelLength.Size = new System.Drawing.Size(40, 13);
            this._labelLength.TabIndex = 8;
            this._labelLength.Text = "Length";
            this._labelLength.Click += new System.EventHandler(this.label3_Click);
            // 
            // _chkOwned
            // 
            this._chkOwned.AutoSize = true;
            this._chkOwned.Location = new System.Drawing.Point(93, 168);
            this._chkOwned.Name = "_chkOwned";
            this._chkOwned.Size = new System.Drawing.Size(60, 17);
            this._chkOwned.TabIndex = 9;
            this._chkOwned.Text = "Owned";
            this._chkOwned.UseVisualStyleBackColor = true;
            this._chkOwned.CheckedChanged += new System.EventHandler(this.CheckBoxIsOwned);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "minutes";
            // 
            // _errorProvider
            // 
            this._errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errorProvider.ContainerControl = this;
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 232);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._chkOwned);
            this.Controls.Add(this._labelLength);
            this.Controls.Add(this._txtLength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._labelDescription);
            this.Controls.Add(this._labelTitle);
            this.Controls.Add(this._txtTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MovieDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.MovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox _txtTitle;
        private System.Windows.Forms.Label _labelTitle;
        private System.Windows.Forms.Label _labelDescription;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtLength;
        private System.Windows.Forms.Label _labelLength;
        private System.Windows.Forms.CheckBox _chkOwned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}