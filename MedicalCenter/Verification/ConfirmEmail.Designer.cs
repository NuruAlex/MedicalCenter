namespace MedicalCenter.Verification
{
    partial class ConfirmEmail
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
            this.numberInput = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.СancellationButton = new System.Windows.Forms.Button();
            this.GoToAWordConfirmation = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число для подверждения из почты:";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(47, 102);
            this.numberInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(215, 23);
            this.numberInput.TabIndex = 1;
            this.numberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(292, 102);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(120, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // СancellationButton
            // 
            this.СancellationButton.Location = new System.Drawing.Point(292, 173);
            this.СancellationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.СancellationButton.Name = "СancellationButton";
            this.СancellationButton.Size = new System.Drawing.Size(115, 25);
            this.СancellationButton.TabIndex = 3;
            this.СancellationButton.Text = "Отмена";
            this.СancellationButton.UseVisualStyleBackColor = true;
            this.СancellationButton.Click += new System.EventHandler(this.СancellationButton_Click);
            // 
            // GoToAWordConfirmation
            // 
            this.GoToAWordConfirmation.AutoSize = true;
            this.GoToAWordConfirmation.Location = new System.Drawing.Point(86, 178);
            this.GoToAWordConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToAWordConfirmation.Name = "GoToAWordConfirmation";
            this.GoToAWordConfirmation.Size = new System.Drawing.Size(134, 15);
            this.GoToAWordConfirmation.TabIndex = 4;
            this.GoToAWordConfirmation.TabStop = true;
            this.GoToAWordConfirmation.Text = "Выбрать другой способ";
            this.GoToAWordConfirmation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToAWordConfirmation_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 66;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageLine
            // 
            this.MessageLine.Name = "MessageLine";
            this.MessageLine.Size = new System.Drawing.Size(0, 17);
            // 
            // ConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 277);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GoToAWordConfirmation);
            this.Controls.Add(this.СancellationButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConfirmEmail";
            this.Text = "ConfirmEmail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfirmEmail_FormClosed);
            this.Load += new System.EventHandler(this.ConfirmEmail_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberInput;
        public System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button СancellationButton;
        public  System.Windows.Forms.LinkLabel GoToAWordConfirmation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageLine;
    }
}