using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class PickLinearGradientBrush : Form
    {
        // Global Variables.
        public String LinearModes = "";
        public static int RectangleX = 0;
        public static int RectangleY = 0;
        public static int RectangleWidth = 0;
        public static int RectangleHeigh = 0;
        public Rectangle newRectangle = new Rectangle(RectangleX, RectangleY, RectangleWidth, RectangleHeigh);

        // Constructor.
        public PickLinearGradientBrush()
        {
            InitializeComponent();
            comboBoxModesPickLinearGradientBrush.SelectedIndex = 0;
            LinearModes = comboBoxModesPickLinearGradientBrush.Text;
            colorStart = SystemColors.ButtonFace;
            colorEnd = SystemColors.ButtonFace;
        }

        // Button To Pick color and change the Start button.
        private void buttonStartColorPickLinearGradientBrush_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                colorStart = colorDialog1.Color;
            colorStart = Color.FromArgb((byte)trackBarOpacityStartColorPickLinearGradientBrush.Value, colorStart.R, colorStart.G, colorStart.B);
            buttonStartColorPickLinearGradientBrush.BackColor = colorStart;
        }

        // Button To Pick color and change the End button.
        private void buttonEndColorPickLinearGradientBrush_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                colorEnd = colorDialog1.Color;
            colorEnd = Color.FromArgb((byte)trackBarOpacityEndColorPickLinearGradientBrush.Value, colorEnd.R, colorEnd.G, colorEnd.B);
            buttonEndColorPickLinearGradientBrush.BackColor = colorEnd;
        }

        // Slider to change the opacity of the Start Color
        private void trackBarOpacityStartColorPickLinearGradientBrush_ValueChanged(object sender, EventArgs e)
        {
            colorStart = Color.FromArgb((byte)trackBarOpacityStartColorPickLinearGradientBrush.Value, colorStart.R, colorStart.G, colorStart.B);
            buttonStartColorPickLinearGradientBrush.BackColor = colorStart;
        }

        // Slider to change the opacity of the End Color
        private void trackBarOpacityEndColorPickLinearGradientBrush_ValueChanged(object sender, EventArgs e)
        {
            colorEnd = Color.FromArgb((byte)trackBarOpacityEndColorPickLinearGradientBrush.Value, colorEnd.R, colorEnd.G, colorEnd.B);
            buttonEndColorPickLinearGradientBrush.BackColor = colorEnd;
        }

        // Dropdown Implementation.
        private void comboBoxModesPickLinearGradientBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModesPickLinearGradientBrush.Text = comboBoxModesPickLinearGradientBrush.SelectedItem.ToString();
            LinearModes = comboBoxModesPickLinearGradientBrush.Text;
        }

        // XLocation Button.
        private void numericUpDownXLocation_ValueChanged(object sender, EventArgs e)
        {
            RectangleX = (int)numericUpDownXLocation.Value;
            newRectangle = new Rectangle(RectangleX, RectangleY, RectangleWidth, RectangleHeigh);
        }

        // YLocation Button.
        private void numericUpDownYLocation_ValueChanged(object sender, EventArgs e)
        {
            RectangleY = (int)numericUpDownYLocation.Value;
            newRectangle = new Rectangle(RectangleX, RectangleY, RectangleWidth, RectangleHeigh);
        }

        // Width Button.
        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            RectangleWidth = (int)numericUpDownWidth.Value;
            newRectangle = new Rectangle(RectangleX, RectangleY, RectangleWidth, RectangleHeigh);
        }

        // Height Button.
        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            RectangleHeigh = (int)numericUpDownHeight.Value;
            newRectangle = new Rectangle(RectangleX, RectangleY, RectangleWidth, RectangleHeigh);
        }
    }
}
