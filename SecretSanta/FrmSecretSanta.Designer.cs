using System.Windows.Forms;

namespace SecretSanta
{
    partial class FrmSecretSanta
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
            this.lblOsobeSudjeluju = new System.Windows.Forms.Label();
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodjeli = new System.Windows.Forms.Button();
            this.lblUpute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOsobeSudjeluju
            // 
            this.lblOsobeSudjeluju.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblOsobeSudjeluju.AutoSize = true;
            this.lblOsobeSudjeluju.BackColor = System.Drawing.Color.Transparent;
            this.lblOsobeSudjeluju.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lblOsobeSudjeluju.Location = new System.Drawing.Point(20, 16);
            this.lblOsobeSudjeluju.Name = "lblOsobeSudjeluju";
            this.lblOsobeSudjeluju.Size = new System.Drawing.Size(176, 17);
            this.lblOsobeSudjeluju.TabIndex = 0;
            this.lblOsobeSudjeluju.Text = "Osobe koje sudjeluju:";
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvOsobe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOsobe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvOsobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsobe.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvOsobe.Location = new System.Drawing.Point(23, 41);
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.RowHeadersWidth = 51;
            this.dgvOsobe.RowTemplate.Height = 24;
            this.dgvOsobe.Size = new System.Drawing.Size(443, 311);
            this.dgvOsobe.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnDodaj.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodaj.Location = new System.Drawing.Point(491, 41);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(130, 55);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj novu osobu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(649, 41);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(130, 55);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši osobu";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodjeli
            // 
            this.btnDodjeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDodjeli.FlatAppearance.BorderSize = 0;
            this.btnDodjeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodjeli.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnDodjeli.ForeColor = System.Drawing.Color.White;
            this.btnDodjeli.Location = new System.Drawing.Point(559, 298);
            this.btnDodjeli.Name = "btnDodjeli";
            this.btnDodjeli.Size = new System.Drawing.Size(151, 54);
            this.btnDodjeli.TabIndex = 4;
            this.btnDodjeli.Text = "Dodijeli secret santu";
            this.btnDodjeli.UseVisualStyleBackColor = false;
            this.btnDodjeli.Click += new System.EventHandler(this.btnDodjeli_Click);
            // 
            // lblUpute
            // 
            this.lblUpute.BackColor = System.Drawing.Color.Transparent;
            this.lblUpute.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lblUpute.Location = new System.Drawing.Point(546, 137);
            this.lblUpute.Name = "lblUpute";
            this.lblUpute.Size = new System.Drawing.Size(181, 110);
            this.lblUpute.TabIndex = 5;
            this.lblUpute.Text = "Jednom kad započne odabiranje Secret Sante, nema više dodavanja i brisanja osoba!" +
    "";
            this.lblUpute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSecretSanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SecretSanta.Properties.Resources.christmas_trees_7576912_640;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUpute);
            this.Controls.Add(this.btnDodjeli);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvOsobe);
            this.Controls.Add(this.lblOsobeSudjeluju);
            this.Name = "FrmSecretSanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Santa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOsobeSudjeluju;
        private System.Windows.Forms.DataGridView dgvOsobe;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodjeli;
        private System.Windows.Forms.Label lblUpute;
    }
}

