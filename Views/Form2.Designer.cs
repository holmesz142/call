namespace call.Views
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(12, 296);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(115, 30);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose Image";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(115, 371);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(227, 67);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(274, 300);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(150, 26);
            this.btnCamera.TabIndex = 3;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCamera;
    }
}