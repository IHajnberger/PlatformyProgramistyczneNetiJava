namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtItems = new TextBox();
            txtSeed = new TextBox();
            txtCapacity = new TextBox();
            btnSolve = new Button();
            label5 = new Label();
            txtResult1 = new ListBox();
            txtResult2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ilość przedmiotów:";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Seed:";
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 124);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Rozmiar plecaka:";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 282);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Dane:";
            
            // 
            // txtItems
            // 
            txtItems.Location = new Point(30, 51);
            txtItems.Name = "txtItems";
            txtItems.Size = new Size(100, 23);
            txtItems.TabIndex = 4;
            txtItems.TextChanged += textBox1_TextChanged;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(30, 98);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(100, 23);
            txtSeed.TabIndex = 5;
            txtSeed.TextChanged += textBox2_TextChanged;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(30, 142);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 6;
            txtCapacity.TextChanged += textBox3_TextChanged;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(30, 204);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(114, 32);
            btnSolve.TabIndex = 8;
            btnSolve.Text = "Run";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 42);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Wynik:";
            
            // 
            // txtResult1
            // 
            txtResult1.FormattingEnabled = true;
            txtResult1.ItemHeight = 15;
            txtResult1.Location = new Point(30, 300);
            txtResult1.Name = "txtResult1";
            txtResult1.Size = new Size(286, 409);
            txtResult1.TabIndex = 11;
            txtResult1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtResult2
            // 
            txtResult2.FormattingEnabled = true;
            txtResult2.ItemHeight = 15;
            txtResult2.Location = new Point(356, 60);
            txtResult2.Name = "txtResult2";
            txtResult2.Size = new Size(411, 649);
            txtResult2.TabIndex = 12;
            txtResult2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 740);
            Controls.Add(txtResult2);
            Controls.Add(txtResult1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSolve);
            Controls.Add(txtCapacity);
            Controls.Add(txtItems);
            Controls.Add(label2);
            Controls.Add(txtSeed);
            Name = "Form1";
            Text = "Problem plecakowy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtItems;
        private TextBox txtSeed;
        private TextBox txtCapacity;
        private Button btnSolve;
        private Label label5;
        private ListBox txtResult1;
        private ListBox txtResult2;
    }
}
