namespace Team2_MyBank
{
    partial class MessageForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(145, 314);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(118, 44);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // placeholder
            // 
            this.placeholder.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.Location = new System.Drawing.Point(85, 71);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(242, 197);
            this.placeholder.TabIndex = 1;
            this.placeholder.Text = "placeholder";
            this.placeholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 399);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.closeButton);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label placeholder;
    }
}