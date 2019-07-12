namespace GUIProject
{
    partial class AdminMenu
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
            this.AdminFormTable = new System.Windows.Forms.TabControl();
            this.LibraryPage = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RemoveBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.LibraryTable = new System.Windows.Forms.DataGridView();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.AdminFormTable.SuspendLayout();
            this.LibraryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryTable)).BeginInit();
            this.UsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminFormTable
            // 
            this.AdminFormTable.Controls.Add(this.LibraryPage);
            this.AdminFormTable.Controls.Add(this.UsersPage);
            this.AdminFormTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminFormTable.Location = new System.Drawing.Point(12, 12);
            this.AdminFormTable.Name = "AdminFormTable";
            this.AdminFormTable.SelectedIndex = 0;
            this.AdminFormTable.Size = new System.Drawing.Size(1000, 537);
            this.AdminFormTable.TabIndex = 0;
            // 
            // LibraryPage
            // 
            this.LibraryPage.Controls.Add(this.RefreshButton);
            this.LibraryPage.Controls.Add(this.RemoveBookButton);
            this.LibraryPage.Controls.Add(this.AddBookButton);
            this.LibraryPage.Controls.Add(this.LibraryTable);
            this.LibraryPage.Location = new System.Drawing.Point(4, 27);
            this.LibraryPage.Name = "LibraryPage";
            this.LibraryPage.Padding = new System.Windows.Forms.Padding(3);
            this.LibraryPage.Size = new System.Drawing.Size(992, 506);
            this.LibraryPage.TabIndex = 0;
            this.LibraryPage.Text = "Library";
            this.LibraryPage.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::GUIProject.Properties.Resources.refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(949, 451);
            this.RefreshButton.MaximumSize = new System.Drawing.Size(35, 35);
            this.RefreshButton.MinimumSize = new System.Drawing.Size(35, 35);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(35, 35);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RemoveBookButton
            // 
            this.RemoveBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBookButton.Location = new System.Drawing.Point(146, 427);
            this.RemoveBookButton.Name = "RemoveBookButton";
            this.RemoveBookButton.Size = new System.Drawing.Size(100, 50);
            this.RemoveBookButton.TabIndex = 2;
            this.RemoveBookButton.Text = "Remove Book";
            this.RemoveBookButton.UseVisualStyleBackColor = true;
            this.RemoveBookButton.Click += new System.EventHandler(this.RemoveBookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBookButton.Location = new System.Drawing.Point(22, 427);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(100, 50);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // LibraryTable
            // 
            this.LibraryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LibraryTable.BackgroundColor = System.Drawing.Color.White;
            this.LibraryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibraryTable.Location = new System.Drawing.Point(6, 6);
            this.LibraryTable.Name = "LibraryTable";
            this.LibraryTable.Size = new System.Drawing.Size(978, 393);
            this.LibraryTable.TabIndex = 0;
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.UsersTable);
            this.UsersPage.Location = new System.Drawing.Point(4, 27);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(992, 506);
            this.UsersPage.TabIndex = 1;
            this.UsersPage.Text = "Users";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // UsersTable
            // 
            this.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTable.BackgroundColor = System.Drawing.Color.White;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Location = new System.Drawing.Point(6, 6);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.Size = new System.Drawing.Size(978, 494);
            this.UsersTable.TabIndex = 0;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.AdminFormTable);
            this.MaximumSize = new System.Drawing.Size(1040, 600);
            this.MinimumSize = new System.Drawing.Size(1040, 600);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenu_FormClosed);
            this.AdminFormTable.ResumeLayout(false);
            this.LibraryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryTable)).EndInit();
            this.UsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminFormTable;
        private System.Windows.Forms.TabPage LibraryPage;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.DataGridView LibraryTable;
        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.Button RemoveBookButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}