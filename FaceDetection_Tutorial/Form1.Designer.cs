using System;

namespace FaceDetection_Tutorial
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
            this.WebcamBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrainButton = new System.Windows.Forms.Button();
            this.PredictButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SquareButton = new System.Windows.Forms.Button();
            this.EyeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WebcamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WebcamBox
            // 
            this.WebcamBox.Location = new System.Drawing.Point(3, 38);
            this.WebcamBox.Name = "WebcamBox";
            this.WebcamBox.Size = new System.Drawing.Size(855, 650);
            this.WebcamBox.TabIndex = 0;
            this.WebcamBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webcam";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(885, 67);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(288, 22);
            this.IDBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your ID";
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(885, 116);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(288, 44);
            this.TrainButton.TabIndex = 4;
            this.TrainButton.Text = "Begin Training";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // PredictButton
            // 
            this.PredictButton.Location = new System.Drawing.Point(885, 603);
            this.PredictButton.Name = "PredictButton";
            this.PredictButton.Size = new System.Drawing.Size(288, 44);
            this.PredictButton.TabIndex = 5;
            this.PredictButton.Text = "Predict Face";
            this.PredictButton.UseVisualStyleBackColor = true;
            this.PredictButton.Click += new System.EventHandler(this.PredictButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(885, 248);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(288, 239);
            this.OutputBox.TabIndex = 6;
            this.OutputBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output";
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(885, 506);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(133, 44);
            this.SquareButton.TabIndex = 8;
            this.SquareButton.Text = "Face Square: Off";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // EyeButton
            // 
            this.EyeButton.Location = new System.Drawing.Point(1040, 506);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(133, 44);
            this.EyeButton.TabIndex = 9;
            this.EyeButton.Text = "Eye Squares: Off";
            this.EyeButton.UseVisualStyleBackColor = true;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 700);
            this.Controls.Add(this.EyeButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.PredictButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebcamBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WebcamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WebcamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button PredictButton;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button EyeButton;
    }
}

