namespace OmniconApp.Views
{
    partial class Products_deleteNotification
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
            this.messageNotification = new System.Windows.Forms.Label();
            this.buttonConfirmation = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageNotification
            // 
            this.messageNotification.AutoSize = true;
            this.messageNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageNotification.Location = new System.Drawing.Point(57, 44);
            this.messageNotification.Name = "messageNotification";
            this.messageNotification.Size = new System.Drawing.Size(241, 16);
            this.messageNotification.TabIndex = 0;
            this.messageNotification.Text = "User, do you want to delete this record?";
            // 
            // buttonConfirmation
            // 
            this.buttonConfirmation.Location = new System.Drawing.Point(364, 86);
            this.buttonConfirmation.Name = "buttonConfirmation";
            this.buttonConfirmation.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmation.TabIndex = 1;
            this.buttonConfirmation.Text = "Yes";
            this.buttonConfirmation.UseVisualStyleBackColor = true;
            this.buttonConfirmation.Click += new System.EventHandler(this.buttonConfirmation_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(251, 86);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Products_deleteNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 121);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirmation);
            this.Controls.Add(this.messageNotification);
            this.Name = "Products_deleteNotification";
            this.Text = "Products_deleteNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageNotification;
        private System.Windows.Forms.Button buttonConfirmation;
        private System.Windows.Forms.Button buttonCancel;
    }
}