using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class EditForm : Form
    {
        public Color Color
        {
            get
            {
                string hexText = colorLabel.Text.Substring(1);
                return Color.FromArgb(Convert.ToInt32(hexText, 16));
            }
        }

        public Figure.FigureType Type
        {
            get { return StringToFigureType(typeListBox.SelectedItem.ToString()); }
        }

        public Tuple<double, double> Coordinates
        {
            get { return ParseCoordinatesFromString(coordinatesTextBox.Text); }
        }

        public double Area
        {
            get { return double.Parse(areaTextBox.Text); }
        }

        public string Label
        {
            get { return labelTextBox.Text; }
        }

        private string pickColorMessage = "Pick a color";

        public EditForm()
        {
            InitializeComponent();
            colorLabel.Text = pickColorMessage;
        }

        public EditForm(Figure figure)
        {
            InitializeComponent();
            SetupControls(figure);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            errorProvider.SetIconAlignment(coordinatesTextBox, ErrorIconAlignment.MiddleRight);
        }

        private void SetupControls(Figure figure)
        {
            colorLabel.Text = Figure.ColorToHexString(figure.Color);
            typeListBox.SelectedIndex = GetIndexInListBox(figure.Type.ToString());
            string coordinates = figure.Coordinates.Item1 + ";" + figure.Coordinates.Item2;
            coordinatesTextBox.Text = coordinates;
            areaTextBox.Text = figure.Area.ToString();
            labelTextBox.Text = figure.Label;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateComponents())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidateComponents()
        {
            return IsColorLabelValid() && ValidateChildren();
        }

        private void colorLabel_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorLabel.Text = Figure.ColorToHexString(colorDialog.Color);
                errorProvider.SetError(colorLabel, "");
            }
        }

        private bool IsColorLabelValid()
        {
            if (colorLabel.Text == pickColorMessage)
            {
                errorProvider.SetError(colorLabel, "Please pick a color");
                return false;
            }

            return true;
        }

        private void coordinatesTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = coordinatesTextBox.Text;
            if (!areCoordinatesValid(text))
            {
                e.Cancel = true;
                errorProvider.SetError(coordinatesTextBox, 
                    @"Please follow the format: <x_coordinate>;<y_coordinate>");
            }
        }

        private bool areCoordinatesValid(string text)
        {
            try
            {
                ParseCoordinatesFromString(text);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        private Tuple<double, double> ParseCoordinatesFromString(string text)
        {
            var textCoordinates = text.Split(';');
            if (textCoordinates.Length != 2)
            {
                throw new FormatException();
            }
            return new Tuple<double, double>(Double.Parse(textCoordinates[0]), Double.Parse(textCoordinates[1]));
        }

        private void coordinatesTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(coordinatesTextBox, "");
        }

        private void areaTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double.Parse(areaTextBox.Text);
            }
            catch (FormatException)
            {
                errorProvider.SetError(areaTextBox, "Please provide a real number");
                e.Cancel = true;
            }
        }

        private void areaTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(areaTextBox, "");
        }

        private void labelTextBox_Validating(object sender, CancelEventArgs e)
        {
            Console.WriteLine(@"LabelTextBox validating");
            if (labelTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(labelTextBox, "Please provide non empty label");
            }
        }

        private void labelTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(labelTextBox, "");
        }

        private void typeListBox_Validating(object sender, CancelEventArgs e)
        {
            Console.WriteLine(@"TypeListBox validating");
            if (typeListBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(typeListBox, "Please select figureType");
            }
        }

        private void typeListBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(typeListBox, "");
        }

        private Figure.FigureType StringToFigureType(string type)
        {
            if (type == "Circle")
            {
                return Figure.FigureType.Circle;
            }
            else if (type == "Triangle")
            {
                return Figure.FigureType.Triangle;
            }
            return Figure.FigureType.Square;
        }

        private int GetIndexInListBox(string name)
        {
            for(int i = 0; i<typeListBox.Items.Count; ++i)
            {
                if (typeListBox.Items[i].ToString() == name)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
