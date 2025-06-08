namespace LAB06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // Clear previous content 
            try
            {
                int length = int.Parse(txtNumber.Text);
                // Get the height from the textbox 
                long[][] triangle = new long[length + 1][];
                // Declare a jagged array for Pascal's Triangle 

                // Initialize each row of the jagged array 
                for (int row = 0; row < length; row++)
                {
                    triangle[row] = new long[row + 1];
                }

                // Calculate the Pascal's triangle values 
                triangle[0][0] = 1;
                for (int row = 0; row < length - 1; row++)
                {
                    for (int col = 0; col <= row; col++)
                    {
                        triangle[row + 1][col] += triangle[row][col];
                        // Add to the left element in the next row 
                        triangle[row + 1][col + 1] += triangle[row][col];
                        // Add to the right element in the next row 
                    }
                }

                // Print the Pascal's triangle to the RichTextBox 
                for (int row = 0; row < length; row++)
                {
                    richTextBox1.Text = richTextBox1.Text + "".PadLeft((length - row) * 2);
                    // Add spacing for alignment 
                    for (int col = 0; col <= row; col++)
                    {
                        richTextBox1.Text = richTextBox1.Text + triangle[row][col] + " ";
                        // Add number and a space 
                    }
                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
                    // Move to the next line 
                }
            }
            catch (FormatException)
            // Handle cases where non-numeric input is provided 
            {
                MessageBox.Show("Please enter a number to the length");
                // Show error message 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form/application 
        }
    }
}
