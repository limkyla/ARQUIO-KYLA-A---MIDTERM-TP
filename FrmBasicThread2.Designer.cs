namespace FrmBasicThread1
{
    partial class FrmBasicThread2
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
            this.run2 = new System.Windows.Forms.Button();
            this.endThread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // run2
            // 
            this.run2.BackColor = System.Drawing.Color.Aqua;
            this.run2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run2.Location = new System.Drawing.Point(73, 97);
            this.run2.Name = "run2";
            this.run2.Size = new System.Drawing.Size(103, 46);
            this.run2.TabIndex = 3;
            this.run2.Text = "Run";
            this.run2.UseVisualStyleBackColor = false;
            this.run2.Click += new System.EventHandler(this.run2_Click);
            // 
            // endThread
            // 
            this.endThread.AutoSize = true;
            this.endThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endThread.Location = new System.Drawing.Point(51, 52);
            this.endThread.Name = "endThread";
            this.endThread.Size = new System.Drawing.Size(158, 24);
            this.endThread.TabIndex = 2;
            this.endThread.Text = "-End of Thread-";
            // 
            // FrmBasicThread2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(264, 168);
            this.Controls.Add(this.run2);
            this.Controls.Add(this.endThread);
            this.Name = "FrmBasicThread2";
            this.Text = "FrmBasicThread2";
            this.Load += new System.EventHandler(this.FrmBasicThread2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run2;
        private System.Windows.Forms.Label endThread;
    }
}