namespace project01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.multiplicand = new System.Windows.Forms.TextBox();
            this.multiplier = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplicand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Multiplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // multiplicand
            // 
            this.multiplicand.Location = new System.Drawing.Point(198, 68);
            this.multiplicand.Name = "multiplicand";
            this.multiplicand.Size = new System.Drawing.Size(100, 22);
            this.multiplicand.TabIndex = 3;
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(557, 68);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(100, 22);
            this.multiplier.TabIndex = 4;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(385, 297);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 22);
            this.Result.TabIndex = 5;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(198, 170);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 6;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(557, 170);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.multiplicand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox multiplicand;
        private System.Windows.Forms.TextBox multiplier;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Exit;
    }
}

