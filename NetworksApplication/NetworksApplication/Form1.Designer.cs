namespace NetworksApplication
{
    partial class NForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guidLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.macLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.ipVersionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.descrLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.unicastGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.multicastGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dnsGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicastGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multicastGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1269, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem.Text = "Interfaces";
            this.toolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItem_DropDownItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "GUID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Physical Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Speed :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "IP versions :";
            // 
            // guidLabel
            // 
            this.guidLabel.AutoSize = true;
            this.guidLabel.Location = new System.Drawing.Point(215, 121);
            this.guidLabel.Name = "guidLabel";
            this.guidLabel.Size = new System.Drawing.Size(50, 20);
            this.guidLabel.TabIndex = 7;
            this.guidLabel.Text = "label7";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(215, 158);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(50, 20);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "label7";
            // 
            // macLabel
            // 
            this.macLabel.AutoSize = true;
            this.macLabel.Location = new System.Drawing.Point(215, 197);
            this.macLabel.Name = "macLabel";
            this.macLabel.Size = new System.Drawing.Size(50, 20);
            this.macLabel.TabIndex = 9;
            this.macLabel.Text = "label7";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(215, 234);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 20);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "label7";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(215, 274);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(50, 20);
            this.speedLabel.TabIndex = 11;
            this.speedLabel.Text = "label7";
            // 
            // ipVersionLabel
            // 
            this.ipVersionLabel.AutoSize = true;
            this.ipVersionLabel.Location = new System.Drawing.Point(215, 312);
            this.ipVersionLabel.Name = "ipVersionLabel";
            this.ipVersionLabel.Size = new System.Drawing.Size(50, 20);
            this.ipVersionLabel.TabIndex = 12;
            this.ipVersionLabel.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description :";
            // 
            // descrLabel
            // 
            this.descrLabel.AutoSize = true;
            this.descrLabel.Location = new System.Drawing.Point(215, 85);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(50, 20);
            this.descrLabel.TabIndex = 14;
            this.descrLabel.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(215, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "label9";
            // 
            // unicastGridView
            // 
            this.unicastGridView.AllowUserToAddRows = false;
            this.unicastGridView.AllowUserToDeleteRows = false;
            this.unicastGridView.AllowUserToResizeColumns = false;
            this.unicastGridView.AllowUserToResizeRows = false;
            this.unicastGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unicastGridView.Location = new System.Drawing.Point(635, 85);
            this.unicastGridView.MultiSelect = false;
            this.unicastGridView.Name = "unicastGridView";
            this.unicastGridView.ReadOnly = true;
            this.unicastGridView.RowHeadersVisible = false;
            this.unicastGridView.RowHeadersWidth = 51;
            this.unicastGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.unicastGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unicastGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unicastGridView.Size = new System.Drawing.Size(599, 89);
            this.unicastGridView.TabIndex = 17;
            this.unicastGridView.Text = "dataGridView1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Unicasts :";
            // 
            // multicastGridView
            // 
            this.multicastGridView.AllowUserToAddRows = false;
            this.multicastGridView.AllowUserToDeleteRows = false;
            this.multicastGridView.AllowUserToResizeColumns = false;
            this.multicastGridView.AllowUserToResizeRows = false;
            this.multicastGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multicastGridView.Location = new System.Drawing.Point(635, 234);
            this.multicastGridView.MultiSelect = false;
            this.multicastGridView.Name = "multicastGridView";
            this.multicastGridView.ReadOnly = true;
            this.multicastGridView.RowHeadersVisible = false;
            this.multicastGridView.RowHeadersWidth = 51;
            this.multicastGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.multicastGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.multicastGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.multicastGridView.Size = new System.Drawing.Size(157, 117);
            this.multicastGridView.TabIndex = 17;
            this.multicastGridView.Text = "dataGridView1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Multicasts :";
            // 
            // dnsGridView
            // 
            this.dnsGridView.AllowUserToAddRows = false;
            this.dnsGridView.AllowUserToDeleteRows = false;
            this.dnsGridView.AllowUserToResizeColumns = false;
            this.dnsGridView.AllowUserToResizeRows = false;
            this.dnsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnsGridView.Location = new System.Drawing.Point(944, 234);
            this.dnsGridView.MultiSelect = false;
            this.dnsGridView.Name = "dnsGridView";
            this.dnsGridView.ReadOnly = true;
            this.dnsGridView.RowHeadersVisible = false;
            this.dnsGridView.RowHeadersWidth = 51;
            this.dnsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dnsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dnsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dnsGridView.Size = new System.Drawing.Size(157, 117);
            this.dnsGridView.TabIndex = 17;
            this.dnsGridView.Text = "dataGridView1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(929, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "DNS Servers :";
            // 
            // NForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 409);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dnsGridView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.multicastGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.unicastGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descrLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ipVersionLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.macLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.guidLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "NForm";
            this.Text = "Network Interfaces";
            this.Load += new System.EventHandler(this.NForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicastGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multicastGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label guidLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label macLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label ipVersionLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView unicastGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView multicastGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dnsGridView;
        private System.Windows.Forms.Label label11;
    }
}

