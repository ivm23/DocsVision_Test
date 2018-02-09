namespace Registrstion.WinForms
{
    partial class AddLetters
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
            this.infoLetterControl1 = new Registrstion.WinForms.Controlers.InfoLetterControl();
            this.SuspendLayout();
            // 
            // infoLetterControl1
            // 
            this.infoLetterControl1.Location = new System.Drawing.Point(-33, -9);
            this.infoLetterControl1.Name = "infoLetterControl1";
            this.infoLetterControl1.Size = new System.Drawing.Size(608, 600);
            this.infoLetterControl1.TabIndex = 0;
            // 
            // AddLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 600);
            this.Controls.Add(this.infoLetterControl1);
            this.Name = "AddLetters";
            this.Text = "AddLetters";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.InfoLetterControl infoLetterControl1;
    }
}