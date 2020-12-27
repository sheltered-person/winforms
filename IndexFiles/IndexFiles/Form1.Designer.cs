namespace IndexFiles
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.readTimeLabel = new System.Windows.Forms.Label();
            this.countTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.readVelLabel = new System.Windows.Forms.Label();
            this.countVelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(171, 37);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(323, 27);
            this.fileTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(524, 36);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(94, 29);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(349, 81);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(269, 29);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Index file";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultTextBox.Location = new System.Drawing.Point(116, 198);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(502, 258);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Count time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Read time";
            // 
            // readTimeLabel
            // 
            this.readTimeLabel.AutoSize = true;
            this.readTimeLabel.Location = new System.Drawing.Point(227, 128);
            this.readTimeLabel.Name = "readTimeLabel";
            this.readTimeLabel.Size = new System.Drawing.Size(40, 20);
            this.readTimeLabel.TabIndex = 11;
            this.readTimeLabel.Text = "0 ms";
            // 
            // countTimeLabel
            // 
            this.countTimeLabel.AutoSize = true;
            this.countTimeLabel.Location = new System.Drawing.Point(227, 162);
            this.countTimeLabel.Name = "countTimeLabel";
            this.countTimeLabel.Size = new System.Drawing.Size(40, 20);
            this.countTimeLabel.TabIndex = 12;
            this.countTimeLabel.Text = "0 ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Read velocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Count velocity";
            // 
            // readVelLabel
            // 
            this.readVelLabel.AutoSize = true;
            this.readVelLabel.Location = new System.Drawing.Point(470, 128);
            this.readVelLabel.Name = "readVelLabel";
            this.readVelLabel.Size = new System.Drawing.Size(92, 20);
            this.readVelLabel.TabIndex = 15;
            this.readVelLabel.Text = "0.0 part / ms";
            // 
            // countVelLabel
            // 
            this.countVelLabel.AutoSize = true;
            this.countVelLabel.Location = new System.Drawing.Point(470, 162);
            this.countVelLabel.Name = "countVelLabel";
            this.countVelLabel.Size = new System.Drawing.Size(92, 20);
            this.countVelLabel.TabIndex = 15;
            this.countVelLabel.Text = "0.0 part / ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total time";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(227, 90);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(40, 20);
            this.totalTimeLabel.TabIndex = 17;
            this.totalTimeLabel.Text = "0 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 497);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countVelLabel);
            this.Controls.Add(this.readVelLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countTimeLabel);
            this.Controls.Add(this.readTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File Indexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label readTimeLabel;
        private System.Windows.Forms.Label countTimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label readVelLabel;
        private System.Windows.Forms.Label countVelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalTimeLabel;
    }
}

