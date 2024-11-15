namespace tictactoe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            displayturn = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 62);
            button1.Name = "button1";
            button1.Size = new Size(95, 94);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += click_event;
            // 
            // button2
            // 
            button2.Location = new Point(152, 62);
            button2.Name = "button2";
            button2.Size = new Size(95, 94);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += click_event;
            // 
            // button3
            // 
            button3.Location = new Point(253, 62);
            button3.Name = "button3";
            button3.Size = new Size(95, 94);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += click_event;
            // 
            // button4
            // 
            button4.Location = new Point(51, 162);
            button4.Name = "button4";
            button4.Size = new Size(95, 94);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += click_event;
            // 
            // button5
            // 
            button5.Location = new Point(152, 162);
            button5.Name = "button5";
            button5.Size = new Size(95, 94);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += click_event;
            // 
            // button6
            // 
            button6.Location = new Point(253, 162);
            button6.Name = "button6";
            button6.Size = new Size(95, 94);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += click_event;
            // 
            // button7
            // 
            button7.Location = new Point(51, 262);
            button7.Name = "button7";
            button7.Size = new Size(95, 94);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += click_event;
            // 
            // button8
            // 
            button8.Location = new Point(152, 262);
            button8.Name = "button8";
            button8.Size = new Size(95, 94);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += click_event;
            // 
            // button9
            // 
            button9.Location = new Point(253, 262);
            button9.Name = "button9";
            button9.Size = new Size(95, 94);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += click_event;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 73);
            label1.Name = "label1";
            label1.Size = new Size(101, 41);
            label1.TabIndex = 9;
            label1.Text = "TURN";
            // 
            // displayturn
            // 
            displayturn.AutoSize = true;
            displayturn.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            displayturn.Location = new Point(391, 140);
            displayturn.Name = "displayturn";
            displayturn.Size = new Size(0, 41);
            displayturn.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(displayturn);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label displayturn;
    }
}
