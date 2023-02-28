namespace AppWatch
{
    partial class MainWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelProcesses = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProcesses = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExecutable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommandLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.tableLayoutPanelProcesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHome);
            this.tabControl.Controls.Add(this.tabPageProcesses);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 461);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Location = new System.Drawing.Point(4, 24);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(876, 433);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.tableLayoutPanelProcesses);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 24);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(876, 433);
            this.tabPageProcesses.TabIndex = 1;
            this.tabPageProcesses.Text = "Processes";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelProcesses
            // 
            this.tableLayoutPanelProcesses.ColumnCount = 1;
            this.tableLayoutPanelProcesses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelProcesses.Controls.Add(this.dataGridViewProcesses, 0, 0);
            this.tableLayoutPanelProcesses.Controls.Add(this.buttonAddProcess, 0, 1);
            this.tableLayoutPanelProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcesses.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelProcesses.Name = "tableLayoutPanelProcesses";
            this.tableLayoutPanelProcesses.RowCount = 2;
            this.tableLayoutPanelProcesses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcesses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProcesses.Size = new System.Drawing.Size(870, 427);
            this.tableLayoutPanelProcesses.TabIndex = 2;
            // 
            // dataGridViewProcesses
            // 
            this.dataGridViewProcesses.AllowUserToAddRows = false;
            this.dataGridViewProcesses.AllowUserToDeleteRows = false;
            this.dataGridViewProcesses.AllowUserToResizeRows = false;
            this.dataGridViewProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colExecutable,
            this.colCommandLine,
            this.colPath,
            this.colEdit});
            this.dataGridViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcesses.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProcesses.Name = "dataGridViewProcesses";
            this.dataGridViewProcesses.ReadOnly = true;
            this.dataGridViewProcesses.RowHeadersVisible = false;
            this.dataGridViewProcesses.RowTemplate.Height = 25;
            this.dataGridViewProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcesses.Size = new System.Drawing.Size(864, 390);
            this.dataGridViewProcesses.TabIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 150;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colExecutable
            // 
            this.colExecutable.HeaderText = "Executable";
            this.colExecutable.MinimumWidth = 150;
            this.colExecutable.Name = "colExecutable";
            this.colExecutable.ReadOnly = true;
            // 
            // colCommandLine
            // 
            this.colCommandLine.HeaderText = "CommandLine";
            this.colCommandLine.MinimumWidth = 150;
            this.colCommandLine.Name = "colCommandLine";
            this.colCommandLine.ReadOnly = true;
            this.colCommandLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPath
            // 
            this.colPath.HeaderText = "Path";
            this.colPath.MinimumWidth = 150;
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "Action";
            this.colEdit.MinimumWidth = 25;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Delete";
            this.colEdit.ToolTipText = "Delete";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.AutoSize = true;
            this.buttonAddProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddProcess.Location = new System.Drawing.Point(3, 399);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(864, 25);
            this.buttonAddProcess.TabIndex = 1;
            this.buttonAddProcess.Text = "AddNewProcess";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(876, 433);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(876, 433);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "AppWatch";
            this.tabControl.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tableLayoutPanelProcesses.ResumeLayout(false);
            this.tableLayoutPanelProcesses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageHome;
        private TabPage tabPageProcesses;
        private TabPage tabPageSettings;
        private TabPage tabPageAbout;
        private DataGridView dataGridViewProcesses;
        private TableLayoutPanel tableLayoutPanelProcesses;
        private Button buttonAddProcess;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colExecutable;
        private DataGridViewTextBoxColumn colCommandLine;
        private DataGridViewTextBoxColumn colPath;
        private DataGridViewButtonColumn colEdit;
    }
}