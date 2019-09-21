namespace ISO8583MsgParserGenerator
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
            this.submitbtn1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.headLengthtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitbtn1
            // 
            this.submitbtn1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.submitbtn1.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitbtn1.Location = new System.Drawing.Point(221, 403);
            this.submitbtn1.Name = "submitbtn1";
            this.submitbtn1.Size = new System.Drawing.Size(237, 53);
            this.submitbtn1.TabIndex = 0;
            this.submitbtn1.Text = "SUBMIT";
            this.submitbtn1.UseVisualStyleBackColor = false;
            this.submitbtn1.Click += new System.EventHandler(this.submitbtn1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Goldenrod;
            this.username.Font = new System.Drawing.Font("Minion Pro", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(109, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(458, 72);
            this.username.TabIndex = 1;
            this.username.Text = "ISO8583 Message";
            this.username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernametext
            // 
            this.usernametext.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.usernametext.Location = new System.Drawing.Point(109, 84);
            this.usernametext.Multiline = true;
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(458, 221);
            this.usernametext.TabIndex = 4;
            this.usernametext.TextChanged += new System.EventHandler(this.usernametext_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // headLengthtxt
            // 
            this.headLengthtxt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.headLengthtxt.Location = new System.Drawing.Point(109, 357);
            this.headLengthtxt.Multiline = true;
            this.headLengthtxt.Name = "headLengthtxt";
            this.headLengthtxt.Size = new System.Drawing.Size(458, 40);
            this.headLengthtxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Header Length";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitbtn1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(648, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headLengthtxt);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.username);
            this.Controls.Add(this.submitbtn1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "InputMsgForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbtn1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox headLengthtxt;
        private System.Windows.Forms.Label label1;
    }
}

