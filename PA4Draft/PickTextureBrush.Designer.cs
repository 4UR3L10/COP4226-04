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
            this.buttonOKPickHatchBrush = new System.Windows.Forms.Button();
            this.buttonCancelPickHatchBrush = new System.Windows.Forms.Button();
            this.OpenFileImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // WrapModeLabel
            // 
            this.WrapModeLabel.AutoSize = true;
            this.WrapModeLabel.Location = new System.Drawing.Point(135, 163);
            this.WrapModeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.WrapModeLabel.Name = "WrapModeLabel";
            this.WrapModeLabel.Size = new System.Drawing.Size(144, 29);
            this.WrapModeLabel.TabIndex = 0;
            this.WrapModeLabel.Text = "WrapModes";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(142, 272);
            this.ImageLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(80, 29);
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
            this.comboBoxWrapModes.Location = new System.Drawing.Point(422, 163);
            this.comboBoxWrapModes.Margin = new System.Windows.Forms.Padding(7);
            this.comboBoxWrapModes.Name = "comboBoxWrapModes";
            this.comboBoxWrapModes.Size = new System.Drawing.Size(643, 37);
            this.comboBoxWrapModes.TabIndex = 2;
            this.comboBoxWrapModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxWrapModes_SelectedIndexChanged);
            // 
            // buttonPickImagePickTextureBrush
            // 
            this.buttonPickImagePickTextureBrush.Location = new System.Drawing.Point(422, 248);
            this.buttonPickImagePickTextureBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonPickImagePickTextureBrush.Name = "buttonPickImagePickTextureBrush";
            this.buttonPickImagePickTextureBrush.Size = new System.Drawing.Size(649, 51);
            this.buttonPickImagePickTextureBrush.TabIndex = 3;
            this.buttonPickImagePickTextureBrush.Text = "Choose Image";
            this.buttonPickImagePickTextureBrush.UseVisualStyleBackColor = true;
            this.buttonPickImagePickTextureBrush.Click += new System.EventHandler(this.buttonPickImagePickTextureBrush_Click);
            // 
            // buttonOKPickHatchBrush
            // 
            this.buttonOKPickHatchBrush.Location = new System.Drawing.Point(110, 515);
            this.buttonOKPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonOKPickHatchBrush.Name = "buttonOKPickHatchBrush";
            this.buttonOKPickHatchBrush.Size = new System.Drawing.Size(299, 94);
            this.buttonOKPickHatchBrush.TabIndex = 4;
            this.buttonOKPickHatchBrush.Text = "OK";
            this.buttonOKPickHatchBrush.UseVisualStyleBackColor = true;
            // 
            // buttonCancelPickHatchBrush
            // 
            this.buttonCancelPickHatchBrush.Location = new System.Drawing.Point(763, 515);
            this.buttonCancelPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonCancelPickHatchBrush.Name = "buttonCancelPickHatchBrush";
            this.buttonCancelPickHatchBrush.Size = new System.Drawing.Size(308, 94);
            this.buttonCancelPickHatchBrush.TabIndex = 5;
            this.buttonCancelPickHatchBrush.Text = "Cancel";
            this.buttonCancelPickHatchBrush.UseVisualStyleBackColor = true;
            // 
            // OpenFileImage
            // 
            this.OpenFileImage.FileName = "OpenFileImage";
            // 
            // PickTextureBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.buttonCancelPickHatchBrush);
            this.Controls.Add(this.buttonOKPickHatchBrush);
            this.Controls.Add(this.buttonPickImagePickTextureBrush);
            this.Controls.Add(this.comboBoxWrapModes);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.WrapModeLabel);
            this.Margin = new System.Windows.Forms.Padding(7);
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
        private System.Windows.Forms.Button buttonOKPickHatchBrush;
        private System.Windows.Forms.Button buttonCancelPickHatchBrush;
        private System.Windows.Forms.OpenFileDialog OpenFileImage;
    }
}