namespace GUIProject
{
    partial class ChangePhoneNumberForm
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
            this.components = new System.ComponentModel.Container();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.AtributeLable = new System.Windows.Forms.Label();
            this.EmptyFieldError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmptyFieldError)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.Location = new System.Drawing.Point(37, 67);
            this.PhoneTextBox.Mask = "8(999) 000-0000";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(182, 24);
            this.PhoneTextBox.TabIndex = 0;
            this.PhoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneTextBox_Validating);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(57, 122);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(150, 27);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AtributeLable
            // 
            this.AtributeLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AtributeLable.AutoSize = true;
            this.AtributeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AtributeLable.Location = new System.Drawing.Point(54, 20);
            this.AtributeLable.Name = "AtributeLable";
            this.AtributeLable.Size = new System.Drawing.Size(118, 18);
            this.AtributeLable.TabIndex = 3;
            this.AtributeLable.Text = "Change Phone";
            // 
            // EmptyFieldError
            // 
            this.EmptyFieldError.ContainerControl = this;
            // 
            // ChangePhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.AtributeLable);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.PhoneTextBox);
            this.Name = "ChangePhoneNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePhone";
            ((System.ComponentModel.ISupportInitialize)(this.EmptyFieldError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label AtributeLable;
        private System.Windows.Forms.ErrorProvider EmptyFieldError;
    }
}