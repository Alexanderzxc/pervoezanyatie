namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.first_num = new System.Windows.Forms.Label();
            this.second_numb = new System.Windows.Forms.Label();
            this.second_num = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ans_top = new System.Windows.Forms.Label();
            this.ans_bot = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nodlabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.sokr_bot = new System.Windows.Forms.Label();
            this.sokr_top = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "15";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первое число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_num
            // 
            this.first_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_num.Location = new System.Drawing.Point(156, 43);
            this.first_num.Name = "first_num";
            this.first_num.Size = new System.Drawing.Size(100, 23);
            this.first_num.TabIndex = 3;
            // 
            // second_numb
            // 
            this.second_numb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_numb.Location = new System.Drawing.Point(477, 43);
            this.second_numb.Name = "second_numb";
            this.second_numb.Size = new System.Drawing.Size(100, 23);
            this.second_numb.TabIndex = 7;
            // 
            // second_num
            // 
            this.second_num.Location = new System.Drawing.Point(318, 43);
            this.second_num.Name = "second_num";
            this.second_num.Size = new System.Drawing.Size(87, 23);
            this.second_num.TabIndex = 6;
            this.second_num.Text = "Второе число";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(411, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(411, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "13";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Посчитать числа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 57);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сложить числа\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ответ:";
            // 
            // ans_top
            // 
            this.ans_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans_top.Location = new System.Drawing.Point(137, 313);
            this.ans_top.Name = "ans_top";
            this.ans_top.Size = new System.Drawing.Size(100, 23);
            this.ans_top.TabIndex = 11;
            // 
            // ans_bot
            // 
            this.ans_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans_bot.Location = new System.Drawing.Point(137, 350);
            this.ans_bot.Name = "ans_bot";
            this.ans_bot.Size = new System.Drawing.Size(100, 23);
            this.ans_bot.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 57);
            this.button3.TabIndex = 13;
            this.button3.Text = "Вычесть чилса";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 57);
            this.button4.TabIndex = 14;
            this.button4.Text = "Умножить числа";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 57);
            this.button5.TabIndex = 15;
            this.button5.Text = "Разделить числа";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 59);
            this.button6.TabIndex = 16;
            this.button6.Text = "Получить НОД";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(313, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "НОД:";
            // 
            // nodlabel
            // 
            this.nodlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nodlabel.Location = new System.Drawing.Point(373, 329);
            this.nodlabel.Name = "nodlabel";
            this.nodlabel.Size = new System.Drawing.Size(100, 23);
            this.nodlabel.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(454, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 60);
            this.button7.TabIndex = 19;
            this.button7.Text = "Сократить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // sokr_bot
            // 
            this.sokr_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sokr_bot.Location = new System.Drawing.Point(558, 350);
            this.sokr_bot.Name = "sokr_bot";
            this.sokr_bot.Size = new System.Drawing.Size(100, 23);
            this.sokr_bot.TabIndex = 21;
            // 
            // sokr_top
            // 
            this.sokr_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sokr_top.Location = new System.Drawing.Point(558, 313);
            this.sokr_top.Name = "sokr_top";
            this.sokr_top.Size = new System.Drawing.Size(100, 23);
            this.sokr_top.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sokr_bot);
            this.Controls.Add(this.sokr_top);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.nodlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ans_bot);
            this.Controls.Add(this.ans_top);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.second_numb);
            this.Controls.Add(this.second_num);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.first_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label sokr_bot;
        private System.Windows.Forms.Label sokr_top;

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nodlabel;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ans_top;
        private System.Windows.Forms.Label ans_bot;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label first_num;
        private System.Windows.Forms.Label second_numb;
        private System.Windows.Forms.Label second_num;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}