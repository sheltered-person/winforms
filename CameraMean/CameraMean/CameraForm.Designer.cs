namespace CameraMean
{
    partial class CameraForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frameBox = new System.Windows.Forms.PictureBox();
            this.colorMeanBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMeanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            this.SuspendLayout();
            // 
            // frameBox
            // 
            this.frameBox.Location = new System.Drawing.Point(351, 250);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(640, 360);
            this.frameBox.TabIndex = 0;
            this.frameBox.TabStop = false;
            // 
            // colorMeanBox
            // 
            this.colorMeanBox.Location = new System.Drawing.Point(1086, 250);
            this.colorMeanBox.Name = "colorMeanBox";
            this.colorMeanBox.Size = new System.Drawing.Size(125, 125);
            this.colorMeanBox.TabIndex = 1;
            this.colorMeanBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1086, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1086, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1086, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue :";
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(1238, 418);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(125, 156);
            this.redBox.TabIndex = 3;
            this.redBox.TabStop = false;
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorMeanBox);
            this.Controls.Add(this.frameBox);
            this.Name = "CameraForm";
            this.Text = "ok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraForm_FormClosed);
            this.Load += new System.EventHandler(this.CameraForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CameraForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMeanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frameBox;
        private System.Windows.Forms.PictureBox colorMeanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox redBox;
    }
}

