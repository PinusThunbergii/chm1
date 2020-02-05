namespace chm1
{
    partial class MainForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diffTextBox = new System.Windows.Forms.TextBox();
            this.secondDeriveResultLabel = new System.Windows.Forms.Label();
            this.secondDeriveResultTextBox = new System.Windows.Forms.TextBox();
            this.dot5Label = new System.Windows.Forms.Label();
            this.dot5ResultTextBox = new System.Windows.Forms.TextBox();
            this.dot4Label = new System.Windows.Forms.Label();
            this.dot4ResultTextbox = new System.Windows.Forms.TextBox();
            this.toCompareTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dXTextBox = new System.Windows.Forms.TextBox();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(248, 52);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButtonHandler);
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(50, 49);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(100, 20);
            this.x0TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X0";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.label3);
            this.resultGroupBox.Controls.Add(this.diffTextBox);
            this.resultGroupBox.Controls.Add(this.secondDeriveResultLabel);
            this.resultGroupBox.Controls.Add(this.secondDeriveResultTextBox);
            this.resultGroupBox.Controls.Add(this.dot5Label);
            this.resultGroupBox.Controls.Add(this.dot5ResultTextBox);
            this.resultGroupBox.Controls.Add(this.dot4Label);
            this.resultGroupBox.Controls.Add(this.dot4ResultTextbox);
            this.resultGroupBox.Location = new System.Drawing.Point(366, 49);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(372, 242);
            this.resultGroupBox.TabIndex = 3;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "diff";
            // 
            // diffTextBox
            // 
            this.diffTextBox.Location = new System.Drawing.Point(25, 196);
            this.diffTextBox.Name = "diffTextBox";
            this.diffTextBox.Size = new System.Drawing.Size(327, 20);
            this.diffTextBox.TabIndex = 12;
            // 
            // secondDeriveResultLabel
            // 
            this.secondDeriveResultLabel.AutoSize = true;
            this.secondDeriveResultLabel.Location = new System.Drawing.Point(22, 141);
            this.secondDeriveResultLabel.Name = "secondDeriveResultLabel";
            this.secondDeriveResultLabel.Size = new System.Drawing.Size(93, 13);
            this.secondDeriveResultLabel.TabIndex = 11;
            this.secondDeriveResultLabel.Text = "Second derivative";
            // 
            // secondDeriveResultTextBox
            // 
            this.secondDeriveResultTextBox.Location = new System.Drawing.Point(25, 157);
            this.secondDeriveResultTextBox.Name = "secondDeriveResultTextBox";
            this.secondDeriveResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondDeriveResultTextBox.TabIndex = 10;
            // 
            // dot5Label
            // 
            this.dot5Label.AutoSize = true;
            this.dot5Label.Location = new System.Drawing.Point(22, 85);
            this.dot5Label.Name = "dot5Label";
            this.dot5Label.Size = new System.Drawing.Size(13, 13);
            this.dot5Label.TabIndex = 9;
            this.dot5Label.Text = "5";
            // 
            // dot5ResultTextBox
            // 
            this.dot5ResultTextBox.Location = new System.Drawing.Point(25, 111);
            this.dot5ResultTextBox.Name = "dot5ResultTextBox";
            this.dot5ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.dot5ResultTextBox.TabIndex = 8;
            // 
            // dot4Label
            // 
            this.dot4Label.AutoSize = true;
            this.dot4Label.Location = new System.Drawing.Point(22, 31);
            this.dot4Label.Name = "dot4Label";
            this.dot4Label.Size = new System.Drawing.Size(13, 13);
            this.dot4Label.TabIndex = 7;
            this.dot4Label.Text = "4";
            // 
            // dot4ResultTextbox
            // 
            this.dot4ResultTextbox.Location = new System.Drawing.Point(25, 59);
            this.dot4ResultTextbox.Name = "dot4ResultTextbox";
            this.dot4ResultTextbox.Size = new System.Drawing.Size(100, 20);
            this.dot4ResultTextbox.TabIndex = 7;
            // 
            // toCompareTextBox
            // 
            this.toCompareTextBox.Location = new System.Drawing.Point(50, 145);
            this.toCompareTextBox.Name = "toCompareTextBox";
            this.toCompareTextBox.Size = new System.Drawing.Size(100, 20);
            this.toCompareTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "analytical derivative";
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(248, 119);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(75, 23);
            this.compareButton.TabIndex = 6;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButtonHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "dX";
            // 
            // dXTextBox
            // 
            this.dXTextBox.Location = new System.Drawing.Point(50, 93);
            this.dXTextBox.Name = "dXTextBox";
            this.dXTextBox.Size = new System.Drawing.Size(100, 20);
            this.dXTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dXTextBox);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toCompareTextBox);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.TextBox toCompareTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Label dot5Label;
        private System.Windows.Forms.TextBox dot5ResultTextBox;
        private System.Windows.Forms.Label dot4Label;
        private System.Windows.Forms.TextBox dot4ResultTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dXTextBox;
        private System.Windows.Forms.Label secondDeriveResultLabel;
        private System.Windows.Forms.TextBox secondDeriveResultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diffTextBox;
    }
}