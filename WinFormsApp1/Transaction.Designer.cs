namespace WinFormsApp1
{
    partial class Transaction
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
            label4 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button7 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(21, 120);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 67;
            label4.Text = "Transaction Type*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 66;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(228, 245);
            button3.Name = "button3";
            button3.Size = new Size(83, 33);
            button3.TabIndex = 65;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(125, 245);
            button2.Name = "button2";
            button2.Size = new Size(83, 33);
            button2.TabIndex = 64;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(21, 245);
            button1.Name = "button1";
            button1.Size = new Size(83, 33);
            button1.TabIndex = 63;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(21, 81);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 62;
            label3.Text = "ID*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(21, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 60;
            label2.Text = "Please fill the details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 59;
            label1.Text = "Transaction Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(21, 163);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 69;
            label5.Text = "Date";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 68;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(262, 12);
            button7.Name = "button7";
            button7.Size = new Size(60, 29);
            button7.TabIndex = 70;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(21, 204);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 72;
            label6.Text = "Client_ID*";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 71;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 292);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Transaction";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox3;
        private Button button7;
        private Label label6;
        private TextBox textBox4;
    }
}