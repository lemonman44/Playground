namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.checkedListForDeletion = new System.Windows.Forms.CheckedListBox();
            this.deleteFromCheckListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListForDeletion
            // 
            this.checkedListForDeletion.FormattingEnabled = true;
            this.checkedListForDeletion.Location = new System.Drawing.Point(12, 12);
            this.checkedListForDeletion.Name = "checkedListForDeletion";
            this.checkedListForDeletion.Size = new System.Drawing.Size(407, 290);
            this.checkedListForDeletion.TabIndex = 0;
            // 
            // deleteFromCheckListButton
            // 
            this.deleteFromCheckListButton.Location = new System.Drawing.Point(143, 356);
            this.deleteFromCheckListButton.Name = "deleteFromCheckListButton";
            this.deleteFromCheckListButton.Size = new System.Drawing.Size(161, 48);
            this.deleteFromCheckListButton.TabIndex = 1;
            this.deleteFromCheckListButton.Text = "Delete";
            this.deleteFromCheckListButton.UseVisualStyleBackColor = true;
            this.deleteFromCheckListButton.Click += new System.EventHandler(this.deleteFromCheckListButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 428);
            this.Controls.Add(this.deleteFromCheckListButton);
            this.Controls.Add(this.checkedListForDeletion);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListForDeletion;
        private System.Windows.Forms.Button deleteFromCheckListButton;
    }
}