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
            this.RefreshButton1 = new System.Windows.Forms.Button();
            this.TitleRButton = new System.Windows.Forms.RadioButton();
            this.AuthorRButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ParamTextBox = new System.Windows.Forms.TextBox();
            this.AddToUserLibraryButton = new System.Windows.Forms.Button();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.UserLibrary = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ExtendBookButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MyLibraryTable = new System.Windows.Forms.DataGridView();
            this.UserProfile = new System.Windows.Forms.TabPage();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangeLoginButton = new System.Windows.Forms.Button();
            this.ChangePhoneButton = new System.Windows.Forms.Button();
            this.ChangeSurnameButton = new System.Windows.Forms.Button();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.MainInformationBox = new System.Windows.Forms.GroupBox();
            this.PhoneInf = new System.Windows.Forms.Label();
            this.SurnameInf = new System.Windows.Forms.Label();
            this.NameInf = new System.Windows.Forms.Label();
            this.LoginInf = new System.Windows.Forms.Label();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.SurnameLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.UserMenu.SuspendLayout();
            this.LibraryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.UserLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyLibraryTable)).BeginInit();
            this.UserProfile.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            this.MainInformationBox.SuspendLayout();
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
            this.LibraryTab.Controls.Add(this.RefreshButton1);
            this.LibraryTab.Controls.Add(this.TitleRButton);
            this.LibraryTab.Controls.Add(this.AuthorRButton);
            this.LibraryTab.Controls.Add(this.SearchButton);
            this.LibraryTab.Controls.Add(this.ParamTextBox);
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
            // RefreshButton1
            // 
            this.RefreshButton1.BackgroundImage = global::GUIProject.Properties.Resources.refresh;
            this.RefreshButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton1.Location = new System.Drawing.Point(946, 442);
            this.RefreshButton1.Name = "RefreshButton1";
            this.RefreshButton1.Size = new System.Drawing.Size(35, 35);
            this.RefreshButton1.TabIndex = 6;
            this.RefreshButton1.UseVisualStyleBackColor = true;
            this.RefreshButton1.Click += new System.EventHandler(this.RefreshButton1_Click);
            // 
            // TitleRButton
            // 
            this.TitleRButton.AutoSize = true;
            this.TitleRButton.Location = new System.Drawing.Point(477, 451);
            this.TitleRButton.Margin = new System.Windows.Forms.Padding(4);
            this.TitleRButton.Name = "TitleRButton";
            this.TitleRButton.Size = new System.Drawing.Size(52, 20);
            this.TitleRButton.TabIndex = 5;
            this.TitleRButton.TabStop = true;
            this.TitleRButton.Text = "Title";
            this.TitleRButton.UseVisualStyleBackColor = true;
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
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ParamTextBox
            // 
            this.ParamTextBox.Location = new System.Drawing.Point(271, 416);
            this.ParamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParamTextBox.Name = "ParamTextBox";
            this.ParamTextBox.Size = new System.Drawing.Size(178, 22);
            this.ParamTextBox.TabIndex = 2;
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
            this.BooksDGV.Size = new System.Drawing.Size(970, 400);
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
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::GUIProject.Properties.Resources.refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(946, 442);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(35, 35);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ExtendBookButton
            // 
            this.ExtendBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtendBookButton.Location = new System.Drawing.Point(161, 421);
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
            this.RemoveButton.Location = new System.Drawing.Point(7, 421);
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
            this.MyLibraryTable.Size = new System.Drawing.Size(970, 400);
            this.MyLibraryTable.TabIndex = 0;
            // 
            // UserProfile
            // 
            this.UserProfile.Controls.Add(this.SettingsBox);
            this.UserProfile.Controls.Add(this.MainInformationBox);
            this.UserProfile.Location = new System.Drawing.Point(4, 27);
            this.UserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Padding = new System.Windows.Forms.Padding(4);
            this.UserProfile.Size = new System.Drawing.Size(988, 484);
            this.UserProfile.TabIndex = 2;
            this.UserProfile.Text = "MyProfile";
            this.UserProfile.UseVisualStyleBackColor = true;
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.ChangePasswordButton);
            this.SettingsBox.Controls.Add(this.ChangeLoginButton);
            this.SettingsBox.Controls.Add(this.ChangePhoneButton);
            this.SettingsBox.Controls.Add(this.ChangeSurnameButton);
            this.SettingsBox.Controls.Add(this.ChangeNameButton);
            this.SettingsBox.Location = new System.Drawing.Point(437, 29);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(349, 200);
            this.SettingsBox.TabIndex = 2;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Settings";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(131, 110);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(94, 49);
            this.ChangePasswordButton.TabIndex = 4;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangeLoginButton
            // 
            this.ChangeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLoginButton.Location = new System.Drawing.Point(20, 110);
            this.ChangeLoginButton.Name = "ChangeLoginButton";
            this.ChangeLoginButton.Size = new System.Drawing.Size(94, 49);
            this.ChangeLoginButton.TabIndex = 3;
            this.ChangeLoginButton.Text = "Change Login";
            this.ChangeLoginButton.UseVisualStyleBackColor = true;
            this.ChangeLoginButton.Click += new System.EventHandler(this.ChangeLoginButton_Click);
            // 
            // ChangePhoneButton
            // 
            this.ChangePhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePhoneButton.Location = new System.Drawing.Point(240, 27);
            this.ChangePhoneButton.Name = "ChangePhoneButton";
            this.ChangePhoneButton.Size = new System.Drawing.Size(94, 49);
            this.ChangePhoneButton.TabIndex = 2;
            this.ChangePhoneButton.Text = "Change Phone";
            this.ChangePhoneButton.UseVisualStyleBackColor = true;
            this.ChangePhoneButton.Click += new System.EventHandler(this.ChangePhoneButton_Click);
            // 
            // ChangeSurnameButton
            // 
            this.ChangeSurnameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSurnameButton.Location = new System.Drawing.Point(131, 27);
            this.ChangeSurnameButton.Name = "ChangeSurnameButton";
            this.ChangeSurnameButton.Size = new System.Drawing.Size(94, 49);
            this.ChangeSurnameButton.TabIndex = 1;
            this.ChangeSurnameButton.Text = "Change Surname";
            this.ChangeSurnameButton.UseVisualStyleBackColor = true;
            this.ChangeSurnameButton.Click += new System.EventHandler(this.ChangeSurnameButton_Click);
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNameButton.Location = new System.Drawing.Point(20, 27);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(94, 49);
            this.ChangeNameButton.TabIndex = 0;
            this.ChangeNameButton.Text = "Change Name";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // MainInformationBox
            // 
            this.MainInformationBox.Controls.Add(this.PhoneInf);
            this.MainInformationBox.Controls.Add(this.SurnameInf);
            this.MainInformationBox.Controls.Add(this.NameInf);
            this.MainInformationBox.Controls.Add(this.LoginInf);
            this.MainInformationBox.Controls.Add(this.PhoneLable);
            this.MainInformationBox.Controls.Add(this.SurnameLable);
            this.MainInformationBox.Controls.Add(this.NameLable);
            this.MainInformationBox.Controls.Add(this.LoginLable);
            this.MainInformationBox.Location = new System.Drawing.Point(22, 27);
            this.MainInformationBox.Name = "MainInformationBox";
            this.MainInformationBox.Size = new System.Drawing.Size(300, 200);
            this.MainInformationBox.TabIndex = 1;
            this.MainInformationBox.TabStop = false;
            this.MainInformationBox.Text = "Information";
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
            this.SettingsBox.ResumeLayout(false);
            this.MainInformationBox.ResumeLayout(false);
            this.MainInformationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserMenu;
        private System.Windows.Forms.TabPage LibraryTab;
        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.TabPage UserLibrary;
        private System.Windows.Forms.Button AddToUserLibraryButton;
        private System.Windows.Forms.RadioButton TitleRButton;
        private System.Windows.Forms.RadioButton AuthorRButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ParamTextBox;
        private System.Windows.Forms.TabPage UserProfile;
        private System.Windows.Forms.GroupBox MainInformationBox;
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
        private System.Windows.Forms.Button RefreshButton1;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ChangeLoginButton;
        private System.Windows.Forms.Button ChangePhoneButton;
        private System.Windows.Forms.Button ChangeSurnameButton;
        private System.Windows.Forms.Button ChangeNameButton;
    }
}