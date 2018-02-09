namespace Registrstion.WinForms.Controlers
{
    partial class ChangeReceiversControl
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
            this.AllReceiversLB = new System.Windows.Forms.CheckedListBox();
            this.LetterReceiversLB = new System.Windows.Forms.CheckedListBox();
            this.AddReceiversB = new System.Windows.Forms.Button();
            this.DeleteReceiversB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AllReceiversLB
            // 
            this.AllReceiversLB.FormattingEnabled = true;
            this.AllReceiversLB.Location = new System.Drawing.Point(20, 39);
            this.AllReceiversLB.Name = "AllReceiversLB";
            this.AllReceiversLB.Size = new System.Drawing.Size(188, 169);
            this.AllReceiversLB.TabIndex = 0;
            // 
            // LetterReceiversLB
            // 
            this.LetterReceiversLB.FormattingEnabled = true;
            this.LetterReceiversLB.Location = new System.Drawing.Point(252, 39);
            this.LetterReceiversLB.Name = "LetterReceiversLB";
            this.LetterReceiversLB.Size = new System.Drawing.Size(188, 169);
            this.LetterReceiversLB.TabIndex = 1;
            // 
            // AddReceiversB
            // 
            this.AddReceiversB.Location = new System.Drawing.Point(137, 214);
            this.AddReceiversB.Name = "AddReceiversB";
            this.AddReceiversB.Size = new System.Drawing.Size(71, 23);
            this.AddReceiversB.TabIndex = 2;
            this.AddReceiversB.Text = "Добавить";
            this.AddReceiversB.UseVisualStyleBackColor = true;
            this.AddReceiversB.Click += new System.EventHandler(this.AddReceiversB_Click);
            // 
            // DeleteReceiversB
            // 
            this.DeleteReceiversB.Location = new System.Drawing.Point(365, 214);
            this.DeleteReceiversB.Name = "DeleteReceiversB";
            this.DeleteReceiversB.Size = new System.Drawing.Size(75, 23);
            this.DeleteReceiversB.TabIndex = 3;
            this.DeleteReceiversB.Text = "Удалить";
            this.DeleteReceiversB.UseVisualStyleBackColor = true;
            this.DeleteReceiversB.Click += new System.EventHandler(this.DeleteReceiversB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сотрудники :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Получатели :";
            // 
            // ChangeReceiversControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteReceiversB);
            this.Controls.Add(this.AddReceiversB);
            this.Controls.Add(this.LetterReceiversLB);
            this.Controls.Add(this.AllReceiversLB);
            this.Name = "ChangeReceiversControl";
            this.Size = new System.Drawing.Size(493, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AllReceiversLB;
        private System.Windows.Forms.CheckedListBox LetterReceiversLB;
        private System.Windows.Forms.Button AddReceiversB;
        private System.Windows.Forms.Button DeleteReceiversB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
