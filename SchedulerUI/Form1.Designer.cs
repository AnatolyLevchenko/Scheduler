namespace SchedulerUI
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.olvTriggers = new BrightIdeasSoftware.ObjectListView();
            this.olvTriggerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvGroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvNextFireTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 437);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 70);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 120);
            this.dataGridView1.TabIndex = 2;
            // 
            // olvTriggers
            // 
            this.olvTriggers.AllColumns.Add(this.olvTriggerName);
            this.olvTriggers.AllColumns.Add(this.olvGroup);
            this.olvTriggers.AllColumns.Add(this.olvDescription);
            this.olvTriggers.AllColumns.Add(this.olvNextFireTime);
            this.olvTriggers.CellEditUseWholeCell = false;
            this.olvTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTriggerName,
            this.olvGroup,
            this.olvDescription,
            this.olvNextFireTime});
            this.olvTriggers.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTriggers.Location = new System.Drawing.Point(12, 31);
            this.olvTriggers.Name = "olvTriggers";
            this.olvTriggers.Size = new System.Drawing.Size(728, 140);
            this.olvTriggers.TabIndex = 3;
            this.olvTriggers.UseCompatibleStateImageBehavior = false;
            this.olvTriggers.View = System.Windows.Forms.View.Details;
            // 
            // olvTriggerName
            // 
            this.olvTriggerName.AspectName = "Name";
            this.olvTriggerName.Text = "Trigger ";
            // 
            // olvGroup
            // 
            this.olvGroup.AspectName = "Group";
            this.olvGroup.Text = "Group";
            // 
            // olvDescription
            // 
            this.olvDescription.AspectName = "Description";
            this.olvDescription.Text = "Description";
            this.olvDescription.Width = 132;
            // 
            // olvNextFireTime
            // 
            this.olvNextFireTime.AspectName = "NextFireTimeUTC";
            this.olvNextFireTime.Text = "Next Fire Time";
            this.olvNextFireTime.Width = 223;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 545);
            this.Controls.Add(this.olvTriggers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvTriggers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BrightIdeasSoftware.ObjectListView olvTriggers;
        private BrightIdeasSoftware.OLVColumn olvTriggerName;
        private BrightIdeasSoftware.OLVColumn olvGroup;
        private BrightIdeasSoftware.OLVColumn olvDescription;
        private BrightIdeasSoftware.OLVColumn olvNextFireTime;
    }
}

