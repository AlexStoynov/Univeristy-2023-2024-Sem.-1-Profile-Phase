using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddForm : Form
    {
        Bakery addFormBakery;
        public AddForm(Bakery mainBakery)
        {
            InitializeComponent();
            this.addFormBakery = mainBakery;
            listBoxIng.Items.Clear();
            foreach (Ingredient ingredient in addFormBakery.Ingredients)
            {
                listBoxIng.Items.Add(ingredient.Name);
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addFormBakery.AddSandwich(tbxName.Text, 5, (BreadType)cbbBreadFilter.SelectedIndex );
            foreach (int item in listBoxIng.SelectedIndices)
            {
                addFormBakery.GetAvailableSandwiches()[addFormBakery.GetAvailableSandwiches().Count - 1].AddIngredient(addFormBakery.Ingredients[item]);
            }

            MessageBox.Show("Sandwich successfully added!");
        }
    }
}
