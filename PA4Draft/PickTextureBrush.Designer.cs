namespace PA4Draft
{
    partial class PickTextureBrush
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
            this.WrapModeLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.comboBoxWrapModes = new System.Windows.Forms.ComboBox();
            this.buttonPickImagePickTextureBrush = new System.Windows.Forms.Button();
            this.buttonOKPickTextureBrush = new System.Windows.Forms.Button();
            this.OpenFileImage = new System.Windows.Forms.OpenFileDialog();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WrapModeLabel
            // 
            this.WrapModeLabel.AutoSize = true;
            this.WrapModeLabel.Location = new System.Drawing.Point(58, 73);
            this.WrapModeLabel.Name = "WrapModeLabel";
            this.WrapModeLabel.Size = new System.Drawing.Size(65, 13);
            this.WrapModeLabel.TabIndex = 0;
            this.WrapModeLabel.Text = "WrapModes";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(61, 122);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 1;
            this.ImageLabel.Text = "Image";
            // 
            // comboBoxWrapModes
            // 
            this.comboBoxWrapModes.FormattingEnabled = true;
            this.comboBoxWrapModes.Items.AddRange(new object[] {
            "Clamp",
            "Tile",
            "TileFlipX",
            "TileFlipXY",
            "TileFlipY"});
            this.comboBoxWrapModes.Location = new System.Drawing.Point(181, 73);
            this.comboBoxWrapModes.Name = "comboBoxWrapModes";
            this.comboBoxWrapModes.Size = new System.Drawing.Size(278, 21);
            this.comboBoxWrapModes.TabIndex = 2;
            this.comboBoxWrapModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxWrapModes_SelectedIndexChanged);
            // 
            // buttonPickImagePickTextureBrush
            // 
            this.buttonPickImagePickTextureBrush.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPickImagePickTextureBrush.Location = new System.Drawing.Point(181, 111);
            this.buttonPickImagePickTextureBrush.Name = "buttonPickImagePickTextureBrush";
            this.buttonPickImagePickTextureBrush.Size = new System.Drawing.Size(278, 23);
            this.buttonPickImagePickTextureBrush.TabIndex = 3;
            this.buttonPickImagePickTextureBrush.Text = "Choose Image";
            this.buttonPickImagePickTextureBrush.UseVisualStyleBackColor = true;
            this.buttonPickImagePickTextureBrush.Click += new System.EventHandler(this.buttonPickImagePickTextureBrush_Click);
            // 
            // buttonOKPickTextureBrush
            // 
            this.buttonOKPickTextureBrush.Location = new System.Drawing.Point(47, 231);
            this.buttonOKPickTextureBrush.Name = "buttonOKPickTextureBrush";
            this.buttonOKPickTextureBrush.Size = new System.Drawing.Size(128, 42);
            this.buttonOKPickTextureBrush.TabIndex = 4;
            this.buttonOKPickTextureBrush.Text = "OK";
            this.buttonOKPickTextureBrush.UseVisualStyleBackColor = true;
            // 
            // OpenFileImage
            // 
            this.OpenFileImage.FileName = "OpenFileImage";
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(347, 231);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 42);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // PickTextureBrush
            // 
            this.AcceptButton = this.buttonOKPickTextureBrush;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.buttonOKPickTextureBrush);
            this.Controls.Add(this.buttonPickImagePickTextureBrush);
            this.Controls.Add(this.comboBoxWrapModes);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.WrapModeLabel);
            this.Name = "PickTextureBrush";
            this.Text = "PickTextureBrush";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WrapModeLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.ComboBox comboBoxWrapModes;
        private System.Windows.Forms.Button buttonPickImagePickTextureBrush;
        private System.Windows.Forms.Button buttonOKPickTextureBrush;
        private System.Windows.Forms.OpenFileDialog OpenFileImage;
        private System.Windows.Forms.Button cancel;
    }
}