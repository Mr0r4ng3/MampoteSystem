namespace MampoteSystem.Windows.Modulo.Menu
{
    partial class frmCategoriaMenuModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriaMenuModal));
            this.txNombre = new Autonomo.CustomControls.FlatTextBox();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(301, 197);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.txNombre);
            this.Body.Size = new System.Drawing.Size(301, 104);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 145);
            this.Footer.Size = new System.Drawing.Size(301, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(301, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(260, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txNombre
            // 
            this.txNombre.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNombre.BackColor = System.Drawing.Color.White;
            this.txNombre.Category = '\0';
            this.txNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNombre.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txNombre.ColorLine = System.Drawing.Color.Gray;
            this.txNombre.ColorText = System.Drawing.SystemColors.WindowText;
            this.txNombre.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txNombre.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txNombre.Error = "";
            this.txNombre.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txNombre.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txNombre.FormatLogin = false;
            this.txNombre.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txNombre.ImageIcon")));
            this.txNombre.Info = "";
            this.txNombre.Location = new System.Drawing.Point(11, 23);
            this.txNombre.MaterialStyle = true;
            this.txNombre.MaxLength = 50;
            this.txNombre.MultiLineText = false;
            this.txNombre.Name = "txNombre";
            this.txNombre.PasswordChar = '\0';
            this.txNombre.Placeholder = "Nombre de la Categoria";
            this.txNombre.ReadOnly = false;
            this.txNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNombre.Size = new System.Drawing.Size(278, 58);
            this.txNombre.SizeLine = 2;
            this.txNombre.TabIndex = 1;
            this.txNombre.Title = "Nombre de la Categoria";
            this.txNombre.VisibleIcon = true;
            this.txNombre.VisibleTitle = false;
            // 
            // frmCategoriaMenuModal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(301, 197);
            this.Name = "frmCategoriaMenuModal";
            this.Text = "frmCategoriaMenuModal";
            this.Load += new System.EventHandler(this.frmCategoriaMenuModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txNombre;
    }
}