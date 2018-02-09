namespace Registrstion.WinForms.Controlers
{
    partial class InfoLetterControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLetterTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SenderCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReceiversCB = new System.Windows.Forms.ComboBox();
            this.TextLetterTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddReceiverB = new System.Windows.Forms.Button();
            this.InfoLetterTB = new System.Windows.Forms.TextBox();
            this.AddLetter = new System.Windows.Forms.Button();
            this.NewReceiverB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLetterTB
            // 
            this.NameLetterTB.Location = new System.Drawing.Point(52, 51);
            this.NameLetterTB.Name = "NameLetterTB";
            this.NameLetterTB.Size = new System.Drawing.Size(100, 20);
            this.NameLetterTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Название :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Информация о письме  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Получатели :";
            // 
            // SenderCB
            // 
            this.SenderCB.Enabled = false;
            this.SenderCB.FormattingEnabled = true;
            this.SenderCB.Location = new System.Drawing.Point(52, 100);
            this.SenderCB.Name = "SenderCB";
            this.SenderCB.Size = new System.Drawing.Size(121, 21);
            this.SenderCB.TabIndex = 6;
            this.SenderCB.SelectedIndexChanged += new System.EventHandler(this.SenderCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "2. Отправитель :";
            // 
            // ReceiversCB
            // 
            this.ReceiversCB.Enabled = false;
            this.ReceiversCB.FormattingEnabled = true;
            this.ReceiversCB.Location = new System.Drawing.Point(52, 159);
            this.ReceiversCB.Name = "ReceiversCB";
            this.ReceiversCB.Size = new System.Drawing.Size(121, 21);
            this.ReceiversCB.TabIndex = 8;
            // 
            // TextLetterTB
            // 
            this.TextLetterTB.Enabled = false;
            this.TextLetterTB.Location = new System.Drawing.Point(52, 268);
            this.TextLetterTB.Multiline = true;
            this.TextLetterTB.Name = "TextLetterTB";
            this.TextLetterTB.Size = new System.Drawing.Size(267, 180);
            this.TextLetterTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "4. Содержание  :";
            // 
            // AddReceiverB
            // 
            this.AddReceiverB.Enabled = false;
            this.AddReceiverB.Location = new System.Drawing.Point(138, 196);
            this.AddReceiverB.Name = "AddReceiverB";
            this.AddReceiverB.Size = new System.Drawing.Size(75, 35);
            this.AddReceiverB.TabIndex = 11;
            this.AddReceiverB.Text = "Добавить получателя";
            this.AddReceiverB.UseVisualStyleBackColor = true;
            this.AddReceiverB.Click += new System.EventHandler(this.AddReceiver_Click);
            // 
            // InfoLetterTB
            // 
            this.InfoLetterTB.Enabled = false;
            this.InfoLetterTB.Location = new System.Drawing.Point(339, 47);
            this.InfoLetterTB.Multiline = true;
            this.InfoLetterTB.Name = "InfoLetterTB";
            this.InfoLetterTB.Size = new System.Drawing.Size(246, 401);
            this.InfoLetterTB.TabIndex = 12;
            // 
            // AddLetter
            // 
            this.AddLetter.Enabled = false;
            this.AddLetter.Location = new System.Drawing.Point(263, 470);
            this.AddLetter.Name = "AddLetter";
            this.AddLetter.Size = new System.Drawing.Size(83, 29);
            this.AddLetter.TabIndex = 13;
            this.AddLetter.Text = "Добавить";
            this.AddLetter.UseVisualStyleBackColor = true;
            this.AddLetter.Click += new System.EventHandler(this.AddLetter_Click);
            // 
            // NewReceiverB
            // 
            this.NewReceiverB.Enabled = false;
            this.NewReceiverB.Location = new System.Drawing.Point(54, 196);
            this.NewReceiverB.Name = "NewReceiverB";
            this.NewReceiverB.Size = new System.Drawing.Size(72, 35);
            this.NewReceiverB.TabIndex = 14;
            this.NewReceiverB.Text = "Создать получателя";
            this.NewReceiverB.UseVisualStyleBackColor = true;
            this.NewReceiverB.Click += new System.EventHandler(this.NewReceiverB_Click);
            // 
            // InfoLetterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewReceiverB);
            this.Controls.Add(this.AddLetter);
            this.Controls.Add(this.InfoLetterTB);
            this.Controls.Add(this.AddReceiverB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextLetterTB);
            this.Controls.Add(this.ReceiversCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SenderCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLetterTB);
            this.Name = "InfoLetterControl";
            this.Size = new System.Drawing.Size(650, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameLetterTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SenderCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ReceiversCB;
        private System.Windows.Forms.TextBox TextLetterTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddReceiverB;
        private System.Windows.Forms.TextBox InfoLetterTB;
        private System.Windows.Forms.Button AddLetter;
        private System.Windows.Forms.Button NewReceiverB;
    }
}
