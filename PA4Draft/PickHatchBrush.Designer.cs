namespace PA4Draft
{
    partial class PickHatchBrush
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBarOpacityEndColorPickLinearGradientBrush = new System.Windows.Forms.TrackBar();
            this.trackBarOpacityStartColorPickLinearGradientBrush = new System.Windows.Forms.TrackBar();
            this.buttonEndColorPickLinearGradientBrush = new System.Windows.Forms.Button();
            this.buttonStartColorPickLinearGradientBrush = new System.Windows.Forms.Button();
            this.buttonCancelPickLinearGradientBrush = new System.Windows.Forms.Button();
            this.buttonOKPickLinearGradientBrush = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityEndColorPickLinearGradientBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityStartColorPickLinearGradientBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hatch Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hatch Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hatch Style";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // trackBarOpacityEndColorPickLinearGradientBrush
            // 
            this.trackBarOpacityEndColorPickLinearGradientBrush.Location = new System.Drawing.Point(39, 195);
            this.trackBarOpacityEndColorPickLinearGradientBrush.Maximum = 255;
            this.trackBarOpacityEndColorPickLinearGradientBrush.Name = "trackBarOpacityEndColorPickLinearGradientBrush";
            this.trackBarOpacityEndColorPickLinearGradientBrush.Size = new System.Drawing.Size(416, 45);
            this.trackBarOpacityEndColorPickLinearGradientBrush.SmallChange = 5;
            this.trackBarOpacityEndColorPickLinearGradientBrush.TabIndex = 13;
            this.trackBarOpacityEndColorPickLinearGradientBrush.Value = 255;
            // 
            // trackBarOpacityStartColorPickLinearGradientBrush
            // 
            this.trackBarOpacityStartColorPickLinearGradientBrush.Location = new System.Drawing.Point(39, 115);
            this.trackBarOpacityStartColorPickLinearGradientBrush.Maximum = 255;
            this.trackBarOpacityStartColorPickLinearGradientBrush.Name = "trackBarOpacityStartColorPickLinearGradientBrush";
            this.trackBarOpacityStartColorPickLinearGradientBrush.Size = new System.Drawing.Size(416, 45);
            this.trackBarOpacityStartColorPickLinearGradientBrush.SmallChange = 5;
            this.trackBarOpacityStartColorPickLinearGradientBrush.TabIndex = 14;
            this.trackBarOpacityStartColorPickLinearGradientBrush.Value = 255;
            // 
            // buttonEndColorPickLinearGradientBrush
            // 
            this.buttonEndColorPickLinearGradientBrush.Location = new System.Drawing.Point(126, 166);
            this.buttonEndColorPickLinearGradientBrush.Name = "buttonEndColorPickLinearGradientBrush";
            this.buttonEndColorPickLinearGradientBrush.Size = new System.Drawing.Size(240, 23);
            this.buttonEndColorPickLinearGradientBrush.TabIndex = 11;
            this.buttonEndColorPickLinearGradientBrush.Text = "Pick a color to end";
            this.buttonEndColorPickLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // buttonStartColorPickLinearGradientBrush
            // 
            this.buttonStartColorPickLinearGradientBrush.Location = new System.Drawing.Point(126, 86);
            this.buttonStartColorPickLinearGradientBrush.Name = "buttonStartColorPickLinearGradientBrush";
            this.buttonStartColorPickLinearGradientBrush.Size = new System.Drawing.Size(240, 23);
            this.buttonStartColorPickLinearGradientBrush.TabIndex = 12;
            this.buttonStartColorPickLinearGradientBrush.Text = "Pick a color to start";
            this.buttonStartColorPickLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // buttonCancelPickLinearGradientBrush
            // 
            this.buttonCancelPickLinearGradientBrush.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelPickLinearGradientBrush.Location = new System.Drawing.Point(336, 291);
            this.buttonCancelPickLinearGradientBrush.Name = "buttonCancelPickLinearGradientBrush";
            this.buttonCancelPickLinearGradientBrush.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelPickLinearGradientBrush.TabIndex = 16;
            this.buttonCancelPickLinearGradientBrush.Text = "Cancel";
            this.buttonCancelPickLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // buttonOKPickLinearGradientBrush
            // 
            this.buttonOKPickLinearGradientBrush.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOKPickLinearGradientBrush.Location = new System.Drawing.Point(67, 280);
            this.buttonOKPickLinearGradientBrush.Name = "buttonOKPickLinearGradientBrush";
            this.buttonOKPickLinearGradientBrush.Size = new System.Drawing.Size(75, 23);
            this.buttonOKPickLinearGradientBrush.TabIndex = 15;
            this.buttonOKPickLinearGradientBrush.Text = "OK";
            this.buttonOKPickLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // PickHatchBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.buttonCancelPickLinearGradientBrush);
            this.Controls.Add(this.buttonOKPickLinearGradientBrush);
            this.Controls.Add(this.trackBarOpacityEndColorPickLinearGradientBrush);
            this.Controls.Add(this.trackBarOpacityStartColorPickLinearGradientBrush);
            this.Controls.Add(this.buttonEndColorPickLinearGradientBrush);
            this.Controls.Add(this.buttonStartColorPickLinearGradientBrush);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PickHatchBrush";
            this.Text = "PickHatchBrush";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityEndColorPickLinearGradientBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityStartColorPickLinearGradientBrush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBarOpacityEndColorPickLinearGradientBrush;
        private System.Windows.Forms.TrackBar trackBarOpacityStartColorPickLinearGradientBrush;
        private System.Windows.Forms.Button buttonEndColorPickLinearGradientBrush;
        private System.Windows.Forms.Button buttonStartColorPickLinearGradientBrush;
        private System.Windows.Forms.Button buttonCancelPickLinearGradientBrush;
        private System.Windows.Forms.Button buttonOKPickLinearGradientBrush;
    }
}