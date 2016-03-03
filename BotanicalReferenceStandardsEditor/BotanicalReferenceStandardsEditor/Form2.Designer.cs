namespace BotanicalReferenceStandardsEditor
{
    partial class RemovePopUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.removeOKButton = new System.Windows.Forms.Button();
            this.removeCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to remove this reference standard?";
            // 
            // removeOKButton
            // 
            this.removeOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.removeOKButton.Location = new System.Drawing.Point(69, 45);
            this.removeOKButton.Name = "removeOKButton";
            this.removeOKButton.Size = new System.Drawing.Size(75, 23);
            this.removeOKButton.TabIndex = 1;
            this.removeOKButton.Text = "OK";
            this.removeOKButton.UseVisualStyleBackColor = true;
            // 
            // removeCancelButton
            // 
            this.removeCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeCancelButton.Location = new System.Drawing.Point(150, 45);
            this.removeCancelButton.Name = "removeCancelButton";
            this.removeCancelButton.Size = new System.Drawing.Size(75, 23);
            this.removeCancelButton.TabIndex = 2;
            this.removeCancelButton.Text = "Cancel";
            this.removeCancelButton.UseVisualStyleBackColor = true;
            // 
            // RemovePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 80);
            this.Controls.Add(this.removeCancelButton);
            this.Controls.Add(this.removeOKButton);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(309, 118);
            this.MinimumSize = new System.Drawing.Size(309, 118);
            this.Name = "RemovePopUp";
            this.ShowInTaskbar = false;
            this.Text = "Remove Reference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeOKButton;
        private System.Windows.Forms.Button removeCancelButton;
    }
}