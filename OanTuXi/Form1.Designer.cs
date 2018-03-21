namespace OanTuXi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChon = new System.Windows.Forms.TextBox();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnKeo = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Result";
            // 
            // txtChon
            // 
            this.txtChon.Location = new System.Drawing.Point(113, 27);
            this.txtChon.Name = "txtChon";
            this.txtChon.Size = new System.Drawing.Size(100, 20);
            this.txtChon.TabIndex = 2;
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(211, 78);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(75, 68);
            this.btnBua.TabIndex = 3;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(113, 78);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(75, 68);
            this.btnBao.TabIndex = 4;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(15, 78);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(81, 68);
            this.btnKeo.TabIndex = 5;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(113, 190);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 6;
            this.txtKQ.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.txtChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChon;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

