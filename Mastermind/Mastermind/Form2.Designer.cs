namespace Mastermind
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.square4 = new System.Windows.Forms.Panel();
            this.square3 = new System.Windows.Forms.Panel();
            this.square2 = new System.Windows.Forms.Panel();
            this.square1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.square5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.square6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "The goal of mastermind is to crack a secret code.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "You have 10 attempts to crack the code.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter your guess at the bottom of the screen.";
            // 
            // square4
            // 
            this.square4.BackColor = System.Drawing.Color.Green;
            this.square4.Location = new System.Drawing.Point(284, 128);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(20, 19);
            this.square4.TabIndex = 35;
            // 
            // square3
            // 
            this.square3.BackColor = System.Drawing.Color.Green;
            this.square3.Location = new System.Drawing.Point(258, 128);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(20, 19);
            this.square3.TabIndex = 33;
            // 
            // square2
            // 
            this.square2.BackColor = System.Drawing.Color.Green;
            this.square2.Location = new System.Drawing.Point(284, 103);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(20, 19);
            this.square2.TabIndex = 34;
            // 
            // square1
            // 
            this.square1.BackColor = System.Drawing.Color.Green;
            this.square1.Location = new System.Drawing.Point(258, 103);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(20, 19);
            this.square1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "There will be 4 squares to the right of your guess:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "A black square means that the colour is correct, but the position is not.";
            // 
            // square5
            // 
            this.square5.BackColor = System.Drawing.Color.Green;
            this.square5.Location = new System.Drawing.Point(370, 174);
            this.square5.Name = "square5";
            this.square5.Size = new System.Drawing.Size(20, 19);
            this.square5.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "A red square means that the colour and the position are correct.";
            // 
            // square6
            // 
            this.square6.BackColor = System.Drawing.Color.Green;
            this.square6.Location = new System.Drawing.Point(370, 222);
            this.square6.Name = "square6";
            this.square6.Size = new System.Drawing.Size(20, 19);
            this.square6.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Hint: A black square can mean multiple of the same colour!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 309);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.square6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.square5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.square4);
            this.Controls.Add(this.square3);
            this.Controls.Add(this.square2);
            this.Controls.Add(this.square1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel square3;
        private System.Windows.Forms.Panel square2;
        private System.Windows.Forms.Panel square1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel square5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel square6;
        private System.Windows.Forms.Panel square4;
        private System.Windows.Forms.Label label7;
    }
}