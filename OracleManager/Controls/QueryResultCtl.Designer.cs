﻿namespace OracleManager.Controls
{
    partial class QueryResultCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbScript = new System.Windows.Forms.RichTextBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbScript);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbSearch);
            this.splitContainer2.Panel2.Controls.Add(this.grd);
            this.splitContainer2.Size = new System.Drawing.Size(764, 556);
            this.splitContainer2.SplitterDistance = 143;
            this.splitContainer2.TabIndex = 3;
            // 
            // tbScript
            // 
            this.tbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScript.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbScript.Location = new System.Drawing.Point(0, 0);
            this.tbScript.Name = "tbScript";
            this.tbScript.Size = new System.Drawing.Size(764, 143);
            this.tbScript.TabIndex = 0;
            this.tbScript.Text = "";
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd.BackgroundColor = System.Drawing.Color.White;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 0);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.Size = new System.Drawing.Size(764, 409);
            this.grd.TabIndex = 0;
            this.grd.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grd_DataError);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(611, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(151, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Visible = false;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // QueryResultCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "QueryResultCtl";
            this.Size = new System.Drawing.Size(764, 556);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox tbScript;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
