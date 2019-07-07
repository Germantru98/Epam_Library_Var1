namespace GUIProject
{
    partial class ChangeInformationForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.AtributeTextBox = new System.Windows.Forms.TextBox();
            this.AtributeLable = new System.Windows.Forms.Label();
            this.EmptyFieldError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmptyFieldError)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(26, 100);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(100, 27);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AtributeTextBox
            // 
            this.AtributeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AtributeTextBox.Location = new System.Drawing.Point(12, 56);
            this.AtributeTextBox.Name = "AtributeTextBox";
            this.AtributeTextBox.Size = new System.Drawing.Size(132, 22);
            this.AtributeTextBox.TabIndex = 1;
            this.AtributeTextBox.Validated += new System.EventHandler(this.AtributeTextBox_Validated);
            // 
            // AtributeLable
            // 
            this.AtributeLable.AutoSize = true;
            this.AtributeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AtributeLable.Location = new System.Drawing.Point(23, 23);
            this.AtributeLable.Name = "AtributeLable";
            this.AtributeLable.Size = new System.Drawing.Size(65, 18);
            this.AtributeLable.TabIndex = 2;
            this.AtributeLable.Text = "Atribute";
            // 
            // EmptyFieldError
            // 
            this.EmptyFieldError.ContainerControl = this;
            // 
            // ChangeInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.AtributeLable);
            this.Controls.Add(this.AtributeTextBox);
            this.Controls.Add(this.AcceptButton);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ChangeInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ChangeInformationForm_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.EmptyFieldError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox AtributeTextBox;
        private System.Windows.Forms.Label AtributeLable;
        private System.Windows.Forms.ErrorProvider EmptyFieldError;
    }
}