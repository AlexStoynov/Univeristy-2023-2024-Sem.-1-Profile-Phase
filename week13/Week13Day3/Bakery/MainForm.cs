using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Bakery
{
    public partial class MainForm : Form
    {
        Bakery bakery;
        Sandwich sandwichToSell;
        public MainForm()
        {
            InitializeComponent();
            lblSandwichInfo.Text = String.Empty;
            bakery = new Bakery("Fontys Bakery");
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(bakery);
            addForm.Show();
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e)
        {
            lbxMenu.Items.Clear();
            if (bakery != null)
            {
                if (cbbBreadFilter.SelectedIndex == -1)
                {
                    foreach (Sandwich sandwich in bakery.GetAvailableSandwiches())
                    {
                        lbxMenu.Items.Add(sandwich.Name);
                    }
                }
                else
                {
                    foreach (Sandwich sandwich in bakery.GetAvailableSandwiches((BreadType)cbbBreadFilter.SelectedIndex - 1))
                    {
                        lbxMenu.Items.Add(sandwich.Name);
                    }
                }
            }
            else { MessageBox.Show("Please load info or add a sandwich"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
            FileStream fs = null;
            StreamWriter streamWriter = null;
            try
            {
                fs = (FileStream)saveFileDialog1.OpenFile();
                streamWriter = new StreamWriter(fs);
                string json = JsonSerializer.Serialize(bakery);

                streamWriter.Write(json);
                streamWriter.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { fs.Close(); }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream fs = null;
            StreamReader streamReader = null;
            try
            {
                fs = (FileStream)openFileDialog1.OpenFile();
                streamReader = new StreamReader(fs);
                string json;
                json = streamReader.ReadToEnd();
                bakery = JsonSerializer.Deserialize<Bakery>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { fs.Close(); }


        }

        private void btnSell_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Full price of sandwich: {bakery.SellSandwich(sandwichToSell):f2}$");

        }

        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBreadFilter.SelectedIndex == -1)
            {
                sandwichToSell = bakery.GetAvailableSandwiches()[lbxMenu.SelectedIndex];

            }
            else
            {
                sandwichToSell = bakery.GetAvailableSandwiches((BreadType)cbbBreadFilter.SelectedIndex - 1)[lbxMenu.SelectedIndex];

            }
            lblSandwichInfo.Text = sandwichToSell.GetInfo();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total revenue: {bakery.CalculateRevenue(true):f2}$");
        }
    }
}
