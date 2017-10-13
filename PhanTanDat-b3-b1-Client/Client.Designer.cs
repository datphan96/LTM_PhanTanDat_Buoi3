namespace PhanTanDat_b3_b1_Client
{
    partial class Client
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Keo = new System.Windows.Forms.Button();
            this.btn_bua = new System.Windows.Forms.Button();
            this.btn_bao = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Selection :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Keo
            // 
            this.btn_Keo.Location = new System.Drawing.Point(9, 143);
            this.btn_Keo.Name = "btn_Keo";
            this.btn_Keo.Size = new System.Drawing.Size(106, 98);
            this.btn_Keo.TabIndex = 2;
            this.btn_Keo.Text = "Kéo";
            this.btn_Keo.UseVisualStyleBackColor = true;
            this.btn_Keo.Click += new System.EventHandler(this.btn_Keo_Click);
            // 
            // btn_bua
            // 
            this.btn_bua.Location = new System.Drawing.Point(185, 143);
            this.btn_bua.Name = "btn_bua";
            this.btn_bua.Size = new System.Drawing.Size(106, 98);
            this.btn_bua.TabIndex = 3;
            this.btn_bua.Text = "Búa";
            this.btn_bua.UseVisualStyleBackColor = true;
            this.btn_bua.Click += new System.EventHandler(this.btn_bua_Click);
            // 
            // btn_bao
            // 
            this.btn_bao.Location = new System.Drawing.Point(364, 143);
            this.btn_bao.Name = "btn_bao";
            this.btn_bao.Size = new System.Drawing.Size(106, 98);
            this.btn_bao.TabIndex = 4;
            this.btn_bao.Text = "Bao";
            this.btn_bao.UseVisualStyleBackColor = true;
            this.btn_bao.Click += new System.EventHandler(this.btn_bao_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Result :";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_bao);
            this.Controls.Add(this.btn_bua);
            this.Controls.Add(this.btn_Keo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Keo;
        private System.Windows.Forms.Button btn_bua;
        private System.Windows.Forms.Button btn_bao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

