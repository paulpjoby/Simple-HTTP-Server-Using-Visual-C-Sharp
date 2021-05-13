namespace SimpleHTTPServer
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
            this.startServerBtn = new System.Windows.Forms.Button();
            this.stopServerBtn = new System.Windows.Forms.Button();
            this.serverLogsText = new System.Windows.Forms.TextBox();
            this.serverPortText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startServerBtn
            // 
            this.startServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startServerBtn.Location = new System.Drawing.Point(28, 62);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(120, 32);
            this.startServerBtn.TabIndex = 0;
            this.startServerBtn.Text = "Start Server";
            this.startServerBtn.UseVisualStyleBackColor = true;
            this.startServerBtn.Click += new System.EventHandler(this.startServerBtn_Click);
            // 
            // stopServerBtn
            // 
            this.stopServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopServerBtn.Location = new System.Drawing.Point(28, 111);
            this.stopServerBtn.Name = "stopServerBtn";
            this.stopServerBtn.Size = new System.Drawing.Size(121, 32);
            this.stopServerBtn.TabIndex = 1;
            this.stopServerBtn.Text = "Stop Server";
            this.stopServerBtn.UseVisualStyleBackColor = true;
            this.stopServerBtn.Click += new System.EventHandler(this.stopServerBtn_Click);
            // 
            // serverLogsText
            // 
            this.serverLogsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLogsText.Location = new System.Drawing.Point(217, 55);
            this.serverLogsText.Multiline = true;
            this.serverLogsText.Name = "serverLogsText";
            this.serverLogsText.ReadOnly = true;
            this.serverLogsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serverLogsText.Size = new System.Drawing.Size(817, 661);
            this.serverLogsText.TabIndex = 2;
            // 
            // serverPortText
            // 
            this.serverPortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPortText.Location = new System.Drawing.Point(28, 270);
            this.serverPortText.Name = "serverPortText";
            this.serverPortText.Size = new System.Drawing.Size(121, 27);
            this.serverPortText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Logs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 735);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverPortText);
            this.Controls.Add(this.serverLogsText);
            this.Controls.Add(this.stopServerBtn);
            this.Controls.Add(this.startServerBtn);
            this.Name = "Form1";
            this.Text = "Simple HTTP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.Button stopServerBtn;
        private System.Windows.Forms.TextBox serverLogsText;
        private System.Windows.Forms.TextBox serverPortText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

