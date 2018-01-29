namespace TicTacToe
{
    partial class Form1
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
            this.XLabel = new System.Windows.Forms.Label();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.XLabelCount = new System.Windows.Forms.Label();
            this.OLabelCount = new System.Windows.Forms.Label();
            this.OLabel = new System.Windows.Forms.Label();
            this.DrawLabelCount = new System.Windows.Forms.Label();
            this.DrawLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XLabel.Location = new System.Drawing.Point(12, 55);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(24, 20);
            this.XLabel.TabIndex = 0;
            this.XLabel.Text = "X:";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(12, 29);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(75, 23);
            this.NewGameBtn.TabIndex = 1;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // XLabelCount
            // 
            this.XLabelCount.AutoSize = true;
            this.XLabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XLabelCount.Location = new System.Drawing.Point(69, 55);
            this.XLabelCount.Name = "XLabelCount";
            this.XLabelCount.Size = new System.Drawing.Size(18, 20);
            this.XLabelCount.TabIndex = 2;
            this.XLabelCount.Text = "0";
            this.XLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OLabelCount
            // 
            this.OLabelCount.AutoSize = true;
            this.OLabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OLabelCount.Location = new System.Drawing.Point(69, 79);
            this.OLabelCount.Name = "OLabelCount";
            this.OLabelCount.Size = new System.Drawing.Size(18, 20);
            this.OLabelCount.TabIndex = 4;
            this.OLabelCount.Text = "0";
            this.OLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OLabel
            // 
            this.OLabel.AutoSize = true;
            this.OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OLabel.Location = new System.Drawing.Point(12, 79);
            this.OLabel.Name = "OLabel";
            this.OLabel.Size = new System.Drawing.Size(25, 20);
            this.OLabel.TabIndex = 3;
            this.OLabel.Text = "O:";
            this.OLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawLabelCount
            // 
            this.DrawLabelCount.AutoSize = true;
            this.DrawLabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrawLabelCount.Location = new System.Drawing.Point(69, 103);
            this.DrawLabelCount.Name = "DrawLabelCount";
            this.DrawLabelCount.Size = new System.Drawing.Size(18, 20);
            this.DrawLabelCount.TabIndex = 6;
            this.DrawLabelCount.Text = "0";
            this.DrawLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawLabel
            // 
            this.DrawLabel.AutoSize = true;
            this.DrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrawLabel.Location = new System.Drawing.Point(12, 103);
            this.DrawLabel.Name = "DrawLabel";
            this.DrawLabel.Size = new System.Drawing.Size(50, 20);
            this.DrawLabel.TabIndex = 5;
            this.DrawLabel.Text = "Draw:";
            this.DrawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.NewGameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.DrawLabelCount);
            this.Controls.Add(this.DrawLabel);
            this.Controls.Add(this.OLabelCount);
            this.Controls.Add(this.OLabel);
            this.Controls.Add(this.XLabelCount);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.XLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Label XLabelCount;
        private System.Windows.Forms.Label OLabelCount;
        private System.Windows.Forms.Label OLabel;
        private System.Windows.Forms.Label DrawLabelCount;
        private System.Windows.Forms.Label DrawLabel;
    }
}

