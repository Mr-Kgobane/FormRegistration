namespace Kgobane_Kagiso_PRG282_ST
{
    partial class frmDelete
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
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(33, 52);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(117, 16);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "Applicant Number:";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(177, 46);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(129, 22);
            this.txtDelete.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(75, 98);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExts
            // 
            this.btnExts.Location = new System.Drawing.Point(202, 98);
            this.btnExts.Name = "btnExts";
            this.btnExts.Size = new System.Drawing.Size(75, 23);
            this.btnExts.TabIndex = 3;
            this.btnExts.Text = "Exit";
            this.btnExts.UseVisualStyleBackColor = true;
            this.btnExts.Click += new System.EventHandler(this.btnExts_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 157);
            this.Controls.Add(this.btnExts);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.lblDelete);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExts;
    }
}