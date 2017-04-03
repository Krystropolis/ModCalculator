namespace L004
{
    partial class InputDialog
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
            this.dInstrLbl = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dInstrLbl
            // 
            this.dInstrLbl.AutoSize = true;
            this.dInstrLbl.Location = new System.Drawing.Point(12, 9);
            this.dInstrLbl.Name = "dInstrLbl";
            this.dInstrLbl.Size = new System.Drawing.Size(315, 17);
            this.dInstrLbl.TabIndex = 0;
            this.dInstrLbl.Text = "Please input a number and submit for calculation";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(15, 31);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(231, 22);
            this.inputTxt.TabIndex = 1;
            this.inputTxt.Text = "0";
            this.inputTxt.Enter += new System.EventHandler(this.inputTxt_Enter);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(252, 29);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 26);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 67);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.dInstrLbl);
            this.MaximumSize = new System.Drawing.Size(357, 114);
            this.MinimumSize = new System.Drawing.Size(357, 114);
            this.Name = "InputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTxt_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dInstrLbl;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Button submitBtn;
    }
}