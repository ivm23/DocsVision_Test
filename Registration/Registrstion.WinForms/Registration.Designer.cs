namespace Registrstion.WinForms
{
    partial class Registration
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowAllLetters = new System.Windows.Forms.Button();
            this.AddLetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowAllLetters
            // 
            this.ShowAllLetters.Location = new System.Drawing.Point(177, 164);
            this.ShowAllLetters.Name = "ShowAllLetters";
            this.ShowAllLetters.Size = new System.Drawing.Size(157, 66);
            this.ShowAllLetters.TabIndex = 0;
            this.ShowAllLetters.Text = "Показать все письма";
            this.ShowAllLetters.UseVisualStyleBackColor = true;
            this.ShowAllLetters.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddLetter
            // 
            this.AddLetter.Location = new System.Drawing.Point(177, 51);
            this.AddLetter.Name = "AddLetter";
            this.AddLetter.Size = new System.Drawing.Size(157, 66);
            this.AddLetter.TabIndex = 1;
            this.AddLetter.Text = "Добавить письмо";
            this.AddLetter.UseVisualStyleBackColor = true;
            this.AddLetter.Click += new System.EventHandler(this.AddLetter_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 274);
            this.Controls.Add(this.AddLetter);
            this.Controls.Add(this.ShowAllLetters);
            this.Name = "Registration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowAllLetters;
        private System.Windows.Forms.Button AddLetter;
    }
}

