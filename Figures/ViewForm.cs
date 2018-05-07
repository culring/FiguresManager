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
    public partial class ViewForm : Form, ViewInterface
    {
        private string windowName = "Figures";
        private int displayedElements = 0;

        public ViewForm()
        {
            Text = windowName;
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            DisableAllFilters();
            allToolStripMenuItem.Checked = true;
            Refresh(((MainForm) MdiParent).Model);
        }
        private void ViewForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(statusStrip, ((MainForm) MdiParent).statusStrip);
        }

        private void ViewForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).statusStrip, statusStrip);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                ((MainForm) MdiParent).AddFigure(new Figure(editForm.Color, editForm.Type,
                    editForm.Coordinates, editForm.Area, editForm.Label));
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figure figure = (Figure) listView.SelectedItems[0].Tag;
            EditForm editForm = new EditForm(figure);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                figure.Color = editForm.Color;
                figure.Type = editForm.Type;
                figure.Coordinates = editForm.Coordinates;
                figure.Area = editForm.Area;
                figure.Label = editForm.Label;
            }

            ((MainForm) MdiParent).EditFigure(figure);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figure figure = (Figure) listView.SelectedItems[0].Tag;
            ((MainForm) MdiParent).RemoveFigure(figure);
        }

        private void ListViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm) MdiParent).MdiChildClosing(sender, e);
        }

        private bool CheckFilter(Figure figure)
        {
            if (allToolStripMenuItem.Checked)
            {
                return true;
            }

            if (areaBelowToolStripMenuItem.Checked)
            {
                return figure.Area < 100;
            }

            if (areaOverToolStripMenuItem.Checked)
            {
                return figure.Area >= 100;
            }

            throw new Exception("No filter checked");
        }

        public void Add(Figure figure)
        {
            if (CheckFilter(figure))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = figure;
                UpdateItem(item);
                listView.Items.Add(item);
                ++displayedElements;
                RefreshStatusLabel();
            }
        }

        public void Edit(Figure figure)
        {
            ListViewItem item = GetItemByTag(listView, figure);
            if (item == null)
            {
                Add(figure);
                return;
            }

            UpdateItem(item);
        }

        public void Remove(Figure figure)
        {
            ListViewItem item = GetItemByTag(listView, figure);
            if (item != null)
            {
                item.Remove();
                --displayedElements;
                RefreshStatusLabel();
            }
        }

        public void Refresh(List<Figure> figures)
        {
            listView.Items.Clear();
            displayedElements = 0;
            foreach (var figure in figures)
            {
                Add(figure);
            }
        }

        private static ListViewItem GetItemByTag(ListView listView, object tag)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag == tag)
                {
                    return item;
                }
            }

            return null;
        }

        private void UpdateItem(ListViewItem item)
        {
            Figure figure = (Figure) item.Tag;
            while (item.SubItems.Count < 5)
            {
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            }

            item.SubItems[0].Text = Figure.ColorToHexString(figure.Color);
            item.SubItems[1].Text = figure.Type.ToString();
            item.SubItems[2].Text = figure.Coordinates.ToString();
            item.SubItems[3].Text = figure.Area.ToString();
            item.SubItems[4].Text = figure.Label;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                removeToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
            }
            else
            {
                removeToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }
        }

        private void DisableAllFilters()
        {
            allToolStripMenuItem.Checked = false;
            areaBelowToolStripMenuItem.Checked = false;
            areaOverToolStripMenuItem.Checked = false;
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!((ToolStripMenuItem) sender).Checked)
            {
                DisableAllFilters();
                ((ToolStripMenuItem) sender).Checked = true;
                Refresh(((MainForm) MdiParent).Model);
                if (sender != allToolStripMenuItem)
                {
                    Text = windowName + @" (" + ((ToolStripMenuItem)sender).Text + @")";
                }
                else
                {
                    Text = windowName;
                }
            }
        }

        private void RefreshStatusLabel()
        {
            toolStripStatusLabel1.Text = displayedElements.ToString();
        }
    }
}