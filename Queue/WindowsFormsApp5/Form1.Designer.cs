namespace WindowsFormsApp5
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
            this.SpawnQueueButton = new System.Windows.Forms.Button();
            this.SpawnQueueTextBox = new System.Windows.Forms.TextBox();
            this.QueueBox = new System.Windows.Forms.ListBox();
            this.EnqueueButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DequeueButton = new System.Windows.Forms.Button();
            this.PeekButton = new System.Windows.Forms.Button();
            this.ToArrayButton = new System.Windows.Forms.Button();
            this.IsEmptyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpawnQueueButton
            // 
            this.SpawnQueueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpawnQueueButton.Location = new System.Drawing.Point(244, 152);
            this.SpawnQueueButton.Name = "SpawnQueueButton";
            this.SpawnQueueButton.Size = new System.Drawing.Size(271, 128);
            this.SpawnQueueButton.TabIndex = 0;
            this.SpawnQueueButton.Text = "Создать очередь";
            this.SpawnQueueButton.UseVisualStyleBackColor = true;
            this.SpawnQueueButton.Click += new System.EventHandler(this.SpawnQueueButton_Click);
            // 
            // SpawnQueueTextBox
            // 
            this.SpawnQueueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpawnQueueTextBox.Location = new System.Drawing.Point(244, 107);
            this.SpawnQueueTextBox.Name = "SpawnQueueTextBox";
            this.SpawnQueueTextBox.Size = new System.Drawing.Size(271, 30);
            this.SpawnQueueTextBox.TabIndex = 1;
            this.SpawnQueueTextBox.Text = "Укажите размер очереди";
            // 
            // QueueBox
            // 
            this.QueueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QueueBox.FormattingEnabled = true;
            this.QueueBox.ItemHeight = 25;
            this.QueueBox.Location = new System.Drawing.Point(12, 12);
            this.QueueBox.Name = "QueueBox";
            this.QueueBox.Size = new System.Drawing.Size(226, 404);
            this.QueueBox.TabIndex = 2;
            // 
            // EnqueueButton
            // 
            this.EnqueueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnqueueButton.Location = new System.Drawing.Point(244, 12);
            this.EnqueueButton.Name = "EnqueueButton";
            this.EnqueueButton.Size = new System.Drawing.Size(184, 79);
            this.EnqueueButton.TabIndex = 3;
            this.EnqueueButton.Text = "Enqueue";
            this.EnqueueButton.UseVisualStyleBackColor = true;
            this.EnqueueButton.Click += new System.EventHandler(this.EnqueueButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(445, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 79);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Укажите элемент, который хотите добавить в очередь";
            // 
            // DequeueButton
            // 
            this.DequeueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DequeueButton.Location = new System.Drawing.Point(244, 107);
            this.DequeueButton.Name = "DequeueButton";
            this.DequeueButton.Size = new System.Drawing.Size(184, 79);
            this.DequeueButton.TabIndex = 5;
            this.DequeueButton.Text = "Dequeue";
            this.DequeueButton.UseVisualStyleBackColor = true;
            this.DequeueButton.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // PeekButton
            // 
            this.PeekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeekButton.Location = new System.Drawing.Point(244, 201);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(184, 79);
            this.PeekButton.TabIndex = 6;
            this.PeekButton.Text = "Peek";
            this.PeekButton.UseVisualStyleBackColor = true;
            this.PeekButton.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // ToArrayButton
            // 
            this.ToArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToArrayButton.Location = new System.Drawing.Point(244, 296);
            this.ToArrayButton.Name = "ToArrayButton";
            this.ToArrayButton.Size = new System.Drawing.Size(184, 79);
            this.ToArrayButton.TabIndex = 7;
            this.ToArrayButton.Text = "ToArray";
            this.ToArrayButton.UseVisualStyleBackColor = true;
            this.ToArrayButton.Click += new System.EventHandler(this.ToArrayButton_Click);
            // 
            // IsEmptyButton
            // 
            this.IsEmptyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsEmptyButton.Location = new System.Drawing.Point(539, 107);
            this.IsEmptyButton.Name = "IsEmptyButton";
            this.IsEmptyButton.Size = new System.Drawing.Size(184, 79);
            this.IsEmptyButton.TabIndex = 8;
            this.IsEmptyButton.Text = "IsEmpty ";
            this.IsEmptyButton.UseVisualStyleBackColor = true;
            this.IsEmptyButton.Click += new System.EventHandler(this.IsEmptyButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(539, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "true";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 120);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsEmptyButton);
            this.Controls.Add(this.ToArrayButton);
            this.Controls.Add(this.PeekButton);
            this.Controls.Add(this.DequeueButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EnqueueButton);
            this.Controls.Add(this.QueueBox);
            this.Controls.Add(this.SpawnQueueTextBox);
            this.Controls.Add(this.SpawnQueueButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnqueueButton;

        private System.Windows.Forms.Button IsEmptyButton;

        private System.Windows.Forms.Button ToArrayButton;

        private System.Windows.Forms.Button PeekButton;

        private System.Windows.Forms.Button DequeueButton;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListBox QueueBox;

        private System.Windows.Forms.Button SpawnQueueButton;
        private System.Windows.Forms.TextBox SpawnQueueTextBox;

        #endregion
    }
}