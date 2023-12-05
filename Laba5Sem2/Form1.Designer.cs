namespace Laba5Sem2
{
    partial class Вакцинация
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            button4 = new Button();
            listBox3 = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(255, 214);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Все пациенты:";
            // 
            // button1
            // 
            button1.Location = new Point(280, 35);
            button1.Name = "button1";
            button1.Size = new Size(141, 55);
            button1.TabIndex = 2;
            button1.Text = "Отправить всех на вакцинацию";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(280, 114);
            button2.Name = "button2";
            button2.Size = new Size(141, 55);
            button2.TabIndex = 3;
            button2.Text = "Отправить на первичную вакцинацию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(280, 194);
            button3.Name = "button3";
            button3.Size = new Size(141, 55);
            button3.TabIndex = 4;
            button3.Text = "Отправить на вторичную вакцинацию";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(437, 35);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(255, 184);
            listBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 17);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 6;
            label2.Text = "Пациенты на вакцинации:";
            // 
            // button4
            // 
            button4.Location = new Point(437, 225);
            button4.Name = "button4";
            button4.Size = new Size(255, 24);
            button4.TabIndex = 7;
            button4.Text = "Провести вакцинацию";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(711, 35);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(255, 214);
            listBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(711, 17);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 9;
            label3.Text = "Пациенты с сертификатами:";
            // 
            // Вакцинация
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 315);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Вакцинация";
            Text = "Вакцинация";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private Label label2;
        private Button button4;
        private ListBox listBox3;
        private Label label3;
    }
}
