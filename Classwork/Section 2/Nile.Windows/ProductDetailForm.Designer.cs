namespace Nile.Windows
{
    partial class ProductDetailForm
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
            this._textName = new System.Windows.Forms.TextBox();
            this._textDescription = new System.Windows.Forms.TextBox();
            this._textPrice = new System.Windows.Forms.TextBox();
            this._checkIsDiscontinued = new System.Windows.Forms.CheckBox();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonSave = new System.Windows.Forms.Button();
            this._labelName = new System.Windows.Forms.Label();
            this._labelDescription = new System.Windows.Forms.Label();
            this._labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textName
            // 
            this._textName.Location = new System.Drawing.Point(136, 72);
            this._textName.Name = "_textName";
            this._textName.Size = new System.Drawing.Size(189, 20);
            this._textName.TabIndex = 0;
            // 
            // _textDescription
            // 
            this._textDescription.Location = new System.Drawing.Point(135, 98);
            this._textDescription.Multiline = true;
            this._textDescription.Name = "_textDescription";
            this._textDescription.Size = new System.Drawing.Size(190, 85);
            this._textDescription.TabIndex = 1;
            // 
            // _textPrice
            // 
            this._textPrice.Location = new System.Drawing.Point(135, 189);
            this._textPrice.Name = "_textPrice";
            this._textPrice.Size = new System.Drawing.Size(190, 20);
            this._textPrice.TabIndex = 2;
            // 
            // _checkIsDiscontinued
            // 
            this._checkIsDiscontinued.AutoSize = true;
            this._checkIsDiscontinued.Location = new System.Drawing.Point(136, 215);
            this._checkIsDiscontinued.Name = "_checkIsDiscontinued";
            this._checkIsDiscontinued.Size = new System.Drawing.Size(105, 17);
            this._checkIsDiscontinued.TabIndex = 3;
            this._checkIsDiscontinued.Text = "Is Discontinued?";
            this._checkIsDiscontinued.UseVisualStyleBackColor = true;
            // 
            // _buttonCancel
            // 
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(272, 321);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 4;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _buttonSave
            // 
            this._buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._buttonSave.Location = new System.Drawing.Point(191, 321);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 5;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Location = new System.Drawing.Point(67, 72);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(35, 13);
            this._labelName.TabIndex = 6;
            this._labelName.Text = "Name";
            // 
            // _labelDescription
            // 
            this._labelDescription.AutoSize = true;
            this._labelDescription.Location = new System.Drawing.Point(42, 105);
            this._labelDescription.Name = "_labelDescription";
            this._labelDescription.Size = new System.Drawing.Size(60, 13);
            this._labelDescription.TabIndex = 7;
            this._labelDescription.Text = "Description";
            // 
            // _labelPrice
            // 
            this._labelPrice.AutoSize = true;
            this._labelPrice.Location = new System.Drawing.Point(71, 192);
            this._labelPrice.Name = "_labelPrice";
            this._labelPrice.Size = new System.Drawing.Size(31, 13);
            this._labelPrice.TabIndex = 8;
            this._labelPrice.Text = "Price";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 356);
            this.Controls.Add(this._labelPrice);
            this.Controls.Add(this._labelDescription);
            this.Controls.Add(this._labelName);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._checkIsDiscontinued);
            this.Controls.Add(this._textPrice);
            this.Controls.Add(this._textDescription);
            this.Controls.Add(this._textName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetailForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textName;
        private System.Windows.Forms.TextBox _textDescription;
        private System.Windows.Forms.TextBox _textPrice;
        private System.Windows.Forms.CheckBox _checkIsDiscontinued;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.Label _labelDescription;
        private System.Windows.Forms.Label _labelPrice;
    }
}