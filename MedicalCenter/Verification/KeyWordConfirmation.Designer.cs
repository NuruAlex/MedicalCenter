namespace MedicalCenter.Verification
{
    partial class KeyWordConfirmation
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
            this.СancellationButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoToEmailConfirmation = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // СancellationButton
            // 
            this.СancellationButton.Location = new System.Drawing.Point(311, 145);
            this.СancellationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.СancellationButton.Name = "СancellationButton";
            this.СancellationButton.Size = new System.Drawing.Size(115, 25);
            this.СancellationButton.TabIndex = 7;
            this.СancellationButton.Text = "Отмена";
            this.СancellationButton.UseVisualStyleBackColor = true;
            this.СancellationButton.Click += new System.EventHandler(this.СancellationButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(311, 97);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(120, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(68, 97);
            this.KeyWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(215, 23);
            this.KeyWord.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ваше ключевое слово:";
            // 
            // GoToEmailConfirmation
            // 
            this.GoToEmailConfirmation.AutoSize = true;
            this.GoToEmailConfirmation.Location = new System.Drawing.Point(44, 155);
            this.GoToEmailConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoToEmailConfirmation.Name = "GoToEmailConfirmation";
            this.GoToEmailConfirmation.Size = new System.Drawing.Size(206, 15);
            this.GoToEmailConfirmation.TabIndex = 8;
            this.GoToEmailConfirmation.TabStop = true;
            this.GoToEmailConfirmation.Text = "Вернуться к подтверждение по почте";
            this.GoToEmailConfirmation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToEmailConfirmation_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 226);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 67;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageLine
            // 
            this.MessageLine.Name = "MessageLine";
            this.MessageLine.Size = new System.Drawing.Size(0, 17);
            // 
            // KeyWordConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 248);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GoToEmailConfirmation);
            this.Controls.Add(this.СancellationButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.KeyWord);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KeyWordConfirmation";
            this.Text = "KeyWordConfirmation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KeyWordConfirmation_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button СancellationButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel GoToEmailConfirmation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageLine;
    }
}