namespace WFA201015
{
    partial class FrmMain
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ujfelvetel = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_frissites = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_1.Location = new System.Drawing.Point(48, 24);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(378, 31);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Természetjárók nyilvántartása";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(54, 182);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(541, 196);
            this.dgv.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Azonosító";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vezetéknév";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Keresztnév";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Város";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefonszám";
            this.Column5.Name = "Column5";
            // 
            // btn_ujfelvetel
            // 
            this.btn_ujfelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujfelvetel.Location = new System.Drawing.Point(72, 422);
            this.btn_ujfelvetel.Name = "btn_ujfelvetel";
            this.btn_ujfelvetel.Size = new System.Drawing.Size(145, 50);
            this.btn_ujfelvetel.TabIndex = 3;
            this.btn_ujfelvetel.Text = "Új személy felvitele";
            this.btn_ujfelvetel.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(142, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(379, 25);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "A nyilvántartásban szereplő túrázók adatai";
            // 
            // btn_frissites
            // 
            this.btn_frissites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_frissites.Location = new System.Drawing.Point(458, 422);
            this.btn_frissites.Name = "btn_frissites";
            this.btn_frissites.Size = new System.Drawing.Size(137, 50);
            this.btn_frissites.TabIndex = 5;
            this.btn_frissites.Text = "Adatok frissítése";
            this.btn_frissites.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA201015.Properties.Resources.jegmadar1;
            this.pictureBox1.Location = new System.Drawing.Point(602, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 151);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_frissites);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btn_ujfelvetel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_1);
            this.Name = "FrmMain";
            this.Text = "Természetjáró nyilvántartó program";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_ujfelvetel;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn_frissites;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

