using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class PickHatchBrush : Form
    {
        // Global Variables.
        public String StyleValue = "";

        // Constructor.
        public PickHatchBrush()
        {
            InitializeComponent();
            comboBoxHatchStylePickHatchBrush.SelectedIndex = 0;
            StyleValue = comboBoxHatchStylePickHatchBrush.Text;
            colorForeground = SystemColors.ButtonFace;
            colorBackground = SystemColors.ButtonFace;
        }

        // Button To Pick color and change the Foreground of the button.
        private void buttonForegroundColorPickHatchBrushBrush_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                colorForeground = colorDialog1.Color;
            colorForeground = Color.FromArgb((byte)trackBarOpacityForegoundPickHatchBrush.Value, colorForeground.R, colorForeground.G, colorForeground.B);
            buttonForegroundColorPickHatchBrushBrush.BackColor = colorForeground;
        }

        // Button To Pick color and change the Background of the button.
        private void buttonBackgroundColorPickHatchBrush_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                colorBackground = colorDialog1.Color;
            colorBackground = Color.FromArgb((byte)trackBarOpacityBackgroundPickHatchBrush.Value, colorBackground.R, colorBackground.G, colorBackground.B);
            buttonBackgroundColorPickHatchBrush.BackColor = colorBackground;
        }

        // Slider to change the opcacity of the Foreground Color
        private void trackBarOpacityForegoundPickHatchBrush_ValueChanged(object sender, EventArgs e)
        {
            colorForeground = Color.FromArgb((byte)trackBarOpacityForegoundPickHatchBrush.Value, colorForeground.R, colorForeground.G, colorForeground.B);
            buttonForegroundColorPickHatchBrushBrush.BackColor = colorForeground;
        }

        // Slider to change the opcacity of the Foreground Color
        private void trackBarOpacityBackgroundPickHatchBrush_ValueChanged(object sender, EventArgs e)
        {
            colorBackground = Color.FromArgb((byte)trackBarOpacityBackgroundPickHatchBrush.Value, colorBackground.R, colorBackground.G, colorBackground.B);
            buttonBackgroundColorPickHatchBrush.BackColor = colorBackground;
        }

        // Listbox Implementation.
        private void comboBoxHatchStylePickHatchBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHatchStylePickHatchBrush.Text = comboBoxHatchStylePickHatchBrush.SelectedItem.ToString();
            StyleValue = comboBoxHatchStylePickHatchBrush.Text;
        }
    }
}
