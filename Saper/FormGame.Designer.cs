namespace Saper
{
    partial class Saper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNameScore = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelNameMine = new System.Windows.Forms.Label();
            this.labelMineScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(730, 733);
            this.FlowLayoutPanel.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(891, 659);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(147, 55);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Начать игру";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelNameScore
            // 
            this.labelNameScore.AutoSize = true;
            this.labelNameScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameScore.Location = new System.Drawing.Point(800, 89);
            this.labelNameScore.Name = "labelNameScore";
            this.labelNameScore.Size = new System.Drawing.Size(97, 45);
            this.labelNameScore.TabIndex = 3;
            this.labelNameScore.Text = "Очки";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(968, 87);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(39, 47);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "0";
            // 
            // labelNameMine
            // 
            this.labelNameMine.AutoSize = true;
            this.labelNameMine.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameMine.Location = new System.Drawing.Point(788, 170);
            this.labelNameMine.Name = "labelNameMine";
            this.labelNameMine.Size = new System.Drawing.Size(109, 45);
            this.labelNameMine.TabIndex = 5;
            this.labelNameMine.Text = "Мины";
            // 
            // labelMineScore
            // 
            this.labelMineScore.AutoSize = true;
            this.labelMineScore.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMineScore.Location = new System.Drawing.Point(968, 170);
            this.labelMineScore.Name = "labelMineScore";
            this.labelMineScore.Size = new System.Drawing.Size(39, 47);
            this.labelMineScore.TabIndex = 6;
            this.labelMineScore.Text = "5";
            // 
            // Saper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 795);
            this.Controls.Add(this.labelMineScore);
            this.Controls.Add(this.labelNameMine);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelNameScore);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Name = "Saper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel FlowLayoutPanel;
        private Button buttonStart;
        private Label labelNameScore;
        private Label labelScore;
        private Label labelNameMine;
        private Label labelMineScore;
    }
}