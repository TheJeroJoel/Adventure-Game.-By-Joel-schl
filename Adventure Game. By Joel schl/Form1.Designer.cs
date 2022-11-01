namespace Adventure_Game.By_Joel_schl
{
    partial class AdventureGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureGameForm));
            this.Option1Button = new System.Windows.Forms.Button();
            this.Option2Button = new System.Windows.Forms.Button();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.Option2Label = new System.Windows.Forms.Label();
            this.Option1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Option1Button
            // 
            this.Option1Button.Location = new System.Drawing.Point(12, 263);
            this.Option1Button.Name = "Option1Button";
            this.Option1Button.Size = new System.Drawing.Size(90, 35);
            this.Option1Button.TabIndex = 0;
            this.Option1Button.Text = "Option 1";
            this.Option1Button.UseVisualStyleBackColor = true;
            this.Option1Button.Click += new System.EventHandler(this.Option1Button_Click);
            // 
            // Option2Button
            // 
            this.Option2Button.Location = new System.Drawing.Point(12, 320);
            this.Option2Button.Name = "Option2Button";
            this.Option2Button.Size = new System.Drawing.Size(90, 35);
            this.Option2Button.TabIndex = 1;
            this.Option2Button.Text = "Option 2";
            this.Option2Button.UseVisualStyleBackColor = true;
            this.Option2Button.Click += new System.EventHandler(this.Option2Button_Click);
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLabel.Location = new System.Drawing.Point(135, 9);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(277, 34);
            this.GameNameLabel.TabIndex = 2;
            this.GameNameLabel.Text = "Slime Adventure game";
            // 
            // OutputLabel
            // 
            this.OutputLabel.Location = new System.Drawing.Point(12, 225);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(534, 35);
            this.OutputLabel.TabIndex = 14;
            this.OutputLabel.Text = "You are a green slime going to the local convience stores";
            // 
            // ImageLabel
            // 
            this.ImageLabel.Location = new System.Drawing.Point(32, 52);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(495, 155);
            this.ImageLabel.TabIndex = 13;
            this.ImageLabel.Text = "ImageLabel";
            // 
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.Location = new System.Drawing.Point(108, 340);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(98, 13);
            this.Option2Label.TabIndex = 12;
            this.Option2Label.Text = "Go to the 2nd store";
            // 
            // Option1Label
            // 
            this.Option1Label.AutoSize = true;
            this.Option1Label.Location = new System.Drawing.Point(108, 283);
            this.Option1Label.Name = "Option1Label";
            this.Option1Label.Size = new System.Drawing.Size(94, 13);
            this.Option1Label.TabIndex = 11;
            this.Option1Label.Text = "Go to the 1st store";
            // 
            // AdventureGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 383);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.Option2Label);
            this.Controls.Add(this.Option1Label);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.Option2Button);
            this.Controls.Add(this.Option1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdventureGameForm";
            this.Text = "Adventure game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Option1Button;
        private System.Windows.Forms.Button Option2Button;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Label Option2Label;
        private System.Windows.Forms.Label Option1Label;
    }
}

