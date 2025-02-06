namespace WinFormsApp1
{
    partial class clientidpopup
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
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(14, 12);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 7;
            label3.Text = "Production_ID*";
            label3.Click += label3_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(323, 9);
            button1.Name = "button1";
            button1.Size = new Size(83, 30);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // clientidpopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 51);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Name = "clientidpopup";
            Text = "clientidpopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}