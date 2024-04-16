namespace DeliveryCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] zipCode = [28734, 28730, 28840, 23590, 27605, 27514, 10054, 20894, 54037, 34856];
            double [] charges = [8.5, 6.25, 5, 6.7, 8, 7.77, 3, 4.5, 2.25, 4.89];
            string input = Convert.ToString(textBox1.Text);
            bool isInt;
            int integer;
            isInt = int.TryParse(input, out integer);
            if (isInt)
            {
                int i;
                for (i = 0; i < zipCode.Length; i++)
                {
                    if (integer == zipCode[i]) break;
                }
                if (i == zipCode.Length)
                {
                    label2.Text = string.Format("This zipcode is not in our delivery area.");
                }
                else
                    label2.Text = string.Format("The charge for delivery to this zipcode is ${0}", charges[i]);
            }
            else
                label2.Text = string.Format("This is an invalid zipcode");
        }
    }
}
