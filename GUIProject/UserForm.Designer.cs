namespace GUIProject
{
    partial class UserForm
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
            this.UserMenu = new System.Windows.Forms.TabControl();
            this.LibraryTab = new System.Windows.Forms.TabPage();
            this.Title = new System.Windows.Forms.RadioButton();
            this.AuthorRButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddToUserLibraryButton = new System.Windows.Forms.Button();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.UserLibrary = new System.Windows.Forms.TabPage();
            this.UserProfile = new System.Windows.Forms.TabPage();
            this.UserMenu.SuspendLayout();
            this.LibraryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserMenu
            // 
            this.UserMenu.Controls.Add(this.LibraryTab);
            this.UserMenu.Controls.Add(this.UserLibrary);
            this.UserMenu.Controls.Add(this.UserProfile);
            this.UserMenu.Location = new System.Drawing.Point(13, 13);
            this.UserMenu.Margin = new System.Windows.Forms.Padding(4);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.SelectedIndex = 0;
            this.UserMenu.Size = new System.Drawing.Size(996, 515);
            this.UserMenu.TabIndex = 0;
            // 
            // LibraryTab
            // 
            this.LibraryTab.Controls.Add(this.Title);
            this.LibraryTab.Controls.Add(this.AuthorRButton);
            this.LibraryTab.Controls.Add(this.SearchButton);
            this.LibraryTab.Controls.Add(this.textBox1);
            this.LibraryTab.Controls.Add(this.AddToUserLibraryButton);
            this.LibraryTab.Controls.Add(this.BooksDGV);
            this.LibraryTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibraryTab.Location = new System.Drawing.Point(4, 27);
            this.LibraryTab.Margin = new System.Windows.Forms.Padding(4);
            this.LibraryTab.Name = "LibraryTab";
            this.LibraryTab.Padding = new System.Windows.Forms.Padding(4);
            this.LibraryTab.Size = new System.Drawing.Size(988, 484);
            this.LibraryTab.TabIndex = 0;
            this.LibraryTab.Text = "Library";
            this.LibraryTab.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(477, 451);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 20);
            this.Title.TabIndex = 5;
            this.Title.TabStop = true;
            this.Title.Text = "Title";
            this.Title.UseVisualStyleBackColor = true;
            // 
            // AuthorRButton
            // 
            this.AuthorRButton.AutoSize = true;
            this.AuthorRButton.Location = new System.Drawing.Point(477, 416);
            this.AuthorRButton.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorRButton.Name = "AuthorRButton";
            this.AuthorRButton.Size = new System.Drawing.Size(64, 20);
            this.AuthorRButton.TabIndex = 4;
            this.AuthorRButton.TabStop = true;
            this.AuthorRButton.Text = "Author";
            this.AuthorRButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(269, 445);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(180, 32);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 416);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 2;
            // 
            // AddToUserLibraryButton
            // 
            this.AddToUserLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToUserLibraryButton.Location = new System.Drawing.Point(10, 416);
            this.AddToUserLibraryButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddToUserLibraryButton.Name = "AddToUserLibraryButton";
            this.AddToUserLibraryButton.Size = new System.Drawing.Size(232, 61);
            this.AddToUserLibraryButton.TabIndex = 1;
            this.AddToUserLibraryButton.Text = "Add to my library";
            this.AddToUserLibraryButton.UseVisualStyleBackColor = true;
            this.AddToUserLibraryButton.Click += new System.EventHandler(this.AddToUserLibraryButton_Click);
            // 
            // BooksDGV
            // 
            this.BooksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Location = new System.Drawing.Point(10, 8);
            this.BooksDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.Size = new System.Drawing.Size(932, 400);
            this.BooksDGV.TabIndex = 0;
            // 
            // UserLibrary
            // 
            this.UserLibrary.Location = new System.Drawing.Point(4, 27);
            this.UserLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.UserLibrary.Name = "UserLibrary";
            this.UserLibrary.Padding = new System.Windows.Forms.Padding(4);
            this.UserLibrary.Size = new System.Drawing.Size(988, 484);
            this.UserLibrary.TabIndex = 1;
            this.UserLibrary.Text = "My Library";
            this.UserLibrary.UseVisualStyleBackColor = true;
            // 
            // UserProfile
            // 
            this.UserProfile.Location = new System.Drawing.Point(4, 27);
            this.UserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Padding = new System.Windows.Forms.Padding(4);
            this.UserProfile.Size = new System.Drawing.Size(988, 484);
            this.UserProfile.TabIndex = 2;
            this.UserProfile.Text = "MyProfile";
            this.UserProfile.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 547);
            this.Controls.Add(this.UserMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "Menu";
            this.UserMenu.ResumeLayout(false);
            this.LibraryTab.ResumeLayout(false);
            this.LibraryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserMenu;
        private System.Windows.Forms.TabPage LibraryTab;
        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.TabPage UserLibrary;
        private System.Windows.Forms.Button AddToUserLibraryButton;
        private System.Windows.Forms.RadioButton Title;
        private System.Windows.Forms.RadioButton AuthorRButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage UserProfile;
    }
}