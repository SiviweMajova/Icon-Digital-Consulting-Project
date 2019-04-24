namespace Siviwe
{
    partial class frmSales
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
            this.btnInput = new System.Windows.Forms.Button();
            this.txtShoppingData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(13, 13);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(479, 40);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Add Shopping Data";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtShoppingData
            // 
            this.txtShoppingData.Location = new System.Drawing.Point(13, 60);
            this.txtShoppingData.Multiline = true;
            this.txtShoppingData.Name = "txtShoppingData";
            this.txtShoppingData.Size = new System.Drawing.Size(479, 189);
            this.txtShoppingData.TabIndex = 1;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.txtShoppingData);
            this.Controls.Add(this.btnInput);
            this.Name = "frmSales";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtShoppingData;
    }
}

