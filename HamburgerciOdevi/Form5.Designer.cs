
namespace HamburgerciOdevi
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxTumSiparisler = new System.Windows.Forms.ListBox();
            this.grpCiro = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkstraMalzeme = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrunAdet = new System.Windows.Forms.Label();
            this.grpCiro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // lbxTumSiparisler
            // 
            this.lbxTumSiparisler.FormattingEnabled = true;
            this.lbxTumSiparisler.ItemHeight = 16;
            this.lbxTumSiparisler.Location = new System.Drawing.Point(33, 61);
            this.lbxTumSiparisler.Name = "lbxTumSiparisler";
            this.lbxTumSiparisler.Size = new System.Drawing.Size(316, 356);
            this.lbxTumSiparisler.TabIndex = 1;
            // 
            // grpCiro
            // 
            this.grpCiro.Controls.Add(this.lblCiro);
            this.grpCiro.Location = new System.Drawing.Point(373, 98);
            this.grpCiro.Name = "grpCiro";
            this.grpCiro.Size = new System.Drawing.Size(216, 65);
            this.grpCiro.TabIndex = 2;
            this.grpCiro.TabStop = false;
            this.grpCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.ForeColor = System.Drawing.Color.Red;
            this.lblCiro.Location = new System.Drawing.Point(17, 35);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(36, 17);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSiparis);
            this.groupBox2.Location = new System.Drawing.Point(373, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 65);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.ForeColor = System.Drawing.Color.Red;
            this.lblToplamSiparis.Location = new System.Drawing.Point(17, 34);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(49, 17);
            this.lblToplamSiparis.TabIndex = 1;
            this.lblToplamSiparis.Text = "0 Adet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkstraMalzeme);
            this.groupBox3.Location = new System.Drawing.Point(373, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstra Malzeme";
            // 
            // lblEkstraMalzeme
            // 
            this.lblEkstraMalzeme.AutoSize = true;
            this.lblEkstraMalzeme.ForeColor = System.Drawing.Color.Red;
            this.lblEkstraMalzeme.Location = new System.Drawing.Point(17, 33);
            this.lblEkstraMalzeme.Name = "lblEkstraMalzeme";
            this.lblEkstraMalzeme.Size = new System.Drawing.Size(36, 17);
            this.lblEkstraMalzeme.TabIndex = 1;
            this.lblEkstraMalzeme.Text = "0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatilanUrunAdet);
            this.groupBox4.Location = new System.Drawing.Point(373, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 65);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdet
            // 
            this.lblSatilanUrunAdet.AutoSize = true;
            this.lblSatilanUrunAdet.ForeColor = System.Drawing.Color.Red;
            this.lblSatilanUrunAdet.Location = new System.Drawing.Point(17, 35);
            this.lblSatilanUrunAdet.Name = "lblSatilanUrunAdet";
            this.lblSatilanUrunAdet.Size = new System.Drawing.Size(49, 17);
            this.lblSatilanUrunAdet.TabIndex = 1;
            this.lblSatilanUrunAdet.Text = "0 Adet";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 448);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCiro);
            this.Controls.Add(this.lbxTumSiparisler);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpCiro.ResumeLayout(false);
            this.grpCiro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTumSiparisler;
        private System.Windows.Forms.GroupBox grpCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblEkstraMalzeme;
        private System.Windows.Forms.Label lblSatilanUrunAdet;
    }
}