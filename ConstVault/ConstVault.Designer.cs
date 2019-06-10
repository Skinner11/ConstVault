namespace ConstVault
{
    partial class ConstVault
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
            this.btn_newConst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newConst
            // 
            this.btn_newConst.Location = new System.Drawing.Point(34, 45);
            this.btn_newConst.Name = "btn_newConst";
            this.btn_newConst.Size = new System.Drawing.Size(140, 102);
            this.btn_newConst.TabIndex = 1;
            this.btn_newConst.Text = "New Const";
            this.btn_newConst.UseVisualStyleBackColor = true;
            this.btn_newConst.Click += new System.EventHandler(this.btn_newConst_Click);
            // 
            // ConstVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_newConst);
            this.Name = "ConstVault";
            this.Text = "ConstVault";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newConst;
    }
}

