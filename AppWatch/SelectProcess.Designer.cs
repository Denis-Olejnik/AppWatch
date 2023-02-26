namespace AppWatch
{
    partial class SelectProcess
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
            this.tableLayoutPanelProcesses = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOSProcesses = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExecutable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSubmitSelected = new System.Windows.Forms.Button();
            this.tableLayoutPanelProcesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelProcesses
            // 
            this.tableLayoutPanelProcesses.AutoSize = true;
            this.tableLayoutPanelProcesses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelProcesses.ColumnCount = 1;
            this.tableLayoutPanelProcesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelProcesses.Controls.Add(this.dataGridViewOSProcesses, 0, 0);
            this.tableLayoutPanelProcesses.Controls.Add(this.buttonSubmitSelected, 0, 1);
            this.tableLayoutPanelProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcesses.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProcesses.Name = "tableLayoutPanelProcesses";
            this.tableLayoutPanelProcesses.RowCount = 2;
            this.tableLayoutPanelProcesses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcesses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProcesses.Size = new System.Drawing.Size(885, 369);
            this.tableLayoutPanelProcesses.TabIndex = 3;
            // 
            // dataGridViewOSProcesses
            // 
            this.dataGridViewOSProcesses.AllowUserToAddRows = false;
            this.dataGridViewOSProcesses.AllowUserToDeleteRows = false;
            this.dataGridViewOSProcesses.AllowUserToResizeRows = false;
            this.dataGridViewOSProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOSProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOSProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colExecutable});
            this.dataGridViewOSProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOSProcesses.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOSProcesses.Name = "dataGridViewOSProcesses";
            this.dataGridViewOSProcesses.ReadOnly = true;
            this.dataGridViewOSProcesses.RowHeadersVisible = false;
            this.dataGridViewOSProcesses.RowTemplate.Height = 25;
            this.dataGridViewOSProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOSProcesses.Size = new System.Drawing.Size(879, 332);
            this.dataGridViewOSProcesses.TabIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colExecutable
            // 
            this.colExecutable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExecutable.HeaderText = "Executable";
            this.colExecutable.Name = "colExecutable";
            this.colExecutable.ReadOnly = true;
            // 
            // buttonSubmitSelected
            // 
            this.buttonSubmitSelected.AutoSize = true;
            this.buttonSubmitSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubmitSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubmitSelected.Location = new System.Drawing.Point(3, 341);
            this.buttonSubmitSelected.Name = "buttonSubmitSelected";
            this.buttonSubmitSelected.Size = new System.Drawing.Size(879, 25);
            this.buttonSubmitSelected.TabIndex = 1;
            this.buttonSubmitSelected.Text = "Submit selected processes";
            this.buttonSubmitSelected.UseVisualStyleBackColor = true;
            this.buttonSubmitSelected.Click += new System.EventHandler(this.buttonSubmitSelected_Click);
            // 
            // SelectProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 369);
            this.Controls.Add(this.tableLayoutPanelProcesses);
            this.Name = "SelectProcess";
            this.Text = "SelectProcess";
            this.tableLayoutPanelProcesses.ResumeLayout(false);
            this.tableLayoutPanelProcesses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelProcesses;
        private DataGridView dataGridViewOSProcesses;
        private Button buttonSubmitSelected;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colExecutable;
    }
}