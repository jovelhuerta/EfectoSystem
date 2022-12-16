namespace Presentation.BaseForms
{
    partial class FingerPrintForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.StatusLine = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.FingerOne = new System.Windows.Forms.PictureBox();
            this.FingerTwo = new System.Windows.Forms.PictureBox();
            this.FingerThird = new System.Windows.Forms.PictureBox();
            this.FingerFourth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FingerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerFourth)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(532, 338);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 50);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Guardar";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // StatusLine
            // 
            this.StatusLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLine.Location = new System.Drawing.Point(10, 47);
            this.StatusLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(354, 48);
            this.StatusLine.TabIndex = 12;
            this.StatusLine.Text = "[Status line]";
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.Location = new System.Drawing.Point(63, 161);
            this.StatusText.Margin = new System.Windows.Forms.Padding(4);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(363, 237);
            this.StatusText.TabIndex = 11;
            // 
            // Prompt
            // 
            this.Prompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prompt.Location = new System.Drawing.Point(150, 115);
            this.Prompt.Margin = new System.Windows.Forms.Padding(4);
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(363, 22);
            this.Prompt.TabIndex = 9;
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Location = new System.Drawing.Point(311, 95);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(53, 16);
            this.PromptLabel.TabIndex = 8;
            this.PromptLabel.Text = "Prompt:";
            // 
            // FingerOne
            // 
            this.FingerOne.Image = global::Presentation.Properties.Resources.finger;
            this.FingerOne.Location = new System.Drawing.Point(77, 457);
            this.FingerOne.Margin = new System.Windows.Forms.Padding(4);
            this.FingerOne.Name = "FingerOne";
            this.FingerOne.Size = new System.Drawing.Size(93, 73);
            this.FingerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FingerOne.TabIndex = 14;
            this.FingerOne.TabStop = false;
            // 
            // FingerTwo
            // 
            this.FingerTwo.Image = global::Presentation.Properties.Resources.finger;
            this.FingerTwo.Location = new System.Drawing.Point(226, 457);
            this.FingerTwo.Margin = new System.Windows.Forms.Padding(4);
            this.FingerTwo.Name = "FingerTwo";
            this.FingerTwo.Size = new System.Drawing.Size(93, 73);
            this.FingerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FingerTwo.TabIndex = 15;
            this.FingerTwo.TabStop = false;
            // 
            // FingerThird
            // 
            this.FingerThird.Image = global::Presentation.Properties.Resources.finger;
            this.FingerThird.Location = new System.Drawing.Point(370, 457);
            this.FingerThird.Margin = new System.Windows.Forms.Padding(4);
            this.FingerThird.Name = "FingerThird";
            this.FingerThird.Size = new System.Drawing.Size(93, 73);
            this.FingerThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FingerThird.TabIndex = 16;
            this.FingerThird.TabStop = false;
            // 
            // FingerFourth
            // 
            this.FingerFourth.Image = global::Presentation.Properties.Resources.finger;
            this.FingerFourth.Location = new System.Drawing.Point(532, 457);
            this.FingerFourth.Margin = new System.Windows.Forms.Padding(4);
            this.FingerFourth.Name = "FingerFourth";
            this.FingerFourth.Size = new System.Drawing.Size(93, 73);
            this.FingerFourth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FingerFourth.TabIndex = 17;
            this.FingerFourth.TabStop = false;
            // 
            // FingerPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 573);
            this.Controls.Add(this.FingerFourth);
            this.Controls.Add(this.FingerThird);
            this.Controls.Add(this.FingerTwo);
            this.Controls.Add(this.FingerOne);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.PromptLabel);
            this.Name = "FingerPrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FingerPrintForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FingerPrintForm_FormClosed);
            this.Load += new System.EventHandler(this.FingerPrintForm_Load);
            this.Controls.SetChildIndex(this.PromptLabel, 0);
            this.Controls.SetChildIndex(this.Prompt, 0);
            this.Controls.SetChildIndex(this.StatusText, 0);
            this.Controls.SetChildIndex(this.StatusLine, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.FingerOne, 0);
            this.Controls.SetChildIndex(this.FingerTwo, 0);
            this.Controls.SetChildIndex(this.FingerThird, 0);
            this.Controls.SetChildIndex(this.FingerFourth, 0);
            ((System.ComponentModel.ISupportInitialize)(this.FingerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerFourth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.PictureBox FingerOne;
        private System.Windows.Forms.PictureBox FingerTwo;
        private System.Windows.Forms.PictureBox FingerThird;
        private System.Windows.Forms.PictureBox FingerFourth;
    }
}