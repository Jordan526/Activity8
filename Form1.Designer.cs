namespace Activity_8
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
            this.fatInGramsLabel = new System.Windows.Forms.Label();
            this.carbohydrateLabel = new System.Windows.Forms.Label();
            this.userFat = new System.Windows.Forms.TextBox();
            this.userCarbs = new System.Windows.Forms.TextBox();
            this.fatButton = new System.Windows.Forms.Button();
            this.carbButton = new System.Windows.Forms.Button();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fatInGramsLabel
            // 
            this.fatInGramsLabel.AutoSize = true;
            this.fatInGramsLabel.Location = new System.Drawing.Point(112, 86);
            this.fatInGramsLabel.Name = "fatInGramsLabel";
            this.fatInGramsLabel.Size = new System.Drawing.Size(95, 13);
            this.fatInGramsLabel.TabIndex = 0;
            this.fatInGramsLabel.Text = "Enter Fat in grams:";
            // 
            // carbohydrateLabel
            // 
            this.carbohydrateLabel.AutoSize = true;
            this.carbohydrateLabel.Location = new System.Drawing.Point(112, 171);
            this.carbohydrateLabel.Name = "carbohydrateLabel";
            this.carbohydrateLabel.Size = new System.Drawing.Size(148, 13);
            this.carbohydrateLabel.TabIndex = 1;
            this.carbohydrateLabel.Text = "Enter Carbohydrates in grams:";
            // 
            // userFat
            // 
            this.userFat.Location = new System.Drawing.Point(278, 79);
            this.userFat.Name = "userFat";
            this.userFat.Size = new System.Drawing.Size(93, 20);
            this.userFat.TabIndex = 2;
            this.userFat.TextChanged += new System.EventHandler(this.userFat_TextChanged);
            // 
            // userCarbs
            // 
            this.userCarbs.Location = new System.Drawing.Point(278, 164);
            this.userCarbs.Name = "userCarbs";
            this.userCarbs.Size = new System.Drawing.Size(93, 20);
            this.userCarbs.TabIndex = 3;
            this.userCarbs.TextChanged += new System.EventHandler(this.userCarbs_TextChanged);
            // 
            // fatButton
            // 
            this.fatButton.Location = new System.Drawing.Point(22, 245);
            this.fatButton.Name = "fatButton";
            this.fatButton.Size = new System.Drawing.Size(250, 23);
            this.fatButton.TabIndex = 4;
            this.fatButton.Text = "Calculate Calories From Fat";
            this.fatButton.UseVisualStyleBackColor = true;
            this.fatButton.Click += new System.EventHandler(this.fatButton_Click);
            // 
            // carbButton
            // 
            this.carbButton.Location = new System.Drawing.Point(291, 245);
            this.carbButton.Name = "carbButton";
            this.carbButton.Size = new System.Drawing.Size(250, 23);
            this.carbButton.TabIndex = 5;
            this.carbButton.Text = "Calculate Calories From Carbohydates";
            this.carbButton.UseVisualStyleBackColor = true;
            this.carbButton.Click += new System.EventHandler(this.carbButton_Click);
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(91, 298);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(35, 13);
            this.fatLabel.TabIndex = 6;
            this.fatLabel.Text = "label1";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(355, 298);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(35, 13);
            this.carbsLabel.TabIndex = 7;
            this.carbsLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 330);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbButton);
            this.Controls.Add(this.fatButton);
            this.Controls.Add(this.userCarbs);
            this.Controls.Add(this.userFat);
            this.Controls.Add(this.carbohydrateLabel);
            this.Controls.Add(this.fatInGramsLabel);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatInGramsLabel;
        private System.Windows.Forms.Label carbohydrateLabel;
        private System.Windows.Forms.TextBox userFat;
        private System.Windows.Forms.TextBox userCarbs;
        private System.Windows.Forms.Button fatButton;
        private System.Windows.Forms.Button carbButton;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label carbsLabel;
    }
}

