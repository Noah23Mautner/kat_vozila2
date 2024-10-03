namespace kategorije_vozila
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.txtboxGodinaproizvodnje = new System.Windows.Forms.TextBox();
            this.txtboxBrojkotaca = new System.Windows.Forms.TextBox();
            this.txtboxIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtboxBrojKotača = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btn_Spremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxModel
            // 
            this.txtboxModel.Location = new System.Drawing.Point(165, 60);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(174, 26);
            this.txtboxModel.TabIndex = 0;
            this.txtboxModel.TextChanged += new System.EventHandler(this.txtboxModel_TextChanged);
            // 
            // txtboxGodinaproizvodnje
            // 
            this.txtboxGodinaproizvodnje.Location = new System.Drawing.Point(165, 124);
            this.txtboxGodinaproizvodnje.Name = "txtboxGodinaproizvodnje";
            this.txtboxGodinaproizvodnje.Size = new System.Drawing.Size(174, 26);
            this.txtboxGodinaproizvodnje.TabIndex = 1;
            // 
            // txtboxBrojkotaca
            // 
            this.txtboxBrojkotaca.Location = new System.Drawing.Point(165, 174);
            this.txtboxBrojkotaca.Name = "txtboxBrojkotaca";
            this.txtboxBrojkotaca.Size = new System.Drawing.Size(174, 26);
            this.txtboxBrojkotaca.TabIndex = 2;
            // 
            // txtboxIspis
            // 
            this.txtboxIspis.Location = new System.Drawing.Point(420, 61);
            this.txtboxIspis.Multiline = true;
            this.txtboxIspis.Name = "txtboxIspis";
            this.txtboxIspis.Size = new System.Drawing.Size(298, 139);
            this.txtboxIspis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina proizvodnje";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(60, 188);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 6;
            // 
            // txtboxBrojKotača
            // 
            this.txtboxBrojKotača.AutoSize = true;
            this.txtboxBrojKotača.Location = new System.Drawing.Point(37, 188);
            this.txtboxBrojKotača.Name = "txtboxBrojKotača";
            this.txtboxBrojKotača.Size = new System.Drawing.Size(89, 20);
            this.txtboxBrojKotača.TabIndex = 7;
            this.txtboxBrojKotača.Text = "Broj kotača";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(41, 281);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(103, 31);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(183, 281);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(96, 31);
            this.btnObradi.TabIndex = 9;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(332, 281);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(100, 31);
            this.btnIspis.TabIndex = 10;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.Location = new System.Drawing.Point(471, 281);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(110, 31);
            this.btn_Spremi.TabIndex = 11;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = true;
            this.btn_Spremi.Click += new System.EventHandler(this.btn_Spremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Spremi);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtboxBrojKotača);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxIspis);
            this.Controls.Add(this.txtboxBrojkotaca);
            this.Controls.Add(this.txtboxGodinaproizvodnje);
            this.Controls.Add(this.txtboxModel);
            this.Name = "Form1";
            this.Text = "Kategorija Vozila";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.TextBox txtboxGodinaproizvodnje;
        private System.Windows.Forms.TextBox txtboxBrojkotaca;
        private System.Windows.Forms.TextBox txtboxIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label txtboxBrojKotača;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btn_Spremi;
    }
}

