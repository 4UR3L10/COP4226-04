﻿using System;
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
    public partial class MainForm : Form
    {
        public enum MirrorStyle { 
            NoMirroring,
            XAxis,
            YAxis,
            XYAxis
        }
        public MainForm()
        {
            InitializeComponent();
            signature = null;
            tileDesign.Image = new Bitmap(tileDesign.Width, tileDesign.Height);
            shapes = new List<Shape>();
            mirrorStyle = MirrorStyle.NoMirroring;
        }

       

        private void AddSignature_Click(object sender, EventArgs e)
        {
            Signature signDialog = new Signature();
            DialogResult d = signDialog.ShowDialog();
            if (d == DialogResult.OK)
                signature = (Bitmap)signDialog.pictureBox1.Image;
        }

        private void ViewSignature_Click(object sender, EventArgs e)
        {
            if (signature == null)
                return;
            Form f = new Form();
            f.Text = "Your signature";
            f.Icon = new Icon(@"C:\Users\drbor\OneDrive\Desktop\Teaching\COP4226\icons\Office_-42_icon-icons.com_74001.ico");
            f.BackgroundImage = signature;
            f.MinimumSize = signature.Size;
            f.MaximumSize = signature.Size;
            f.Show();
            
        }

        private void saveSignatureAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (signature == null)
                return;
            DialogResult d = saveAsImage.ShowDialog();
            if (d == DialogResult.OK)
                signature.Save(saveAsImage.FileName);
        }

        private void RemoveSignature_Click(object sender, EventArgs e)
        {
            if (signature == null)
                return;
            signature = null;
            MessageBox.Show("Signature deleted successfully!");
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddShapeClick(object sender, EventArgs e)
        {
            if (shapeType.SelectedIndex==0)
            {
                AddEllipse addShapeDialog = new AddEllipse();
                DialogResult d = addShapeDialog.ShowDialog();
                if (d == DialogResult.OK)
                {
                    List<int> locationAndSize = new List<int>() { addShapeDialog.returnedRectangle.X, addShapeDialog.returnedRectangle.Y, addShapeDialog.returnedRectangle.Width, addShapeDialog.returnedRectangle.Height };
                    shapes.Add(new Shape(ShapeType.Ellipse, locationAndSize, null, new Pen(addShapeDialog.drawingPenColor, addShapeDialog.drawingPenWidth)));
                }
            }
            else if (shapeType.SelectedIndex == 1)
            {
                AddRectangle addShapeDialog = new AddRectangle();
                DialogResult d = addShapeDialog.ShowDialog();
                if (d == DialogResult.OK)
                {
                    List<int> locationAndSize = new List<int>() { addShapeDialog.returnedRectangle.X, addShapeDialog.returnedRectangle.Y, addShapeDialog.returnedRectangle.Width, addShapeDialog.returnedRectangle.Height };
                    shapes.Add(new Shape(ShapeType.Rectangle, locationAndSize, null, new Pen(addShapeDialog.drawingPenColor, addShapeDialog.drawingPenWidth)));
                }
            }
            updateShapeList(shapes.Count-1);
            updateTileDesign();

        }

        private void updateTileDesign()
        {
            tileDesign.Image = new Bitmap(tileDesign.Width, tileDesign.Height);
            using (Graphics g = Graphics.FromImage(tileDesign.Image))
            {
                g.InterpolationMode = InterpolationMode.High;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (Shape s in shapes)
                    switch (s.type)
                    {
                        case ShapeType.Rectangle:
                        g.DrawRectangle(s.drawPen, new Rectangle(s.locationAndSize[0], s.locationAndSize[1], s.locationAndSize[2], s.locationAndSize[3]));
                        if(s.fillBrush != null)
                            g.FillRectangle(s.fillBrush, new Rectangle(s.locationAndSize[0], s.locationAndSize[1], s.locationAndSize[2], s.locationAndSize[3]));
                            break;
                        case ShapeType.Ellipse:
                            g.DrawEllipse(s.drawPen, new Rectangle(s.locationAndSize[0], s.locationAndSize[1], s.locationAndSize[2], s.locationAndSize[3]));
                            if (s.fillBrush != null)
                                g.FillEllipse(s.fillBrush, new Rectangle(s.locationAndSize[0], s.locationAndSize[1], s.locationAndSize[2], s.locationAndSize[3]));
                            break;
                    }
                tileDesign.Invalidate();
            }
        }

        private void ShapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = (shapeList.SelectedIndex >= 0);
            brushButtons.Enabled = (shapeList.SelectedIndex >= 0);
            up.Enabled = (shapeList.SelectedIndex > 0);
            down.Enabled = (shapeList.SelectedIndex >= 0 && shapeList.SelectedIndex < shapes.Count-1);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedIndex < 0)
                return;
            shapes.RemoveAt(shapeList.SelectedIndex);
            updateTileDesign();
            updateShapeList(-1);
            
        }

        private void updateShapeList(int nextSelectedIndex)
        {
            shapeList.Items.Clear();
            foreach (Shape s in shapes)
                shapeList.Items.Add(s);
            shapeList.SelectedIndex = nextSelectedIndex;

        }

        private void SolidBrush_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedIndex < 0)
                return;
            PickSolidBrush p = new PickSolidBrush();
            DialogResult d = p.ShowDialog();
            if (d != DialogResult.OK)
                return;
            shapes[shapeList.SelectedIndex].fillBrush = new SolidBrush(p.pickedColor);
            updateTileDesign();
            updateShapeList(shapeList.SelectedIndex);
        }

        private void preview_Click(object sender, EventArgs e)
        {
            Preview f = new Preview(tileDesign.Image, new Size((int)widthInput.Value, (int)heightInput.Value),(int)repsPerRow.Value,(int)repsPerColumn.Value,signature,mirrorStyle);
            f.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Size tileSize = new Size();
            tileSize.Width = (int)widthInput.Value / (int)repsPerRow.Value;
            tileSize.Height = (int)heightInput.Value / (int)repsPerColumn.Value;
            Bitmap tile = new Bitmap(tileDesign.Image, tileSize);
            Bitmap image = new Bitmap((int)widthInput.Value, (int)heightInput.Value);
            Graphics g = Graphics.FromImage(image);
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush b = new TextureBrush(tile);
            if (mirrorStyle == MirrorStyle.NoMirroring)
                ((TextureBrush)b).WrapMode = WrapMode.Tile;
            else if (mirrorStyle == MirrorStyle.XAxis)
                ((TextureBrush)b).WrapMode = WrapMode.TileFlipX;
            else if (mirrorStyle == MirrorStyle.YAxis)
                ((TextureBrush)b).WrapMode = WrapMode.TileFlipY;
            else if (mirrorStyle == MirrorStyle.XYAxis)
                ((TextureBrush)b).WrapMode = WrapMode.TileFlipXY;
            g.FillRectangle(b, new Rectangle(0,0, (int)widthInput.Value, (int)heightInput.Value));
            if (signature != null)
                g.DrawImage(new Bitmap(signature, 100, 50), new Point((int)widthInput.Value - 125, (int)heightInput.Value - 75));
            DialogResult d = saveAsImage.ShowDialog();
            if (d == DialogResult.OK)
                image.Save(saveAsImage.FileName);
        }

        private void Up_Click(object sender, EventArgs e)
        {
            int selected = shapeList.SelectedIndex;
            if (selected < 1)
                return;
            Shape s = shapes[selected];
            shapes.RemoveAt(selected);
            shapes.Insert(selected - 1, s);
            updateTileDesign();
            updateShapeList(selected-1);
        }

        private void Down_Click(object sender, EventArgs e)
        {
            int selected = shapeList.SelectedIndex;
            if (selected < 0 || selected == shapes.Count-1)
                return;
            Shape s = shapes[selected];
            shapes.RemoveAt(selected);
            shapes.Insert(selected + 1, s);
            updateTileDesign();
            updateShapeList(selected+1);
        }

        private void Default_Click(object sender, EventArgs e)
        {
            if (defaultMirroring.Checked == true)
                return;
            defaultMirroring.Checked = true;
            xAxisMirroring.Checked = false;
            yAxisMirroring.Checked = false;
            mirrorStyle = MirrorStyle.NoMirroring;
        }

        private void XAxis_Click(object sender, EventArgs e)
        {
            if (xAxisMirroring.Checked == true)
            {
                if (yAxisMirroring.Checked == true)
                {
                    xAxisMirroring.Checked = false;
                    mirrorStyle = MirrorStyle.YAxis;
                }
                else
                    return;
            }
            else
            {
                xAxisMirroring.Checked = true;
                defaultMirroring.Checked = false;
                mirrorStyle = yAxisMirroring.Checked? MirrorStyle.XYAxis: MirrorStyle.XAxis;
            }
        }
        private void YAxis_Click(object sender, EventArgs e)
        {
            if (yAxisMirroring.Checked == true)
            {
                if (xAxisMirroring.Checked == true)
                {
                    yAxisMirroring.Checked = false;
                    mirrorStyle = MirrorStyle.XAxis;
                }
                    
                else
                    return;
            }
            else
            {
                yAxisMirroring.Checked = true;
                defaultMirroring.Checked = false;
                mirrorStyle = xAxisMirroring.Checked ? MirrorStyle.XYAxis : MirrorStyle.YAxis;
            }
        }

        private void shapeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            addShapeButton.Enabled =shapeType.SelectedIndex>=0;
        }


        private void textureBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Dialog for “Texture Brush”: inputs WrapMode (using RadioButtons or other controls)
               and Image file name and path in the file system of hosting computer (using OpenFileDialog).
            */
            if (shapeList.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                PickTextureBrush pckTxtrBrsh = new PickTextureBrush();
                DialogResult d = pckTxtrBrsh.ShowDialog();

                if (d != DialogResult.OK)
                {
                    return;
                }
                else
                {   
                    // Variable Declaration.
                    String HatchStyle = pckTxtrBrsh.WarpModeValue;
                    TextureBrush selectedTexture = new TextureBrush(pckTxtrBrsh.imageObject);

                    // Getting the mode.
                    selectedTexture.WrapMode = WrapMode.Clamp;

                    // Set the property accordingly.
                    switch (HatchStyle)
                    {
                        case "Clamp":
                            selectedTexture = new TextureBrush(pckTxtrBrsh.imageObject, WrapMode.Clamp); ;
                            break;
                        case "Tile":
                            selectedTexture = new TextureBrush(pckTxtrBrsh.imageObject, WrapMode.Tile);
                            break;
                        case "TileFlipX":
                            selectedTexture = new TextureBrush(pckTxtrBrsh.imageObject, WrapMode.TileFlipX);
                            break;
                        case "TileFlipXY":
                            selectedTexture = new TextureBrush(pckTxtrBrsh.imageObject, WrapMode.TileFlipXY);
                            break;
                        case "TileFlipY":
                            selectedTexture = new TextureBrush(pckTxtrBrsh.imageObject, WrapMode.TileFlipY);
                            break;
                        default:
                            break;
                    }

                    // Set the Updates for the value.
                    shapes[shapeList.SelectedIndex].fillBrush = selectedTexture;
                    updateTileDesign();
                    updateShapeList(shapeList.SelectedIndex);                    
                }
            }
        }

        private void hatchBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
                Dialog for “Hatch Brush”: inputs HatchStyle(using ListBox or other controls), Fore -
                groundColor and BackgroundColor(using ColorDialog)
            */
            if (shapeList.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                PickHatchBrush pckTxtrBrsh = new PickHatchBrush();
                DialogResult d = pckTxtrBrsh.ShowDialog();

                if (d != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    Color foreColor = pckTxtrBrsh.colorBackground;
                    Color backColor = pckTxtrBrsh.colorForeground;
                    String SelectedhatchStyle = pckTxtrBrsh.StyleValue;

                    HatchStyle foundHatchStyle = HatchStyle.BackwardDiagonal;

                    switch (SelectedhatchStyle)
                    {
                        case "BackwardDiagonal":
                            foundHatchStyle = HatchStyle.BackwardDiagonal;
                            break;
                        case "Cross":
                            foundHatchStyle = HatchStyle.Cross;
                            break;
                        case "DarkDownwardDiagonal":
                            foundHatchStyle = HatchStyle.DarkDownwardDiagonal;
                            break;
                        case "DarkHorizontal":
                            foundHatchStyle = HatchStyle.DarkHorizontal;
                            break;
                        case "DarkUpwardDiagonal":
                            foundHatchStyle = HatchStyle.DarkUpwardDiagonal;
                            break;
                        case "DarkVertical":
                            foundHatchStyle = HatchStyle.DarkVertical;
                            break;
                        case "DashedDownwardDiagonal":
                            foundHatchStyle = HatchStyle.DashedDownwardDiagonal;
                            break;
                        case "DashedHorizontal":
                            foundHatchStyle = HatchStyle.DashedHorizontal;
                            break;
                        case "DashedUpwardDiagonal":
                            foundHatchStyle = HatchStyle.DashedUpwardDiagonal;
                            break;
                        case "DashedVertical":
                            foundHatchStyle = HatchStyle.DashedVertical;
                            break;
                        case "DiagonalBrick":
                            foundHatchStyle = HatchStyle.DiagonalBrick;
                            break;
                        case "DiagonalCross":
                            foundHatchStyle = HatchStyle.DiagonalCross;
                            break;
                        case "Divot":
                            foundHatchStyle = HatchStyle.Divot;
                            break;
                        case "DottedDiamond":
                            foundHatchStyle = HatchStyle.DottedDiamond;
                            break;
                        case "DottedGrid":
                            foundHatchStyle = HatchStyle.DottedGrid;
                            break;
                        case "ForwardDiagonal":
                            foundHatchStyle = HatchStyle.ForwardDiagonal;
                            break;
                        case "Horizontal":
                            foundHatchStyle = HatchStyle.Horizontal;
                            break;
                        case "HorizontalBrick":
                            foundHatchStyle = HatchStyle.HorizontalBrick;
                            break;
                        case "LargeCheckerBoard":
                            foundHatchStyle = HatchStyle.LargeCheckerBoard;
                            break;
                        case "LargeConfetti":
                            foundHatchStyle = HatchStyle.LargeConfetti;
                            break;
                        case "LargeGrid":
                            foundHatchStyle = HatchStyle.LargeGrid;
                            break;
                        case "LightDownwardDiagonal":
                            foundHatchStyle = HatchStyle.LightDownwardDiagonal;
                            break;
                        case "LightHorizontal":
                            foundHatchStyle = HatchStyle.LightHorizontal;
                            break;
                        case "LightUpwardDiagonal":
                            foundHatchStyle = HatchStyle.LightUpwardDiagonal;
                            break;
                        case "LightVertical":
                            foundHatchStyle = HatchStyle.LightVertical;
                            break;
                        case "Max":
                            foundHatchStyle = HatchStyle.Max;
                            break;
                        case "Min":
                            foundHatchStyle = HatchStyle.Min;
                            break;
                        case "NarrowHorizontal":
                            foundHatchStyle = HatchStyle.NarrowHorizontal;
                            break;
                        case "NarrowVertical":
                            foundHatchStyle = HatchStyle.NarrowVertical;
                            break;
                        case "OutlinedDiamond":
                            foundHatchStyle = HatchStyle.OutlinedDiamond;
                            break;
                        case "Percent05":
                            foundHatchStyle = HatchStyle.Percent05;
                            break;
                        case "Percent10":
                            foundHatchStyle = HatchStyle.Percent10;
                            break;
                        case "Percent20":
                            foundHatchStyle = HatchStyle.Percent20;
                            break;
                        case "Percent25":
                            foundHatchStyle = HatchStyle.Percent25;
                            break;
                        case "Percent30":
                            foundHatchStyle = HatchStyle.Percent30;
                            break;
                        case "Percent40":
                            foundHatchStyle = HatchStyle.Percent40;
                            break;
                        case "Percent50":
                            foundHatchStyle = HatchStyle.Percent50;
                            break;
                        case "Percent60":
                            foundHatchStyle = HatchStyle.Percent60;
                            break;
                        case "Percent70":
                            foundHatchStyle = HatchStyle.Percent70;
                            break;
                        case "Percent75":
                            foundHatchStyle = HatchStyle.Percent75;
                            break;
                        case "Percent80":
                            foundHatchStyle = HatchStyle.Percent80;
                            break;
                        case "Percent90":
                            foundHatchStyle = HatchStyle.Percent90;
                            break;
                        case "Plaid":
                            foundHatchStyle = HatchStyle.Plaid;
                            break;
                        case "Shingle":
                            foundHatchStyle = HatchStyle.Shingle;
                            break;
                        case "SmallCheckerBoard":
                            foundHatchStyle = HatchStyle.SmallCheckerBoard;
                            break;
                        case "SmallConfetti":
                            foundHatchStyle = HatchStyle.SmallConfetti;
                            break;
                        case "SmallGrid":
                            foundHatchStyle = HatchStyle.SmallGrid;
                            break;
                        case "SolidDiamond":
                            foundHatchStyle = HatchStyle.SolidDiamond;
                            break;
                        case "Sphere":
                            foundHatchStyle = HatchStyle.Sphere;
                            break;
                        case "Trellis":
                            foundHatchStyle = HatchStyle.Trellis;
                            break;
                        case "Vertical":
                            foundHatchStyle = HatchStyle.Vertical;
                            break;
                        case "Wave":
                            foundHatchStyle = HatchStyle.Wave;
                            break;
                        case "Weave":
                            foundHatchStyle = HatchStyle.Weave;
                            break;
                        case "WideDownwardDiagonal":
                            foundHatchStyle = HatchStyle.WideDownwardDiagonal;
                            break;
                        case "WideUpwardDiagonal":
                            foundHatchStyle = HatchStyle.WideUpwardDiagonal;
                            break;
                        case "ZigZag":
                            foundHatchStyle = HatchStyle.ZigZag;
                            break;
                        default:
                            break;
                    }

                    //HatchStyle hatchStylePicked = HatchStyle.hatchStyle;
                    shapes[shapeList.SelectedIndex].fillBrush = new HatchBrush(foundHatchStyle, foreColor, backColor);
                    updateTileDesign();
                    updateShapeList(shapeList.SelectedIndex);
                }
            }
        }

        private void linearGradientBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 
                Dialog for “Linear Gradient Brush”: inputs a Rectangle that specifies the bound of the
                linear gradient(using NumericUpDown objects or other controls), the starting color for            
                the gradient(using ColorDialog), the ending color for the gradient (using ColorDialog),
                and linear gradient mode(using RadioButtons or other controls)
            */
            if (shapeList.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                PickLinearGradientBrush pckTxtrBrsh = new PickLinearGradientBrush();
                DialogResult d = pckTxtrBrsh.ShowDialog();

                if (d != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    Color startColor = pckTxtrBrsh.colorStart;
                    Color endColor = pckTxtrBrsh.colorEnd;
                    String Style = pckTxtrBrsh.LinearModes;
                    LinearGradientMode defeaultMode = LinearGradientMode.BackwardDiagonal;
                    Rectangle rectangleShape = pckTxtrBrsh.newRectangle;

                    switch (Style)
                    {
                        case "BackwardDiagonal":
                            defeaultMode = LinearGradientMode.BackwardDiagonal;
                            break;
                        case "ForwardDiagonal":
                            defeaultMode = LinearGradientMode.ForwardDiagonal;
                            break;
                        case "Horizontal":
                            defeaultMode = LinearGradientMode.Horizontal;
                            break;
                        case "Vertical":
                            defeaultMode = LinearGradientMode.Vertical;
                            break;
                        default:
                            break;
                    }

                    shapes[shapeList.SelectedIndex].fillBrush = new LinearGradientBrush(rectangleShape, startColor, endColor, defeaultMode);
                    updateTileDesign();
                    updateShapeList(shapeList.SelectedIndex);
                }
            }
        }
    }
}
