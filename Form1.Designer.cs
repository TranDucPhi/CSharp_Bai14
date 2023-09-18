namespace CSharp_Bai14
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvndtousd = new System.Windows.Forms.Button();
            this.btncndtoeur = new System.Windows.Forms.Button();
            this.btnusdtovnd = new System.Windows.Forms.Button();
            this.btneurtovnd = new System.Windows.Forms.Button();
            this.txtQuidoi = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền Qui Đổi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết Quả";
            // 
            // btnvndtousd
            // 
            this.btnvndtousd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvndtousd.Location = new System.Drawing.Point(43, 166);
            this.btnvndtousd.Name = "btnvndtousd";
            this.btnvndtousd.Size = new System.Drawing.Size(134, 43);
            this.btnvndtousd.TabIndex = 1;
            this.btnvndtousd.Text = "VND To USD";
            this.btnvndtousd.UseVisualStyleBackColor = true;
            this.btnvndtousd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncndtoeur
            // 
            this.btncndtoeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncndtoeur.Location = new System.Drawing.Point(187, 166);
            this.btncndtoeur.Name = "btncndtoeur";
            this.btncndtoeur.Size = new System.Drawing.Size(134, 43);
            this.btncndtoeur.TabIndex = 1;
            this.btncndtoeur.Text = "VND To EUR";
            this.btncndtoeur.UseVisualStyleBackColor = true;
            // 
            // btnusdtovnd
            // 
            this.btnusdtovnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusdtovnd.Location = new System.Drawing.Point(332, 166);
            this.btnusdtovnd.Name = "btnusdtovnd";
            this.btnusdtovnd.Size = new System.Drawing.Size(134, 43);
            this.btnusdtovnd.TabIndex = 1;
            this.btnusdtovnd.Text = "USD To VND";
            this.btnusdtovnd.UseVisualStyleBackColor = true;
            // 
            // btneurtovnd
            // 
            this.btneurtovnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneurtovnd.Location = new System.Drawing.Point(479, 166);
            this.btneurtovnd.Name = "btneurtovnd";
            this.btneurtovnd.Size = new System.Drawing.Size(134, 43);
            this.btneurtovnd.TabIndex = 1;
            this.btneurtovnd.Text = "EUR To VND";
            this.btneurtovnd.UseVisualStyleBackColor = true;
            // 
            // txtQuidoi
            // 
            this.txtQuidoi.Location = new System.Drawing.Point(244, 113);
            this.txtQuidoi.Name = "txtQuidoi";
            this.txtQuidoi.Size = new System.Drawing.Size(322, 20);
            this.txtQuidoi.TabIndex = 2;
            this.txtQuidoi.Leave += new System.EventHandler(this.txtQuidoi_Leave);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(244, 245);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(322, 20);
            this.txtKq.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(279, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đổi Tiền";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtQuidoi);
            this.Controls.Add(this.btneurtovnd);
            this.Controls.Add(this.btnusdtovnd);
            this.Controls.Add(this.btncndtoeur);
            this.Controls.Add(this.btnvndtousd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvndtousd;
        private System.Windows.Forms.Button btncndtoeur;
        private System.Windows.Forms.Button btnusdtovnd;
        private System.Windows.Forms.Button btneurtovnd;
        private System.Windows.Forms.TextBox txtQuidoi;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

