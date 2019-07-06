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
            this.ExtendBookButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MyLibraryTable = new System.Windows.Forms.DataGridView();
            this.UserProfile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneInf = new System.Windows.Forms.Label();
            this.SurnameInf = new System.Windows.Forms.Label();
            this.NameInf = new System.Windows.Forms.Label();
            this.LoginInf = new System.Windows.Forms.Label();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.SurnameLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.UserMenu.SuspendLayout();
            this.LibraryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.UserLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyLibraryTable)).BeginInit();
            this.UserProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.UserLibrary.Controls.Add(this.RefreshButton);
            this.UserLibrary.Controls.Add(this.ExtendBookButton);
            this.UserLibrary.Controls.Add(this.RemoveButton);
            this.UserLibrary.Controls.Add(this.MyLibraryTable);
            this.UserLibrary.Location = new System.Drawing.Point(4, 27);
            this.UserLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.UserLibrary.Name = "UserLibrary";
            this.UserLibrary.Padding = new System.Windows.Forms.Padding(4);
            this.UserLibrary.Size = new System.Drawing.Size(988, 484);
            this.UserLibrary.TabIndex = 1;
            this.UserLibrary.Text = "My Library";
            this.UserLibrary.UseVisualStyleBackColor = true;
            // 
            // ExtendBookButton
            // 
            this.ExtendBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtendBookButton.Location = new System.Drawing.Point(203, 395);
            this.ExtendBookButton.Name = "ExtendBookButton";
            this.ExtendBookButton.Size = new System.Drawing.Size(120, 50);
            this.ExtendBookButton.TabIndex = 2;
            this.ExtendBookButton.Text = "Extend book for 7 days";
            this.ExtendBookButton.UseVisualStyleBackColor = true;
            this.ExtendBookButton.Click += new System.EventHandler(this.ExtendBookButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(39, 395);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(120, 50);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove From Library";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MyLibraryTable
            // 
            this.MyLibraryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyLibraryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyLibraryTable.Location = new System.Drawing.Point(7, 7);
            this.MyLibraryTable.Name = "MyLibraryTable";
            this.MyLibraryTable.Size = new System.Drawing.Size(974, 346);
            this.MyLibraryTable.TabIndex = 0;
            // 
            // UserProfile
            // 
            this.UserProfile.Controls.Add(this.groupBox1);
            this.UserProfile.Location = new System.Drawing.Point(4, 27);
            this.UserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Padding = new System.Windows.Forms.Padding(4);
            this.UserProfile.Size = new System.Drawing.Size(988, 484);
            this.UserProfile.TabIndex = 2;
            this.UserProfile.Text = "MyProfile";
            this.UserProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneInf);
            this.groupBox1.Controls.Add(this.SurnameInf);
            this.groupBox1.Controls.Add(this.NameInf);
            this.groupBox1.Controls.Add(this.LoginInf);
            this.groupBox1.Controls.Add(this.PhoneLable);
            this.groupBox1.Controls.Add(this.SurnameLable);
            this.groupBox1.Controls.Add(this.NameLable);
            this.groupBox1.Controls.Add(this.LoginLable);
            this.groupBox1.Location = new System.Drawing.Point(7, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // PhoneInf
            // 
            this.PhoneInf.AutoSize = true;
            this.PhoneInf.Location = new System.Drawing.Point(73, 127);
            this.PhoneInf.Name = "PhoneInf";
            this.PhoneInf.Size = new System.Drawing.Size(66, 18);
            this.PhoneInf.TabIndex = 7;
            this.PhoneInf.Text = "PhoneInf";
            // 
            // SurnameInf
            // 
            this.SurnameInf.AutoSize = true;
            this.SurnameInf.Location = new System.Drawing.Point(97, 94);
            this.SurnameInf.Name = "SurnameInf";
            this.SurnameInf.Size = new System.Drawing.Size(83, 18);
            this.SurnameInf.TabIndex = 6;
            this.SurnameInf.Text = "SurnameInf";
            // 
            // NameInf
            // 
            this.NameInf.AutoSize = true;
            this.NameInf.Location = new System.Drawing.Point(71, 60);
            this.NameInf.Name = "NameInf";
            this.NameInf.Size = new System.Drawing.Size(63, 18);
            this.NameInf.TabIndex = 5;
            this.NameInf.Text = "NameInf";
            // 
            // LoginInf
            // 
            this.LoginInf.AutoSize = true;
            this.LoginInf.Location = new System.Drawing.Point(62, 29);
            this.LoginInf.Name = "LoginInf";
            this.LoginInf.Size = new System.Drawing.Size(59, 18);
            this.LoginInf.TabIndex = 4;
            this.LoginInf.Text = "LoginInf";
            // 
            // PhoneLable
            // 
            this.PhoneLable.AutoSize = true;
            this.PhoneLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLable.Location = new System.Drawing.Point(6, 127);
            this.PhoneLable.Name = "PhoneLable";
            this.PhoneLable.Size = new System.Drawing.Size(61, 18);
            this.PhoneLable.TabIndex = 3;
            this.PhoneLable.Text = "Phone:";
            // 
            // SurnameLable
            // 
            this.SurnameLable.AutoSize = true;
            this.SurnameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLable.Location = new System.Drawing.Point(6, 94);
            this.SurnameLable.Name = "SurnameLable";
            this.SurnameLable.Size = new System.Drawing.Size(85, 18);
            this.SurnameLable.TabIndex = 2;
            this.SurnameLable.Text = "Surname: ";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLable.Location = new System.Drawing.Point(6, 60);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(62, 18);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "Name: ";
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLable.Location = new System.Drawing.Point(6, 29);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(59, 18);
            this.LoginLable.TabIndex = 0;
            this.LoginLable.Text = "Login: ";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::GUIProject.Properties.Resources.refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(924, 433);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(46, 38);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.UserLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyLibraryTable)).EndInit();
            this.UserProfile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PhoneInf;
        private System.Windows.Forms.Label SurnameInf;
        private System.Windows.Forms.Label NameInf;
        private System.Windows.Forms.Label LoginInf;
        private System.Windows.Forms.Label PhoneLable;
        private System.Windows.Forms.Label SurnameLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.DataGridView MyLibraryTable;
        private System.Windows.Forms.Button ExtendBookButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}