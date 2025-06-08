namespace lab06_part01
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculator calc = new calculator();
            int num1, num2, num3;

            bool isNum3Empty = string.IsNullOrEmpty(txtNum3.Text);
            if (int.TryParse(txtNum1.Text, out num1) && int.TryParse(txtNum2.Text, out num2))
            {
                if (isNum3Empty)
                {
                    // Use Add(int, int)
                    int result = calc.Add(num1, num2);
                    txtResult.Text = $"Sum of two numbers: {result}";
                }
                else if (int.TryParse(txtNum3.Text, out num3))
                {
                    // Use Add(int, int, int)
                    int result = calc.Add(num1, num2, num3);
                    txtResult.Text = $"Sum of three numbers: {result}";
                }
                else
                {
                    txtResult.Text = "Invalid input in third number.";
                }
            }
            else
            {
                txtResult.Text = "Invalid input in first two numbers.";
            }


        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
