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
    public partial class PickTextureBrush : Form
    {
        // Global Variables.
        public String WarpModeValue = "";
        public Image imageObject = null;

        // Constructor.
        public PickTextureBrush()
        {
            InitializeComponent();
            comboBoxWrapModes.SelectedIndex = 0;
            WarpModeValue = comboBoxWrapModes.Text;
        }

        // Selection of the Wrap Modes
        private void comboBoxWrapModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxWrapModes.Text = comboBoxWrapModes.SelectedItem.ToString();
            WarpModeValue = comboBoxWrapModes.Text;
        }

        // Use Open Dialog to open the image file.
        private void buttonPickImagePickTextureBrush_Click(object sender, EventArgs e)
        {
            // Set properties.
            String ImageFileName = "";
            OpenFileImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            // Opening the file.
            DialogResult FileDialog = OpenFileImage.ShowDialog();

            // Ok Button.
            if (FileDialog == DialogResult.OK)
            {
                ImageFileName = OpenFileImage.FileName;
            }

            // Filename Validation.
            if (ImageFileName.Length == 0)
            {
                return;
            }

            // Setting Up Image Properties.
            Image ImageFile = new Bitmap(ImageFileName);
            imageObject = new Bitmap(ImageFile, new Size(ImageFile.Width / 5, ImageFile.Height / 5));
        }
    }
}
