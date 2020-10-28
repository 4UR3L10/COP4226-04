using System.Drawing;

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
            this.labelOpacityForegroundHatchBrush = new System.Windows.Forms.Label();
            this.labelOpacityBackgroundHatchBrush = new System.Windows.Forms.Label();
            this.comboBoxHatchStylePickHatchBrush = new System.Windows.Forms.ComboBox();
            this.trackBarOpacityBackgroundPickHatchBrush = new System.Windows.Forms.TrackBar();
            this.trackBarOpacityForegoundPickHatchBrush = new System.Windows.Forms.TrackBar();
            this.buttonBackgroundColorPickHatchBrush = new System.Windows.Forms.Button();
            this.buttonForegroundColorPickHatchBrushBrush = new System.Windows.Forms.Button();
            this.buttonCancelPickHatchBrush = new System.Windows.Forms.Button();
            this.buttonOKPickHatchBrush = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityBackgroundPickHatchBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityForegoundPickHatchBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hatch Style";
            // 
            // labelOpacityForegroundHatchBrush
            // 
            this.labelOpacityForegroundHatchBrush.AutoSize = true;
            this.labelOpacityForegroundHatchBrush.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpacityForegroundHatchBrush.Location = new System.Drawing.Point(112, 210);
            this.labelOpacityForegroundHatchBrush.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelOpacityForegroundHatchBrush.Name = "labelOpacityForegroundHatchBrush";
            this.labelOpacityForegroundHatchBrush.Size = new System.Drawing.Size(106, 31);
            this.labelOpacityForegroundHatchBrush.TabIndex = 0;
            this.labelOpacityForegroundHatchBrush.Text = "Opacity";
            // 
            // labelOpacityBackgroundHatchBrush
            // 
            this.labelOpacityBackgroundHatchBrush.AutoSize = true;
            this.labelOpacityBackgroundHatchBrush.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpacityBackgroundHatchBrush.Location = new System.Drawing.Point(112, 352);
            this.labelOpacityBackgroundHatchBrush.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelOpacityBackgroundHatchBrush.Name = "labelOpacityBackgroundHatchBrush";
            this.labelOpacityBackgroundHatchBrush.Size = new System.Drawing.Size(106, 31);
            this.labelOpacityBackgroundHatchBrush.TabIndex = 0;
            this.labelOpacityBackgroundHatchBrush.Text = "Opacity";
            // 
            // comboBoxHatchStylePickHatchBrush
            // 
            this.comboBoxHatchStylePickHatchBrush.FormattingEnabled = true;
            this.comboBoxHatchStylePickHatchBrush.Items.AddRange(new object[] {
            "BackwardDiagonal",
            "Cross",
            "DarkDownwardDiagonal",
            "DarkHorizontal",
            "DarkUpwardDiagonal",
            "DarkVertical",
            "DashedDownwardDiagonal",
            "DashedHorizontal",
            "DashedUpwardDiagonal",
            "DashedVertical",
            "DiagonalBrick",
            "DiagonalCross",
            "Divot",
            "DottedDiamond",
            "DottedGrid",
            "ForwardDiagonal",
            "Horizontal",
            "HorizontalBrick",
            "LargeCheckerBoard",
            "LargeConfetti",
            "LargeGrid",
            "LightDownwardDiagonal",
            "LightHorizontal",
            "LightUpwardDiagonal",
            "LightVertical",
            "Max",
            "Min",
            "NarrowHorizontal",
            "NarrowVertical",
            "OutlinedDiamond",
            "Percent05",
            "Percent10",
            "Percent20",
            "Percent25",
            "Percent30",
            "Percent40",
            "Percent50",
            "Percent60",
            "Percent70",
            "Percent75",
            "Percent80",
            "Percent90",
            "Plaid",
            "Shingle",
            "SmallCheckerBoard",
            "SmallConfetti",
            "SmallGrid",
            "SolidDiamond",
            "Sphere",
            "Trellis",
            "Vertical",
            "Wave",
            "Weave",
            "WideDownwardDiagonal",
            "WideUpwardDiagonal",
            "ZigZag"});
            this.comboBoxHatchStylePickHatchBrush.Location = new System.Drawing.Point(294, 70);
            this.comboBoxHatchStylePickHatchBrush.Name = "comboBoxHatchStylePickHatchBrush";
            this.comboBoxHatchStylePickHatchBrush.Size = new System.Drawing.Size(560, 37);
            this.comboBoxHatchStylePickHatchBrush.TabIndex = 1;
            this.comboBoxHatchStylePickHatchBrush.SelectedIndexChanged += new System.EventHandler(this.comboBoxHatchStylePickHatchBrush_SelectedIndexChanged);
            // 
            // trackBarOpacityBackgroundPickHatchBrush
            // 
            this.trackBarOpacityBackgroundPickHatchBrush.Location = new System.Drawing.Point(91, 435);
            this.trackBarOpacityBackgroundPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.trackBarOpacityBackgroundPickHatchBrush.Maximum = 255;
            this.trackBarOpacityBackgroundPickHatchBrush.Name = "trackBarOpacityBackgroundPickHatchBrush";
            this.trackBarOpacityBackgroundPickHatchBrush.Size = new System.Drawing.Size(971, 101);
            this.trackBarOpacityBackgroundPickHatchBrush.SmallChange = 5;
            this.trackBarOpacityBackgroundPickHatchBrush.TabIndex = 13;
            this.trackBarOpacityBackgroundPickHatchBrush.Value = 255;
            this.trackBarOpacityBackgroundPickHatchBrush.ValueChanged += new System.EventHandler(this.trackBarOpacityBackgroundPickHatchBrush_ValueChanged);
            // 
            // trackBarOpacityForegoundPickHatchBrush
            // 
            this.trackBarOpacityForegoundPickHatchBrush.Location = new System.Drawing.Point(91, 257);
            this.trackBarOpacityForegoundPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.trackBarOpacityForegoundPickHatchBrush.Maximum = 255;
            this.trackBarOpacityForegoundPickHatchBrush.Name = "trackBarOpacityForegoundPickHatchBrush";
            this.trackBarOpacityForegoundPickHatchBrush.Size = new System.Drawing.Size(971, 101);
            this.trackBarOpacityForegoundPickHatchBrush.SmallChange = 5;
            this.trackBarOpacityForegoundPickHatchBrush.TabIndex = 14;
            this.trackBarOpacityForegoundPickHatchBrush.Value = 255;
            this.trackBarOpacityForegoundPickHatchBrush.ValueChanged += new System.EventHandler(this.trackBarOpacityForegoundPickHatchBrush_ValueChanged);
            // 
            // buttonBackgroundColorPickHatchBrush
            // 
            this.buttonBackgroundColorPickHatchBrush.Location = new System.Drawing.Point(294, 370);
            this.buttonBackgroundColorPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonBackgroundColorPickHatchBrush.Name = "buttonBackgroundColorPickHatchBrush";
            this.buttonBackgroundColorPickHatchBrush.Size = new System.Drawing.Size(560, 51);
            this.buttonBackgroundColorPickHatchBrush.TabIndex = 11;
            this.buttonBackgroundColorPickHatchBrush.Text = "Choose a Background Color";
            this.buttonBackgroundColorPickHatchBrush.UseVisualStyleBackColor = true;
            this.buttonBackgroundColorPickHatchBrush.Click += new System.EventHandler(this.buttonBackgroundColorPickHatchBrush_Click);
            // 
            // buttonForegroundColorPickHatchBrushBrush
            // 
            this.buttonForegroundColorPickHatchBrushBrush.Location = new System.Drawing.Point(294, 192);
            this.buttonForegroundColorPickHatchBrushBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonForegroundColorPickHatchBrushBrush.Name = "buttonForegroundColorPickHatchBrushBrush";
            this.buttonForegroundColorPickHatchBrushBrush.Size = new System.Drawing.Size(560, 51);
            this.buttonForegroundColorPickHatchBrushBrush.TabIndex = 12;
            this.buttonForegroundColorPickHatchBrushBrush.Text = "Choose Foreground Color";
            this.buttonForegroundColorPickHatchBrushBrush.UseVisualStyleBackColor = true;
            this.buttonForegroundColorPickHatchBrushBrush.Click += new System.EventHandler(this.buttonForegroundColorPickHatchBrushBrush_Click);
            // 
            // buttonCancelPickHatchBrush
            // 
            this.buttonCancelPickHatchBrush.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelPickHatchBrush.Location = new System.Drawing.Point(784, 649);
            this.buttonCancelPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonCancelPickHatchBrush.Name = "buttonCancelPickHatchBrush";
            this.buttonCancelPickHatchBrush.Size = new System.Drawing.Size(175, 51);
            this.buttonCancelPickHatchBrush.TabIndex = 16;
            this.buttonCancelPickHatchBrush.Text = "Cancel";
            this.buttonCancelPickHatchBrush.UseVisualStyleBackColor = true;
            // 
            // buttonOKPickHatchBrush
            // 
            this.buttonOKPickHatchBrush.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOKPickHatchBrush.Location = new System.Drawing.Point(156, 625);
            this.buttonOKPickHatchBrush.Margin = new System.Windows.Forms.Padding(7);
            this.buttonOKPickHatchBrush.Name = "buttonOKPickHatchBrush";
            this.buttonOKPickHatchBrush.Size = new System.Drawing.Size(175, 51);
            this.buttonOKPickHatchBrush.TabIndex = 15;
            this.buttonOKPickHatchBrush.Text = "OK";
            this.buttonOKPickHatchBrush.UseVisualStyleBackColor = true;
            // 
            // PickHatchBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1004);
            this.Controls.Add(this.buttonCancelPickHatchBrush);
            this.Controls.Add(this.buttonOKPickHatchBrush);
            this.Controls.Add(this.trackBarOpacityBackgroundPickHatchBrush);
            this.Controls.Add(this.trackBarOpacityForegoundPickHatchBrush);
            this.Controls.Add(this.buttonBackgroundColorPickHatchBrush);
            this.Controls.Add(this.buttonForegroundColorPickHatchBrushBrush);
            this.Controls.Add(this.comboBoxHatchStylePickHatchBrush);
            this.Controls.Add(this.labelOpacityBackgroundHatchBrush);
            this.Controls.Add(this.labelOpacityForegroundHatchBrush);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "PickHatchBrush";
            this.Text = "PickHatchBrush";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityBackgroundPickHatchBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityForegoundPickHatchBrush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOpacityForegroundHatchBrush;
        private System.Windows.Forms.Label labelOpacityBackgroundHatchBrush;
        private System.Windows.Forms.ComboBox comboBoxHatchStylePickHatchBrush;
        private System.Windows.Forms.TrackBar trackBarOpacityBackgroundPickHatchBrush;
        private System.Windows.Forms.TrackBar trackBarOpacityForegoundPickHatchBrush;
        private System.Windows.Forms.Button buttonBackgroundColorPickHatchBrush;
        private System.Windows.Forms.Button buttonForegroundColorPickHatchBrushBrush;
        private System.Windows.Forms.Button buttonCancelPickHatchBrush;
        private System.Windows.Forms.Button buttonOKPickHatchBrush;
        private System.Windows.Forms.ColorDialog colorDialog1;
        internal Color colorForeground;
        internal Color colorBackground;      
    }
}