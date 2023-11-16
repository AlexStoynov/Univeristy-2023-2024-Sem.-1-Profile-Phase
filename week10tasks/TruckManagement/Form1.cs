namespace TruckManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (TypeARadio.Checked)
            {
                int boxes = int.Parse(BoxesForShipping.Text);
                int truckPalletCapacity = int.Parse(TypeAPalletsNum.Text);
                int palletBoxCapacity = int.Parse(TypeABoxesNum.Text);
                int pallets = boxes / palletBoxCapacity;
                int trucks = pallets / truckPalletCapacity;
                Calculate_Trucks(boxes, trucks, truckPalletCapacity, palletBoxCapacity);
            }
            else if (TypeBRadio.Checked) 
            {
                int boxes = int.Parse(BoxesForShipping.Text);
                int truckPalletCapacity = int.Parse(TypeBPalletsNum.Text);
                int palletBoxCapacity = int.Parse(TypeBBoxesNum.Text);
                int pallets = boxes / palletBoxCapacity;
                int trucks = pallets / truckPalletCapacity;
                Calculate_Trucks(boxes, trucks, truckPalletCapacity, palletBoxCapacity);
            }
            else if (TypeCRadio.Checked)
            {
                int boxes = int.Parse(BoxesForShipping.Text);
                int truckPalletCapacity = int.Parse(TypeCPalletsNum.Text);
                int palletBoxCapacity = int.Parse(TypeCBoxesNum.Text);
                int pallets = boxes / palletBoxCapacity;
                int trucks = pallets / truckPalletCapacity;
                Calculate_Trucks(boxes, trucks, truckPalletCapacity, palletBoxCapacity);
            }
        }

        private void Calculate_Trucks(int boxes, int trucks, int truckPalletCap, int palletBoxCap)
        {
            decimal boxCapPerTruck = truckPalletCap * palletBoxCap;
            int palletsLeft = boxes - trucks * truckPalletCap * palletBoxCap;
            if (boxes % boxCapPerTruck == 0)
            {
                result.Text = $"You will need {trucks} trucks.";
            }
            else if (palletsLeft % palletBoxCap == 0)
            {
                decimal iterations = Math.Round(boxes / boxCapPerTruck);
                int trucksCount = 0;
                for (int i = 0; i < iterations; i++)
                {
                    trucksCount++;
                }
                result.Text = $"You will need {trucksCount - 1} full trucks\n" + $"And one non-full truck with {palletsLeft / palletBoxCap} pallets.";
            }
            else
            {
                result.Text = $"You will need {trucks:1} full trucks, \n" + $"And one non-full truck with {palletsLeft / palletBoxCap} full pallets \n" + $"And one non-full pallet with {palletsLeft % palletBoxCap} boxes.";
            }
        }

        private void TypeARadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void TypeBRadio_CheckedChanged(object sender, EventArgs e)
        {;
        }

        private void TypeCRadio_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}