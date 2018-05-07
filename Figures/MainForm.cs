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
    public partial class MainForm : Form
    {
        public List<Figure> Model { get; }

        public MainForm()
        {
            Model = new List<Figure>();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openNewWindow(sender, e);
        }

        private void openNewWindow(object sender, EventArgs e)
        {
            System.Console.WriteLine(@"New window created");
            ViewForm newWindow = new ViewForm {MdiParent = this};
            newWindow.Show();
        }
    
        public void MdiChildClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length == 1 && e.CloseReason != CloseReason.MdiFormClosing)
            {
                e.Cancel = true;
            }
        }

        public void AddFigure(Figure figure)
        {
            Model.Add(figure);
            foreach (ViewInterface child in MdiChildren)
            {
                child.Add(figure);
            }
        }

        public void EditFigure(Figure figure)
        {
            Model.Remove(figure);
            Model.Add(figure);
            foreach (ViewInterface child in MdiChildren)
            {
                child.Edit(figure);
            }
        }

        public void RemoveFigure(Figure figure)
        {
            Model.Remove(figure);
            foreach (ViewInterface child in MdiChildren)
            {
                child.Remove(figure);
            }
        }
    }
}
