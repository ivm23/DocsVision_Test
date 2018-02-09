namespace Registrstion.WinForms.Controlers
{
    partial class NewUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameWorkerTB = new System.Windows.Forms.TextBox();
            this.LoginWorkerTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddWorkerB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить нового сотрудника :";
            // 
            // NameWorkerTB
            // 
            this.NameWorkerTB.Location = new System.Drawing.Point(118, 63);
            this.NameWorkerTB.Name = "NameWorkerTB";
            this.NameWorkerTB.Size = new System.Drawing.Size(100, 20);
            this.NameWorkerTB.TabIndex = 1;
            // 
            // LoginWorkerTB
            // 
            this.LoginWorkerTB.Location = new System.Drawing.Point(118, 108);
            this.LoginWorkerTB.Name = "LoginWorkerTB";
            this.LoginWorkerTB.Size = new System.Drawing.Size(100, 20);
            this.LoginWorkerTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя сотрудника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин сотрудника:";
            // 
            // AddWorkerB
            // 
            this.AddWorkerB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddWorkerB.Location = new System.Drawing.Point(69, 153);
            this.AddWorkerB.Name = "AddWorkerB";
            this.AddWorkerB.Size = new System.Drawing.Size(75, 40);
            this.AddWorkerB.TabIndex = 5;
            this.AddWorkerB.Text = "Добавить";
            this.AddWorkerB.UseVisualStyleBackColor = true;
            this.AddWorkerB.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelB
            // 
            this.CancelB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelB.Location = new System.Drawing.Point(162, 153);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 40);
            this.CancelB.TabIndex = 6;
            this.CancelB.Text = "Отмена";
            this.CancelB.UseVisualStyleBackColor = true;
            // 
            // NewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.AddWorkerB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginWorkerTB);
            this.Controls.Add(this.NameWorkerTB);
            this.Controls.Add(this.label1);
            this.Name = "NewUserControl";
            this.Size = new System.Drawing.Size(259, 221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameWorkerTB;
        private System.Windows.Forms.TextBox LoginWorkerTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddWorkerB;
        private System.Windows.Forms.Button CancelB;
    }
}
