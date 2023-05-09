namespace Kitayskaya_prerepreva
{
    partial class MainForm
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
            lbLeftBeach = new ListBox();
            lbBoat = new ListBox();
            lbRightBeach = new ListBox();
            btnBoatToRight = new Button();
            btnLeftToBoat = new Button();
            btnBoatToLeft = new Button();
            btnRightToBoat = new Button();
            lError = new Label();
            SuspendLayout();
            // 
            // lbLeftBeach
            // 
            lbLeftBeach.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbLeftBeach.FormattingEnabled = true;
            lbLeftBeach.ItemHeight = 35;
            lbLeftBeach.Location = new Point(51, 65);
            lbLeftBeach.Name = "lbLeftBeach";
            lbLeftBeach.Size = new Size(156, 284);
            lbLeftBeach.TabIndex = 0;
            // 
            // lbBoat
            // 
            lbBoat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbBoat.FormattingEnabled = true;
            lbBoat.ItemHeight = 35;
            lbBoat.Location = new Point(313, 172);
            lbBoat.Name = "lbBoat";
            lbBoat.Size = new Size(159, 74);
            lbBoat.TabIndex = 1;
            // 
            // lbRightBeach
            // 
            lbRightBeach.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbRightBeach.FormattingEnabled = true;
            lbRightBeach.ItemHeight = 35;
            lbRightBeach.Location = new Point(578, 65);
            lbRightBeach.Name = "lbRightBeach";
            lbRightBeach.Size = new Size(159, 284);
            lbRightBeach.TabIndex = 2;
            // 
            // btnBoatToRight
            // 
            btnBoatToRight.Location = new Point(478, 177);
            btnBoatToRight.Name = "btnBoatToRight";
            btnBoatToRight.Size = new Size(94, 29);
            btnBoatToRight.TabIndex = 3;
            btnBoatToRight.Text = ">>";
            btnBoatToRight.UseVisualStyleBackColor = true;
            btnBoatToRight.Click += btnBoatToRight_Click;
            // 
            // btnLeftToBoat
            // 
            btnLeftToBoat.Location = new Point(213, 177);
            btnLeftToBoat.Name = "btnLeftToBoat";
            btnLeftToBoat.Size = new Size(94, 29);
            btnLeftToBoat.TabIndex = 4;
            btnLeftToBoat.Text = ">>";
            btnLeftToBoat.UseVisualStyleBackColor = true;
            btnLeftToBoat.Click += btnLeftToBoat_Click;
            // 
            // btnBoatToLeft
            // 
            btnBoatToLeft.Location = new Point(213, 212);
            btnBoatToLeft.Name = "btnBoatToLeft";
            btnBoatToLeft.Size = new Size(94, 29);
            btnBoatToLeft.TabIndex = 5;
            btnBoatToLeft.Text = "<<";
            btnBoatToLeft.UseVisualStyleBackColor = true;
            btnBoatToLeft.Click += btnBoatToLeft_Click;
            // 
            // btnRightToBoat
            // 
            btnRightToBoat.Enabled = false;
            btnRightToBoat.Location = new Point(478, 212);
            btnRightToBoat.Name = "btnRightToBoat";
            btnRightToBoat.Size = new Size(94, 29);
            btnRightToBoat.TabIndex = 6;
            btnRightToBoat.Text = "<<";
            btnRightToBoat.UseVisualStyleBackColor = true;
            btnRightToBoat.Click += btnRightToBoat_Click;
            // 
            // lError
            // 
            lError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lError.ForeColor = Color.DarkRed;
            lError.Location = new Point(213, 144);
            lError.Name = "lError";
            lError.Size = new Size(359, 25);
            lError.TabIndex = 7;
            lError.Text = "lError";
            lError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lError);
            Controls.Add(btnRightToBoat);
            Controls.Add(btnBoatToLeft);
            Controls.Add(btnLeftToBoat);
            Controls.Add(btnBoatToRight);
            Controls.Add(lbRightBeach);
            Controls.Add(lbBoat);
            Controls.Add(lbLeftBeach);
            Name = "MainForm";
            Text = "Kitayskaya 穿越";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbLeftBeach;
        private ListBox lbBoat;
        private ListBox lbRightBeach;
        private Button btnBoatToRight;
        private Button btnLeftToBoat;
        private Button btnBoatToLeft;
        private Button btnRightToBoat;
        private Label lError;
    }
}