namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindMax_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtFirst.Text);
            int b = int.Parse(txtSecond.Text);
            int c = int.Parse(txtThird.Text);
            int max = FindMax(a, b, c);

            lblResult.Text = "Maximum value is: " + max;
        }
        private int FindMax(int x, int y, int z)
        {
            int max = x;
            if (y > max) max = y;
            if (z > max) max = z;
            return max;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
