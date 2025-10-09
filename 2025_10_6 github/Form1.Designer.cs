namespace _2025_10_6_github
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.Font = new Font("Brush Script MT", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(241, 84);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(153, 55);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.HotPink;
            textBox1.Location = new Point(90, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(90, 150);
            label1.Name = "label1";
            label1.Size = new Size(416, 27);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Location = new Point(12, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 14);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkMagenta;
            panel2.Location = new Point(12, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 35);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Location = new Point(310, 258);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 35);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkMagenta;
            panel4.Location = new Point(618, 258);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 35);
            panel4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(640, 360);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
