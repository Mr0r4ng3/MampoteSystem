namespace MampoteSystem.Windows.Modulo.Menu
{
    partial class frmSetStock
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
            this.txTasa = new Autonomo.CustomControls.FlatTextBox();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(346, 175);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.txTasa);
            this.Body.Size = new System.Drawing.Size(346, 82);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 123);
            this.Footer.Size = new System.Drawing.Size(346, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(346, 41);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Title.Size = new System.Drawing.Size(305, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(91, 8);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txTasa
            // 
            this.txTasa.AlignText = System.Windows.Forms.HorizontalAlignment.Right;
            this.txTasa.BackColor = System.Drawing.Color.White;
            this.txTasa.Category = '\0';
            this.txTasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTasa.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txTasa.ColorLine = System.Drawing.Color.Gray;
            this.txTasa.ColorText = System.Drawing.SystemColors.WindowText;
            this.txTasa.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTasa.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txTasa.Error = "";
            this.txTasa.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txTasa.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txTasa.FormatLogin = false;
            this.txTasa.ImageIcon = global::MampoteSystem.Windows.Properties.Resources.Us_Dollar_Circled_26px;
            this.txTasa.Info = "";
            this.txTasa.Location = new System.Drawing.Point(101, 6);
            this.txTasa.MaterialStyle = true;
            this.txTasa.MaxLength = 32767;
            this.txTasa.MultiLineText = false;
            this.txTasa.Name = "txTasa";
            this.txTasa.PasswordChar = '\0';
            this.txTasa.Placeholder = "Cantidad";
            this.txTasa.ReadOnly = false;
            this.txTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txTasa.Size = new System.Drawing.Size(135, 62);
            this.txTasa.SizeLine = 2;
            this.txTasa.TabIndex = 11;
            this.txTasa.Text = "0";
            this.txTasa.Title = "Cantidad";
            this.txTasa.VisibleIcon = false;
            this.txTasa.VisibleTitle = true;
            this.txTasa.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txTasa_KeyPress);
            // 
            // frmSetStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 175);
            this.Name = "frmSetStock";
            this.Text = "frmSetStock";
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txTasa;
    }
}