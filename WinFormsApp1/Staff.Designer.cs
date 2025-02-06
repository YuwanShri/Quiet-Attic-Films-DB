namespace WinFormsApp1
{
    partial class Staff
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            button7 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(234, 361);
            button3.Name = "button3";
            button3.Size = new Size(83, 33);
            button3.TabIndex = 40;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(131, 361);
            button2.Name = "button2";
            button2.Size = new Size(83, 33);
            button2.TabIndex = 39;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(27, 361);
            button1.Name = "button1";
            button1.Size = new Size(83, 33);
            button1.TabIndex = 38;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(18, 275);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 37;
            label6.Text = "Fee per day*";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(18, 235);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 35;
            label5.Text = "Contact No*";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(18, 130);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 33;
            label4.Text = "First Name*";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(18, 87);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 31;
            label3.Text = "ID*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 30;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(18, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 29;
            label2.Text = "Please fill the details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 33);
            label1.TabIndex = 28;
            label1.Text = "Staff";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(179, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 23);
            textBox5.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(179, 130);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 42;
            label7.Text = "Last Name*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(18, 196);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 44;
            label8.Text = "Role*";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(130, 196);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 23);
            textBox6.TabIndex = 43;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(262, 12);
            button7.Name = "button7";
            button7.Size = new Size(60, 29);
            button7.TabIndex = 45;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(18, 316);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 47;
            label9.Text = "Production ID*";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(130, 316);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 23);
            textBox7.TabIndex = 46;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 406);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(button7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Staff";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private Button button7;
        private Label label9;
        private TextBox textBox7;
    }
}