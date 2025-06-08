namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string country = txtCountry.Text;
                string gender;

                if (age < 17 && age > 70)
                {
                    throw new InvalidAgeRangeException("Sorry, You should be older than 15 and younger than 70 to register our university");
                }
                if (Female.Checked == true)
                {
                    gender = "Female";
                }
                else if (Male.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    throw new GenderException("Should Select a gender from the radio buttons");
                }
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            catch (InvalidAgeRangeException e1)
            {
                MessageBox.Show(e1.ToString(), "Can't Register!");
            }
            catch (GenderException e1)
            {
                MessageBox.Show(e1.ToString(), "Warning!");
            }
            catch (FormatException e1)
            {
                MessageBox.Show(e1.ToString(), "Enter a Numerical Value to the Age");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    public class InvalidAgeRangeException : Exception
    {
        public InvalidAgeRangeException(string message)
        : base(message)
        {
        }
    }
    public class GenderException : Exception
    {
        public GenderException(string message)
        : base(message)
        {
        }
    }
}
