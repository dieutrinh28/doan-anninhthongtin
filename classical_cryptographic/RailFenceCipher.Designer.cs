﻿
namespace classical_cryptographic
{
    partial class RailFenceCipher
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
            this.lbOutputEn = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txbM = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbOutputDe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOutputEn
            // 
            this.lbOutputEn.AutoSize = true;
            this.lbOutputEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutputEn.Location = new System.Drawing.Point(310, 323);
            this.lbOutputEn.Name = "lbOutputEn";
            this.lbOutputEn.Size = new System.Drawing.Size(0, 24);
            this.lbOutputEn.TabIndex = 16;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(210, 240);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 44);
            this.btnEncrypt.TabIndex = 15;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Key:";
            // 
            // txbK
            // 
            this.txbK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbK.Location = new System.Drawing.Point(314, 164);
            this.txbK.Name = "txbK";
            this.txbK.Size = new System.Drawing.Size(100, 29);
            this.txbK.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rail Fence Cipher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Encrypted Text:";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(119, 104);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(109, 24);
            this.lbl_input.TabIndex = 10;
            this.lbl_input.Text = "Plain Text:";
            // 
            // txbM
            // 
            this.txbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbM.Location = new System.Drawing.Point(314, 104);
            this.txbM.Name = "txbM";
            this.txbM.Size = new System.Drawing.Size(335, 29);
            this.txbM.TabIndex = 9;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(425, 240);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 44);
            this.btnDecrypt.TabIndex = 17;
            this.btnDecrypt.Text = "Encrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // lbOutputDe
            // 
            this.lbOutputDe.AutoSize = true;
            this.lbOutputDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutputDe.Location = new System.Drawing.Point(310, 386);
            this.lbOutputDe.Name = "lbOutputDe";
            this.lbOutputDe.Size = new System.Drawing.Size(0, 24);
            this.lbOutputDe.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Decrypted Text:";
            // 
            // RailFenceCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOutputDe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbOutputEn);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.txbM);
            this.Name = "RailFenceCipher";
            this.Text = "RailFenceCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOutputEn;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txbM;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbOutputDe;
        private System.Windows.Forms.Label label5;
    }
}