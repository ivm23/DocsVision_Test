namespace Registrstion.WinForms.Controlers
{
    partial class LettersControl
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
            this.AllLetters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SortCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoLetter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AllLetters
            // 
            this.AllLetters.FormattingEnabled = true;
            this.AllLetters.HorizontalScrollbar = true;
            this.AllLetters.Location = new System.Drawing.Point(20, 104);
            this.AllLetters.Name = "AllLetters";
            this.AllLetters.Size = new System.Drawing.Size(186, 277);
            this.AllLetters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список писем :";
            // 
            // SortCB
            // 
            this.SortCB.FormattingEnabled = true;
            this.SortCB.Items.AddRange(new object[] {
            "названию",
            "дате",
            "имени отправителя"});
            this.SortCB.Location = new System.Drawing.Point(116, 32);
            this.SortCB.Name = "SortCB";
            this.SortCB.Size = new System.Drawing.Size(121, 21);
            this.SortCB.TabIndex = 2;
            this.SortCB.SelectedIndexChanged += new System.EventHandler(this.Sort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сортировать по :";
            // 
            // InfoLetter
            // 
            this.InfoLetter.Enabled = false;
            this.InfoLetter.Location = new System.Drawing.Point(256, 109);
            this.InfoLetter.Multiline = true;
            this.InfoLetter.Name = "InfoLetter";
            this.InfoLetter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoLetter.Size = new System.Drawing.Size(193, 168);
            this.InfoLetter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Письмо :";
            // 
            // LettersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoLetter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllLetters);
            this.Name = "LettersControl";
            this.Size = new System.Drawing.Size(498, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InfoLetter;
        private System.Windows.Forms.Label label3;
    }
}
