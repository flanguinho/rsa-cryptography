﻿namespace RSA_Cryptography
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
            this.labelPublicKey = new System.Windows.Forms.Label();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonGenerateKeys = new System.Windows.Forms.Button();
            this.buttonEncrypta = new System.Windows.Forms.Button();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonDecrypta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPublicKey
            // 
            this.labelPublicKey.AutoSize = true;
            this.labelPublicKey.Location = new System.Drawing.Point(12, 9);
            this.labelPublicKey.Name = "labelPublicKey";
            this.labelPublicKey.Size = new System.Drawing.Size(60, 13);
            this.labelPublicKey.TabIndex = 0;
            this.labelPublicKey.Text = "Public Key:";
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(12, 44);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(64, 13);
            this.labelPrivateKey.TabIndex = 1;
            this.labelPrivateKey.Text = "Private Key:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 92);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(31, 13);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Text:";
            // 
            // buttonGenerateKeys
            // 
            this.buttonGenerateKeys.Location = new System.Drawing.Point(450, 21);
            this.buttonGenerateKeys.Name = "buttonGenerateKeys";
            this.buttonGenerateKeys.Size = new System.Drawing.Size(135, 23);
            this.buttonGenerateKeys.TabIndex = 3;
            this.buttonGenerateKeys.Text = "Generate Keys";
            this.buttonGenerateKeys.UseVisualStyleBackColor = true;
            this.buttonGenerateKeys.Click += new System.EventHandler(this.buttonGenerateKeys_Click);
            // 
            // buttonEncrypta
            // 
            this.buttonEncrypta.Location = new System.Drawing.Point(450, 92);
            this.buttonEncrypta.Name = "buttonEncrypta";
            this.buttonEncrypta.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypta.TabIndex = 5;
            this.buttonEncrypta.Text = "Encrypta";
            this.buttonEncrypta.UseVisualStyleBackColor = true;
            this.buttonEncrypta.Click += new System.EventHandler(this.buttonEncrypta_Click);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(78, 6);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(366, 20);
            this.textBoxPublicKey.TabIndex = 6;
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(78, 41);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(366, 20);
            this.textBoxPrivateKey.TabIndex = 7;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(78, 89);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(366, 239);
            this.textBoxText.TabIndex = 8;
            // 
            // buttonDecrypta
            // 
            this.buttonDecrypta.Location = new System.Drawing.Point(450, 133);
            this.buttonDecrypta.Name = "buttonDecrypta";
            this.buttonDecrypta.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypta.TabIndex = 9;
            this.buttonDecrypta.Text = "Decrypta";
            this.buttonDecrypta.UseVisualStyleBackColor = true;
            this.buttonDecrypta.Click += new System.EventHandler(this.buttonDecrypta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 347);
            this.Controls.Add(this.buttonDecrypta);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.buttonEncrypta);
            this.Controls.Add(this.buttonGenerateKeys);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelPrivateKey);
            this.Controls.Add(this.labelPublicKey);
            this.Name = "Form1";
            this.Text = "RSA Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPublicKey;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonGenerateKeys;
        private System.Windows.Forms.Button buttonEncrypta;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button buttonDecrypta;
    }
}

