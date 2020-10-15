namespace WFA201015
{
    partial class FrmUjTurazo
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
            this.tbVeznev = new System.Windows.Forms.TextBox();
            this.lblVeznev = new System.Windows.Forms.Label();
            this.btn_felvitel = new System.Windows.Forms.Button();
            this.lblKeresztnev = new System.Windows.Forms.Label();
            this.tbKeresztnev = new System.Windows.Forms.TextBox();
            this.lblVaros = new System.Windows.Forms.Label();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.lblTelszam = new System.Windows.Forms.Label();
            this.tbTelszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbVeznev
            // 
            this.tbVeznev.Location = new System.Drawing.Point(388, 74);
            this.tbVeznev.Name = "tbVeznev";
            this.tbVeznev.Size = new System.Drawing.Size(100, 20);
            this.tbVeznev.TabIndex = 0;
            // 
            // lblVeznev
            // 
            this.lblVeznev.AutoSize = true;
            this.lblVeznev.Location = new System.Drawing.Point(277, 77);
            this.lblVeznev.Name = "lblVeznev";
            this.lblVeznev.Size = new System.Drawing.Size(70, 13);
            this.lblVeznev.TabIndex = 1;
            this.lblVeznev.Text = "Vezetéknév: ";
            // 
            // btn_felvitel
            // 
            this.btn_felvitel.Location = new System.Drawing.Point(486, 322);
            this.btn_felvitel.Name = "btn_felvitel";
            this.btn_felvitel.Size = new System.Drawing.Size(154, 51);
            this.btn_felvitel.TabIndex = 2;
            this.btn_felvitel.Text = "Új túrázó rögzítése";
            this.btn_felvitel.UseVisualStyleBackColor = true;
            this.btn_felvitel.Click += new System.EventHandler(this.Btn_felvitel_Click);
            // 
            // lblKeresztnev
            // 
            this.lblKeresztnev.AutoSize = true;
            this.lblKeresztnev.Location = new System.Drawing.Point(277, 127);
            this.lblKeresztnev.Name = "lblKeresztnev";
            this.lblKeresztnev.Size = new System.Drawing.Size(63, 13);
            this.lblKeresztnev.TabIndex = 4;
            this.lblKeresztnev.Text = "Keresztnév:";
            // 
            // tbKeresztnev
            // 
            this.tbKeresztnev.Location = new System.Drawing.Point(388, 124);
            this.tbKeresztnev.Name = "tbKeresztnev";
            this.tbKeresztnev.Size = new System.Drawing.Size(100, 20);
            this.tbKeresztnev.TabIndex = 3;
            // 
            // lblVaros
            // 
            this.lblVaros.AutoSize = true;
            this.lblVaros.Location = new System.Drawing.Point(277, 173);
            this.lblVaros.Name = "lblVaros";
            this.lblVaros.Size = new System.Drawing.Size(37, 13);
            this.lblVaros.TabIndex = 6;
            this.lblVaros.Text = "Város:";
            // 
            // tbVaros
            // 
            this.tbVaros.Location = new System.Drawing.Point(388, 173);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(100, 20);
            this.tbVaros.TabIndex = 5;
            // 
            // lblTelszam
            // 
            this.lblTelszam.AutoSize = true;
            this.lblTelszam.Location = new System.Drawing.Point(277, 231);
            this.lblTelszam.Name = "lblTelszam";
            this.lblTelszam.Size = new System.Drawing.Size(70, 13);
            this.lblTelszam.TabIndex = 8;
            this.lblTelszam.Text = "Telefonszám:";
            // 
            // tbTelszam
            // 
            this.tbTelszam.Location = new System.Drawing.Point(388, 224);
            this.tbTelszam.Name = "tbTelszam";
            this.tbTelszam.Size = new System.Drawing.Size(100, 20);
            this.tbTelszam.TabIndex = 7;
            // 
            // FrmUjTurazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTelszam);
            this.Controls.Add(this.tbTelszam);
            this.Controls.Add(this.lblVaros);
            this.Controls.Add(this.tbVaros);
            this.Controls.Add(this.lblKeresztnev);
            this.Controls.Add(this.tbKeresztnev);
            this.Controls.Add(this.btn_felvitel);
            this.Controls.Add(this.lblVeznev);
            this.Controls.Add(this.tbVeznev);
            this.Name = "FrmUjTurazo";
            this.Text = "FrmUjTurazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVeznev;
        private System.Windows.Forms.Label lblVeznev;
        private System.Windows.Forms.Button btn_felvitel;
        private System.Windows.Forms.Label lblKeresztnev;
        private System.Windows.Forms.TextBox tbKeresztnev;
        private System.Windows.Forms.Label lblVaros;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label lblTelszam;
        private System.Windows.Forms.TextBox tbTelszam;
    }
}