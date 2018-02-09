namespace Registrstion.WinForms.Forms
{
    partial class NewWorker
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
            this.newUserControl1 = new Registrstion.WinForms.Controlers.NewUserControl();
            this.SuspendLayout();
            // 
            // newUserControl1
            // 
            this.newUserControl1.Location = new System.Drawing.Point(55, 26);
            this.newUserControl1.Name = "newUserControl1";
            this.newUserControl1.Size = new System.Drawing.Size(259, 221);
            this.newUserControl1.TabIndex = 0;
            // 
            // NewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 293);
            this.Controls.Add(this.newUserControl1);
            this.Name = "NewWorker";
            this.Text = "NewWorker";
            this.ResumeLayout(false);

        }

        #endregion

        private Controlers.NewUserControl newUserControl1;
    }
}