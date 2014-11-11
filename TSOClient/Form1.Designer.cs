namespace TSOClient
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblIpOut = new System.Windows.Forms.Label();
            this.txtIpOut = new System.Windows.Forms.TextBox();
            this.lblPortOut = new System.Windows.Forms.Label();
            this.txtPortOut = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.lblPortIn = new System.Windows.Forms.Label();
            this.txtPortIn = new System.Windows.Forms.TextBox();
            this.txtDragDrop = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.debug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtStatus);
            this.splitContainer1.Size = new System.Drawing.Size(912, 576);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.debug);
            this.splitContainer2.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer2.Panel1.Controls.Add(this.lblIpOut);
            this.splitContainer2.Panel1.Controls.Add(this.txtIpOut);
            this.splitContainer2.Panel1.Controls.Add(this.lblPortOut);
            this.splitContainer2.Panel1.Controls.Add(this.txtPortOut);
            this.splitContainer2.Panel1.Controls.Add(this.btnListen);
            this.splitContainer2.Panel1.Controls.Add(this.lblPortIn);
            this.splitContainer2.Panel1.Controls.Add(this.txtPortIn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtDragDrop);
            this.splitContainer2.Size = new System.Drawing.Size(450, 576);
            this.splitContainer2.SplitterDistance = 216;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(10, 155);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect to a server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblIpOut
            // 
            this.lblIpOut.AutoSize = true;
            this.lblIpOut.Location = new System.Drawing.Point(74, 113);
            this.lblIpOut.Name = "lblIpOut";
            this.lblIpOut.Size = new System.Drawing.Size(17, 13);
            this.lblIpOut.TabIndex = 14;
            this.lblIpOut.Text = "IP";
            // 
            // txtIpOut
            // 
            this.txtIpOut.Location = new System.Drawing.Point(77, 129);
            this.txtIpOut.Name = "txtIpOut";
            this.txtIpOut.Size = new System.Drawing.Size(181, 20);
            this.txtIpOut.TabIndex = 13;
            // 
            // lblPortOut
            // 
            this.lblPortOut.AutoSize = true;
            this.lblPortOut.Location = new System.Drawing.Point(7, 113);
            this.lblPortOut.Name = "lblPortOut";
            this.lblPortOut.Size = new System.Drawing.Size(26, 13);
            this.lblPortOut.TabIndex = 12;
            this.lblPortOut.Text = "Port";
            // 
            // txtPortOut
            // 
            this.txtPortOut.Location = new System.Drawing.Point(10, 129);
            this.txtPortOut.Name = "txtPortOut";
            this.txtPortOut.Size = new System.Drawing.Size(61, 20);
            this.txtPortOut.TabIndex = 11;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(10, 49);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(127, 22);
            this.btnListen.TabIndex = 10;
            this.btnListen.Text = "Listen for a client";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lblPortIn
            // 
            this.lblPortIn.AutoSize = true;
            this.lblPortIn.Location = new System.Drawing.Point(10, 7);
            this.lblPortIn.Name = "lblPortIn";
            this.lblPortIn.Size = new System.Drawing.Size(26, 13);
            this.lblPortIn.TabIndex = 9;
            this.lblPortIn.Text = "Port";
            // 
            // txtPortIn
            // 
            this.txtPortIn.Location = new System.Drawing.Point(10, 23);
            this.txtPortIn.Name = "txtPortIn";
            this.txtPortIn.Size = new System.Drawing.Size(61, 20);
            this.txtPortIn.TabIndex = 8;
            // 
            // txtDragDrop
            // 
            this.txtDragDrop.AllowDrop = true;
            this.txtDragDrop.Location = new System.Drawing.Point(326, 17);
            this.txtDragDrop.Multiline = true;
            this.txtDragDrop.Name = "txtDragDrop";
            this.txtDragDrop.ReadOnly = true;
            this.txtDragDrop.Size = new System.Drawing.Size(106, 97);
            this.txtDragDrop.TabIndex = 0;
            this.txtDragDrop.Text = "\r\n\r\n\r\nDrop file here";
            this.txtDragDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDragDrop_DragDrop);
            this.txtDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDragDrop_DragEnter);
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(0, 0);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(454, 572);
            this.txtStatus.TabIndex = 0;
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(327, 88);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(75, 23);
            this.debug.TabIndex = 16;
            this.debug.Text = "debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 576);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblIpOut;
        private System.Windows.Forms.TextBox txtIpOut;
        private System.Windows.Forms.Label lblPortOut;
        private System.Windows.Forms.TextBox txtPortOut;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label lblPortIn;
        private System.Windows.Forms.TextBox txtPortIn;
        private System.Windows.Forms.TextBox txtDragDrop;
        private System.Windows.Forms.Button debug;


    }
}

