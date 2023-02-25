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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageProcesses);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Location = new System.Drawing.Point(4, 24);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(792, 422);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.textBox1);
            this.tabPageProcesses.Controls.Add(this.dataGridView1);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 24);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(792, 422);
            this.tabPageProcesses.TabIndex = 1;
            this.tabPageProcesses.Text = "Processes";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(792, 422);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(792, 422);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(786, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search";
            this.textBox1.Size = new System.Drawing.Size(786, 23);
            this.textBox1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "AppWatch";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tabPageProcesses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageHome;
        private TabPage tabPageProcesses;
        private TabPage tabPageSettings;
        private TabPage tabPageAbout;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}