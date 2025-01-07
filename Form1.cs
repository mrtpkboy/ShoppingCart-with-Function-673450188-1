namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            // Get amount and price for Coffee
            string strCoffeePrice = tbCoffeePrice.Text;
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            int iCoffeePrice = 0;
            int iCoffeeQuantity = 0;
            try
            {
                // Convert string to int
                if (chbCoffee.Checked)
                {
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }
            }
            catch (Exception)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
            }

            // Calculate total for Coffee
            total += iCoffeePrice * iCoffeeQuantity;

            // Get amount and price for Green Tea
            string strGreenTeaPrice = tbGreenTeaPrice.Text;
            string strGreenTeaQuantity = tbGreenTeaQuantity.Text;

            int iGreenTeaPrice = 0;
            int iGreenTeaQuantity = 0;
            try
            {
                // Convert string to int
                if (chbGreenTea.Checked)
                {
                    iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                    iGreenTeaQuantity = int.Parse(strGreenTeaQuantity);
                }
            }
            catch (Exception)
            {
                iGreenTeaPrice = 0;
                iGreenTeaQuantity = 0;
            }

            // Calculate total for Green Tea
            total += iGreenTeaPrice * iGreenTeaQuantity;

            // Display total
            tbTotal.Text = total.ToString();

            // Get cash input
            double cash = 0;
            try
            {
                cash = double.Parse(tbCash.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid cash input. Please enter a valid number.");
                return;
            }

            // Calculate change
            if (cash < total)
            {
                MessageBox.Show("Insufficient cash. Please enter enough money.");
                return;
            }

            double change = cash - total;
            tbChange.Text = change.ToString();

            // Break down change into denominations
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };  
            TextBox[] denominationTextBoxes = { tb1000,tb500 ,tb100 ,tb50 ,tb20 ,tb10 ,tb5 , tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = (int)(change / denominations[i]);
                change %= denominations[i];
                denominationTextBoxes[i].Text = count.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb1000_Click(object sender, EventArgs e)
        {

        }
    }
}
