namespace ColorManeger
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
            GreenSB = new HScrollBar();
            BlueSB = new HScrollBar();
            RedLabel = new Label();
            BlueLabel = new Label();
            GreenLabel = new Label();
            RedTB = new TextBox();
            GreenTB = new TextBox();
            BlueTB = new TextBox();
            RedSB = new HScrollBar();
            ColorInfo = new Label();
            ColorCode = new Label();
            button1 = new Button();
            button2 = new Button();
            HoshokuInfo = new Label();
            ColorLabel = new Label();
            SuspendLayout();
            // 
            // GreenSB
            // 
            GreenSB.Location = new Point(255, 95);
            GreenSB.Maximum = 264;
            GreenSB.Name = "GreenSB";
            GreenSB.Size = new Size(400, 26);
            GreenSB.TabIndex = 1;
            GreenSB.Scroll += GreenSB_Scroll;
            // 
            // BlueSB
            // 
            BlueSB.Location = new Point(255, 127);
            BlueSB.Maximum = 264;
            BlueSB.Name = "BlueSB";
            BlueSB.Size = new Size(400, 26);
            BlueSB.TabIndex = 2;
            BlueSB.Scroll += BlueSB_Scroll;
            // 
            // RedLabel
            // 
            RedLabel.AutoSize = true;
            RedLabel.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RedLabel.ForeColor = Color.Red;
            RedLabel.Location = new Point(63, 63);
            RedLabel.Name = "RedLabel";
            RedLabel.Size = new Size(50, 25);
            RedLabel.TabIndex = 4;
            RedLabel.Text = "Red";
            // 
            // BlueLabel
            // 
            BlueLabel.AutoSize = true;
            BlueLabel.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BlueLabel.ForeColor = Color.Blue;
            BlueLabel.Location = new Point(63, 127);
            BlueLabel.Name = "BlueLabel";
            BlueLabel.Size = new Size(54, 25);
            BlueLabel.TabIndex = 5;
            BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            GreenLabel.AutoSize = true;
            GreenLabel.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GreenLabel.ForeColor = Color.Lime;
            GreenLabel.Location = new Point(63, 95);
            GreenLabel.Name = "GreenLabel";
            GreenLabel.Size = new Size(71, 25);
            GreenLabel.TabIndex = 6;
            GreenLabel.Text = "Green";
            // 
            // RedTB
            // 
            RedTB.Location = new Point(159, 63);
            RedTB.Name = "RedTB";
            RedTB.Size = new Size(63, 27);
            RedTB.TabIndex = 7;
            RedTB.TextChanged += RedTB_TextChanged;
            // 
            // GreenTB
            // 
            GreenTB.Location = new Point(159, 95);
            GreenTB.Name = "GreenTB";
            GreenTB.Size = new Size(63, 27);
            GreenTB.TabIndex = 8;
            GreenTB.TextChanged += GreenTB_TextChanged;
            // 
            // BlueTB
            // 
            BlueTB.Location = new Point(159, 127);
            BlueTB.Name = "BlueTB";
            BlueTB.Size = new Size(63, 27);
            BlueTB.TabIndex = 9;
            BlueTB.TextChanged += BlueTB_TextChanged;
            // 
            // RedSB
            // 
            RedSB.Location = new Point(255, 63);
            RedSB.Maximum = 264;
            RedSB.Name = "RedSB";
            RedSB.Size = new Size(400, 26);
            RedSB.TabIndex = 10;
            RedSB.Scroll += RedSB_Scroll_1;
            // 
            // ColorInfo
            // 
            ColorInfo.AutoSize = true;
            ColorInfo.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ColorInfo.Location = new Point(63, 189);
            ColorInfo.Name = "ColorInfo";
            ColorInfo.Size = new Size(135, 30);
            ColorInfo.TabIndex = 12;
            ColorInfo.Text = "Color Code: ";
            // 
            // ColorCode
            // 
            ColorCode.AutoSize = true;
            ColorCode.Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ColorCode.Location = new Point(197, 189);
            ColorCode.Name = "ColorCode";
            ColorCode.Size = new Size(100, 25);
            ColorCode.TabIndex = 13;
            ColorCode.Text = "#000000";
            // 
            // button1
            // 
            button1.Font = new Font("Meiryo UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(319, 189);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "copy!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Meiryo UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(319, 221);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "補色";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HoshokuInfo
            // 
            HoshokuInfo.AutoSize = true;
            HoshokuInfo.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HoshokuInfo.Location = new Point(63, 221);
            HoshokuInfo.Name = "HoshokuInfo";
            HoshokuInfo.Size = new Size(129, 30);
            HoshokuInfo.TabIndex = 16;
            HoshokuInfo.Text = "補色にする: ";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Font = new Font("Yu Gothic UI", 64F, FontStyle.Regular, GraphicsUnit.Point);
            ColorLabel.Location = new Point(419, 153);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(167, 142);
            ColorLabel.TabIndex = 11;
            ColorLabel.Text = "■";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HoshokuInfo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ColorCode);
            Controls.Add(ColorInfo);
            Controls.Add(ColorLabel);
            Controls.Add(RedSB);
            Controls.Add(BlueTB);
            Controls.Add(GreenTB);
            Controls.Add(RedTB);
            Controls.Add(GreenLabel);
            Controls.Add(BlueLabel);
            Controls.Add(RedLabel);
            Controls.Add(BlueSB);
            Controls.Add(GreenSB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private HScrollBar GreenSB;
        private HScrollBar BlueSB;
        private Label RedLabel;
        private Label BlueLabel;
        private Label GreenLabel;
        private TextBox RedTB;
        private TextBox GreenTB;
        private TextBox BlueTB;
        private HScrollBar RedSB;
        private Label ColorInfo;
        private Label ColorCode;
        private Button button1;
        private Button button2;
        private Label HoshokuInfo;
        private Label ColorLabel;
    }
}