namespace Registrstion.WinForms
{
    partial class ShowAllLetters
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
            this.ChangeLetter = new System.Windows.Forms.Button();
            this.DeleteLetter = new System.Windows.Forms.Button();
            this.lettersControl1 = new Registrstion.WinForms.Controlers.LettersControl();
            this.SuspendLayout();
            // 
            // ChangeLetter
            // 
            this.ChangeLetter.Location = new System.Drawing.Point(287, 295);
            this.ChangeLetter.Name = "ChangeLetter";
            this.ChangeLetter.Size = new System.Drawing.Size(80, 36);
            this.ChangeLetter.TabIndex = 1;
            this.ChangeLetter.Text = "Изменить";
            this.ChangeLetter.UseVisualStyleBackColor = true;
            this.ChangeLetter.Click += new System.EventHandler(this.ChangeLetter_Click);
            // 
            // DeleteLetter
            // 
            this.DeleteLetter.Location = new System.Drawing.Point(373, 295);
            this.DeleteLetter.Name = "DeleteLetter";
            this.DeleteLetter.Size = new System.Drawing.Size(80, 36);
            this.DeleteLetter.TabIndex = 2;
            this.DeleteLetter.Text = "Удалить";
            this.DeleteLetter.UseVisualStyleBackColor = true;
            this.DeleteLetter.Click += new System.EventHandler(this.DeleteLetter_Click);
            // 
            // lettersControl1
            // 
            this.lettersControl1.Location = new System.Drawing.Point(-3, -4);
            this.lettersControl1.Name = "lettersControl1";
            this.lettersControl1.Size = new System.Drawing.Size(542, 428);
            this.lettersControl1.TabIndex = 0;
            // 
            // ShowAllLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 412);
            this.Controls.Add(this.DeleteLetter);
            this.Controls.Add(this.ChangeLetter);
            this.Controls.Add(this.lettersControl1);
            this.Name = "ShowAllLetters";
            this.Text = "ShowAllLetters";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.LettersControl lettersControl1;
        private System.Windows.Forms.Button ChangeLetter;
        private System.Windows.Forms.Button DeleteLetter;
    }
}