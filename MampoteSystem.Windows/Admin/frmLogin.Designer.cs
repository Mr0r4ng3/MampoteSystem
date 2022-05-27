namespace MampoteSystem.Windows.Admin
{
    partial class frmLogin
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
            this.SuspendLayout();
            // 
            // btnAccess
            // 
            this.btnAccess.FlatAppearance.BorderSize = 0;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // txPassword
            // 
            this.txPassword.VisibleIcon = true;
            this.txPassword.KeyDown += new System.EventHandler<System.Windows.Forms.KeyEventArgs>(this.txPassword_KeyDown);
            // 
            // txUsuario
            // 
            this.txUsuario.VisibleIcon = true;
            this.txUsuario.KeyDown += new System.EventHandler<System.Windows.Forms.KeyEventArgs>(this.txUsuario_KeyDown);
            // 
            // CusMessage
            // 
            this.CusMessage.Location = new System.Drawing.Point(0, 233);
            this.CusMessage.Size = new System.Drawing.Size(254, 21);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 450);
            this.LogoSize = new System.Drawing.Size(254, 159);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}