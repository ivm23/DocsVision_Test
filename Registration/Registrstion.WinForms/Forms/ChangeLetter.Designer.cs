namespace Registrstion.WinForms.Forms
{
    partial class ChangeLetter
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
            this.NameLetterTB = new System.Windows.Forms.TextBox();
            this.LetterSenderCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewWorkerB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LetterTextTB = new System.Windows.Forms.TextBox();
            this.UpdateLetterB = new System.Windows.Forms.Button();
            this.changeReceiversControl1 = new Registrstion.WinForms.Controlers.ChangeReceiversControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLetterTB
            // 
            this.NameLetterTB.Location = new System.Drawing.Point(37, 43);
            this.NameLetterTB.Name = "NameLetterTB";
            this.NameLetterTB.Size = new System.Drawing.Size(100, 20);
            this.NameLetterTB.TabIndex = 1;
            // 
            // LetterSenderCB
            // 
            this.LetterSenderCB.FormattingEnabled = true;
            this.LetterSenderCB.Location = new System.Drawing.Point(35, 182);
            this.LetterSenderCB.Name = "LetterSenderCB";
            this.LetterSenderCB.Size = new System.Drawing.Size(121, 21);
            this.LetterSenderCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отправитель :";
            // 
            // AddNewWorkerB
            // 
            this.AddNewWorkerB.Location = new System.Drawing.Point(36, 88);
            this.AddNewWorkerB.Name = "AddNewWorkerB";
            this.AddNewWorkerB.Size = new System.Drawing.Size(104, 55);
            this.AddNewWorkerB.TabIndex = 5;
            this.AddNewWorkerB.Text = "Добавить нового сотрудника";
            this.AddNewWorkerB.UseVisualStyleBackColor = true;
            this.AddNewWorkerB.Click += new System.EventHandler(this.AddNewWorkerB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Содержание :";
            // 
            // LetterTextTB
            // 
            this.LetterTextTB.Location = new System.Drawing.Point(35, 494);
            this.LetterTextTB.Multiline = true;
            this.LetterTextTB.Name = "LetterTextTB";
            this.LetterTextTB.Size = new System.Drawing.Size(190, 167);
            this.LetterTextTB.TabIndex = 7;
            // 
            // UpdateLetterB
            // 
            this.UpdateLetterB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateLetterB.Location = new System.Drawing.Point(272, 646);
            this.UpdateLetterB.Name = "UpdateLetterB";
            this.UpdateLetterB.Size = new System.Drawing.Size(99, 44);
            this.UpdateLetterB.TabIndex = 8;
            this.UpdateLetterB.Text = "Обновить";
            this.UpdateLetterB.UseVisualStyleBackColor = true;
            this.UpdateLetterB.Click += new System.EventHandler(this.UpdateLetterB_Click);
            // 
            // changeReceiversControl1
            // 
            this.changeReceiversControl1.Location = new System.Drawing.Point(17, 218);
            this.changeReceiversControl1.Name = "changeReceiversControl1";
            this.changeReceiversControl1.Size = new System.Drawing.Size(573, 294);
            this.changeReceiversControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(387, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChangeLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(715, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateLetterB);
            this.Controls.Add(this.LetterTextTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddNewWorkerB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LetterSenderCB);
            this.Controls.Add(this.NameLetterTB);
            this.Controls.Add(this.changeReceiversControl1);
            this.Name = "ChangeLetter";
            this.Text = "ChangeLetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.ChangeReceiversControl changeReceiversControl1;
        private System.Windows.Forms.TextBox NameLetterTB;
        private System.Windows.Forms.ComboBox LetterSenderCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNewWorkerB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LetterTextTB;
        private System.Windows.Forms.Button UpdateLetterB;
        private System.Windows.Forms.Button button1;
    }
}