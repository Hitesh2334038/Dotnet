namespace FileAnd_FolderApp
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
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidateEMailId = new System.Windows.Forms.Button();
            this.txtErrorMessageDisplay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(209, 28);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(175, 20);
            this.txtfilename.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter File Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmailId
            // 
            this.txtEmailId.Location = new System.Drawing.Point(209, 73);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(319, 20);
            this.txtEmailId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Email ID";
            // 
            // btnValidateEMailId
            // 
            this.btnValidateEMailId.BackColor = System.Drawing.Color.Lime;
            this.btnValidateEMailId.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateEMailId.ForeColor = System.Drawing.Color.Red;
            this.btnValidateEMailId.Location = new System.Drawing.Point(556, 73);
            this.btnValidateEMailId.Name = "btnValidateEMailId";
            this.btnValidateEMailId.Size = new System.Drawing.Size(121, 23);
            this.btnValidateEMailId.TabIndex = 5;
            this.btnValidateEMailId.Text = "Validate Email Id";
            this.btnValidateEMailId.UseVisualStyleBackColor = false;
            this.btnValidateEMailId.Click += new System.EventHandler(this.btnValidateEMailId_Click);
            // 
            // txtErrorMessageDisplay
            // 
            this.txtErrorMessageDisplay.AutoSize = true;
            this.txtErrorMessageDisplay.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorMessageDisplay.ForeColor = System.Drawing.Color.Red;
            this.txtErrorMessageDisplay.Location = new System.Drawing.Point(63, 138);
            this.txtErrorMessageDisplay.Name = "txtErrorMessageDisplay";
            this.txtErrorMessageDisplay.Size = new System.Drawing.Size(0, 19);
            this.txtErrorMessageDisplay.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(556, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Validate URL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtErrorMessageDisplay);
            this.Controls.Add(this.btnValidateEMailId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilename);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidateEMailId;
        private System.Windows.Forms.Label txtErrorMessageDisplay;
        private System.Windows.Forms.Button button2;
    }
}

