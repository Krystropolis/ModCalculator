namespace L004
{
    partial class Client
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
            this.modComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modComboBox
            // 
            this.modComboBox.FormattingEnabled = true;
            this.modComboBox.Location = new System.Drawing.Point(12, 34);
            this.modComboBox.Name = "modComboBox";
            this.modComboBox.Size = new System.Drawing.Size(342, 24);
            this.modComboBox.TabIndex = 6;
            this.modComboBox.SelectedIndexChanged += new System.EventHandler(this.modComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Instructions: Select a module from the dropdown list.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Value:";
            // 
            // finalValue
            // 
            this.finalValue.AutoSize = true;
            this.finalValue.Location = new System.Drawing.Point(114, 67);
            this.finalValue.Name = "finalValue";
            this.finalValue.Size = new System.Drawing.Size(16, 17);
            this.finalValue.TabIndex = 9;
            this.finalValue.Text = "0";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 93);
            this.Controls.Add(this.finalValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modComboBox);
            this.MaximumSize = new System.Drawing.Size(384, 140);
            this.MinimumSize = new System.Drawing.Size(384, 117);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox modComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label finalValue;
    }
}

