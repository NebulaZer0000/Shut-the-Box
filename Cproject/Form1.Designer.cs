namespace Cproject
{
    partial class Form1
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
            this.rollBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.num1CloseLbl = new System.Windows.Forms.Label();
            this.num1OpenLbl = new System.Windows.Forms.Label();
            this.num2OpenLbl = new System.Windows.Forms.Label();
            this.num2CloseLbl = new System.Windows.Forms.Label();
            this.num3OpenLbl = new System.Windows.Forms.Label();
            this.num3CloseLbl = new System.Windows.Forms.Label();
            this.num4OpenLbl = new System.Windows.Forms.Label();
            this.num4CloseLbl = new System.Windows.Forms.Label();
            this.num5OpenLbl = new System.Windows.Forms.Label();
            this.num5CloseLbl = new System.Windows.Forms.Label();
            this.num6OpenLbl = new System.Windows.Forms.Label();
            this.num6CloseLbl = new System.Windows.Forms.Label();
            this.num7OpenLbl = new System.Windows.Forms.Label();
            this.num7CloseLbl = new System.Windows.Forms.Label();
            this.num8OpenLbl = new System.Windows.Forms.Label();
            this.num8CloseLbl = new System.Windows.Forms.Label();
            this.num9OpenLbl = new System.Windows.Forms.Label();
            this.num9CloseLbl = new System.Windows.Forms.Label();
            this.die2Lbl = new System.Windows.Forms.Label();
            this.die1Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(448, 312);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(67, 29);
            this.rollBtn.TabIndex = 2;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(672, 312);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 29);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(90, 237);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(125, 27);
            this.num1TextBox.TabIndex = 24;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(90, 270);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(125, 27);
            this.num2TextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Number 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Number 2:";
            // 
            // submitBtn
            // 
            this.submitBtn.Enabled = false;
            this.submitBtn.Location = new System.Drawing.Point(221, 252);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(76, 29);
            this.submitBtn.TabIndex = 28;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // num1CloseLbl
            // 
            this.num1CloseLbl.AutoSize = true;
            this.num1CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num1CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1CloseLbl.Location = new System.Drawing.Point(80, 122);
            this.num1CloseLbl.Name = "num1CloseLbl";
            this.num1CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num1CloseLbl.TabIndex = 29;
            this.num1CloseLbl.Text = "1";
            this.num1CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1CloseLbl.Visible = false;
            // 
            // num1OpenLbl
            // 
            this.num1OpenLbl.AutoSize = true;
            this.num1OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num1OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1OpenLbl.Location = new System.Drawing.Point(80, 51);
            this.num1OpenLbl.Name = "num1OpenLbl";
            this.num1OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num1OpenLbl.TabIndex = 30;
            this.num1OpenLbl.Text = "1";
            this.num1OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2OpenLbl
            // 
            this.num2OpenLbl.AutoSize = true;
            this.num2OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num2OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2OpenLbl.Location = new System.Drawing.Point(144, 51);
            this.num2OpenLbl.Name = "num2OpenLbl";
            this.num2OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num2OpenLbl.TabIndex = 32;
            this.num2OpenLbl.Text = "2";
            this.num2OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2CloseLbl
            // 
            this.num2CloseLbl.AutoSize = true;
            this.num2CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num2CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2CloseLbl.Location = new System.Drawing.Point(144, 122);
            this.num2CloseLbl.Name = "num2CloseLbl";
            this.num2CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num2CloseLbl.TabIndex = 31;
            this.num2CloseLbl.Text = "2";
            this.num2CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2CloseLbl.Visible = false;
            // 
            // num3OpenLbl
            // 
            this.num3OpenLbl.AutoSize = true;
            this.num3OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num3OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num3OpenLbl.Location = new System.Drawing.Point(208, 51);
            this.num3OpenLbl.Name = "num3OpenLbl";
            this.num3OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num3OpenLbl.TabIndex = 34;
            this.num3OpenLbl.Text = "3";
            this.num3OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3CloseLbl
            // 
            this.num3CloseLbl.AutoSize = true;
            this.num3CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num3CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num3CloseLbl.Location = new System.Drawing.Point(208, 122);
            this.num3CloseLbl.Name = "num3CloseLbl";
            this.num3CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num3CloseLbl.TabIndex = 33;
            this.num3CloseLbl.Text = "3";
            this.num3CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3CloseLbl.Visible = false;
            // 
            // num4OpenLbl
            // 
            this.num4OpenLbl.AutoSize = true;
            this.num4OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num4OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num4OpenLbl.Location = new System.Drawing.Point(272, 51);
            this.num4OpenLbl.Name = "num4OpenLbl";
            this.num4OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num4OpenLbl.TabIndex = 36;
            this.num4OpenLbl.Text = "4";
            this.num4OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num4CloseLbl
            // 
            this.num4CloseLbl.AutoSize = true;
            this.num4CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num4CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num4CloseLbl.Location = new System.Drawing.Point(272, 122);
            this.num4CloseLbl.Name = "num4CloseLbl";
            this.num4CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num4CloseLbl.TabIndex = 35;
            this.num4CloseLbl.Text = "4";
            this.num4CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num4CloseLbl.Visible = false;
            // 
            // num5OpenLbl
            // 
            this.num5OpenLbl.AutoSize = true;
            this.num5OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num5OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num5OpenLbl.Location = new System.Drawing.Point(336, 51);
            this.num5OpenLbl.Name = "num5OpenLbl";
            this.num5OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num5OpenLbl.TabIndex = 38;
            this.num5OpenLbl.Text = "5";
            this.num5OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num5CloseLbl
            // 
            this.num5CloseLbl.AutoSize = true;
            this.num5CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num5CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num5CloseLbl.Location = new System.Drawing.Point(336, 122);
            this.num5CloseLbl.Name = "num5CloseLbl";
            this.num5CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num5CloseLbl.TabIndex = 37;
            this.num5CloseLbl.Text = "5";
            this.num5CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num5CloseLbl.Visible = false;
            // 
            // num6OpenLbl
            // 
            this.num6OpenLbl.AutoSize = true;
            this.num6OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num6OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num6OpenLbl.Location = new System.Drawing.Point(400, 51);
            this.num6OpenLbl.Name = "num6OpenLbl";
            this.num6OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num6OpenLbl.TabIndex = 40;
            this.num6OpenLbl.Text = "6";
            this.num6OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num6CloseLbl
            // 
            this.num6CloseLbl.AutoSize = true;
            this.num6CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num6CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num6CloseLbl.Location = new System.Drawing.Point(400, 122);
            this.num6CloseLbl.Name = "num6CloseLbl";
            this.num6CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num6CloseLbl.TabIndex = 39;
            this.num6CloseLbl.Text = "6";
            this.num6CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num6CloseLbl.Visible = false;
            // 
            // num7OpenLbl
            // 
            this.num7OpenLbl.AutoSize = true;
            this.num7OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num7OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num7OpenLbl.Location = new System.Drawing.Point(464, 51);
            this.num7OpenLbl.Name = "num7OpenLbl";
            this.num7OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num7OpenLbl.TabIndex = 42;
            this.num7OpenLbl.Text = "7";
            this.num7OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num7CloseLbl
            // 
            this.num7CloseLbl.AutoSize = true;
            this.num7CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num7CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num7CloseLbl.Location = new System.Drawing.Point(464, 122);
            this.num7CloseLbl.Name = "num7CloseLbl";
            this.num7CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num7CloseLbl.TabIndex = 41;
            this.num7CloseLbl.Text = "7";
            this.num7CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num7CloseLbl.Visible = false;
            // 
            // num8OpenLbl
            // 
            this.num8OpenLbl.AutoSize = true;
            this.num8OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num8OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num8OpenLbl.Location = new System.Drawing.Point(528, 51);
            this.num8OpenLbl.Name = "num8OpenLbl";
            this.num8OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num8OpenLbl.TabIndex = 44;
            this.num8OpenLbl.Text = "8";
            this.num8OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num8CloseLbl
            // 
            this.num8CloseLbl.AutoSize = true;
            this.num8CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num8CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num8CloseLbl.Location = new System.Drawing.Point(528, 122);
            this.num8CloseLbl.Name = "num8CloseLbl";
            this.num8CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num8CloseLbl.TabIndex = 43;
            this.num8CloseLbl.Text = "8";
            this.num8CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num8CloseLbl.Visible = false;
            // 
            // num9OpenLbl
            // 
            this.num9OpenLbl.AutoSize = true;
            this.num9OpenLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num9OpenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num9OpenLbl.Location = new System.Drawing.Point(592, 51);
            this.num9OpenLbl.Name = "num9OpenLbl";
            this.num9OpenLbl.Size = new System.Drawing.Size(51, 56);
            this.num9OpenLbl.TabIndex = 46;
            this.num9OpenLbl.Text = "9";
            this.num9OpenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num9CloseLbl
            // 
            this.num9CloseLbl.AutoSize = true;
            this.num9CloseLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num9CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num9CloseLbl.Location = new System.Drawing.Point(592, 122);
            this.num9CloseLbl.Name = "num9CloseLbl";
            this.num9CloseLbl.Size = new System.Drawing.Size(51, 56);
            this.num9CloseLbl.TabIndex = 45;
            this.num9CloseLbl.Text = "9";
            this.num9CloseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num9CloseLbl.Visible = false;
            // 
            // die2Lbl
            // 
            this.die2Lbl.AutoSize = true;
            this.die2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.die2Lbl.Location = new System.Drawing.Point(484, 228);
            this.die2Lbl.Name = "die2Lbl";
            this.die2Lbl.Size = new System.Drawing.Size(51, 56);
            this.die2Lbl.TabIndex = 48;
            this.die2Lbl.Text = "0";
            this.die2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // die1Lbl
            // 
            this.die1Lbl.AutoSize = true;
            this.die1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.die1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.die1Lbl.Location = new System.Drawing.Point(420, 228);
            this.die1Lbl.Name = "die1Lbl";
            this.die1Lbl.Size = new System.Drawing.Size(51, 56);
            this.die1Lbl.TabIndex = 47;
            this.die1Lbl.Text = "0";
            this.die1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 356);
            this.Controls.Add(this.die2Lbl);
            this.Controls.Add(this.die1Lbl);
            this.Controls.Add(this.num9OpenLbl);
            this.Controls.Add(this.num9CloseLbl);
            this.Controls.Add(this.num8OpenLbl);
            this.Controls.Add(this.num8CloseLbl);
            this.Controls.Add(this.num7OpenLbl);
            this.Controls.Add(this.num7CloseLbl);
            this.Controls.Add(this.num6OpenLbl);
            this.Controls.Add(this.num6CloseLbl);
            this.Controls.Add(this.num5OpenLbl);
            this.Controls.Add(this.num5CloseLbl);
            this.Controls.Add(this.num4OpenLbl);
            this.Controls.Add(this.num4CloseLbl);
            this.Controls.Add(this.num3OpenLbl);
            this.Controls.Add(this.num3CloseLbl);
            this.Controls.Add(this.num2OpenLbl);
            this.Controls.Add(this.num2CloseLbl);
            this.Controls.Add(this.num1OpenLbl);
            this.Controls.Add(this.num1CloseLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rollBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shut the box - Blake Green";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button rollBtn;
        private Button exitBtn;
        private TextBox num1TextBox;
        private TextBox num2TextBox;
        private Label label3;
        private Label label4;
        private Button submitBtn;
        private Label num1CloseLbl;
        private Label num1OpenLbl;
        private Label num2OpenLbl;
        private Label num2CloseLbl;
        private Label num3OpenLbl;
        private Label num3CloseLbl;
        private Label num4OpenLbl;
        private Label num4CloseLbl;
        private Label num5OpenLbl;
        private Label num5CloseLbl;
        private Label num6OpenLbl;
        private Label num6CloseLbl;
        private Label num7OpenLbl;
        private Label num7CloseLbl;
        private Label num8OpenLbl;
        private Label num8CloseLbl;
        private Label num9OpenLbl;
        private Label num9CloseLbl;
        private Label die2Lbl;
        private Label die1Lbl;
    }
}