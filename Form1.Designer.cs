namespace Digital_Clock_WFA
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
            components = new System.ComponentModel.Container();
            lbl_Time = new Label();
            lbl_seconds = new Label();
            lbl_day = new Label();
            lbl_date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.BorderStyle = BorderStyle.FixedSingle;
            lbl_Time.Font = new Font("Bahnschrift SemiBold SemiConden", 80F);
            lbl_Time.ForeColor = SystemColors.ButtonHighlight;
            lbl_Time.Location = new Point(136, 107);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(273, 130);
            lbl_Time.TabIndex = 0;
            lbl_Time.Text = "22:22";
            lbl_Time.Click += label1_Click;
            // 
            // lbl_seconds
            // 
            lbl_seconds.AutoSize = true;
            lbl_seconds.BorderStyle = BorderStyle.FixedSingle;
            lbl_seconds.Font = new Font("Segoe UI", 20F);
            lbl_seconds.ForeColor = SystemColors.ButtonHighlight;
            lbl_seconds.Location = new Point(413, 183);
            lbl_seconds.Name = "lbl_seconds";
            lbl_seconds.Size = new Size(49, 39);
            lbl_seconds.TabIndex = 1;
            lbl_seconds.Text = "22";
            // 
            // lbl_day
            // 
            lbl_day.AutoSize = true;
            lbl_day.BorderStyle = BorderStyle.FixedSingle;
            lbl_day.Font = new Font("Segoe UI", 30F);
            lbl_day.ForeColor = SystemColors.ButtonHighlight;
            lbl_day.Location = new Point(413, 292);
            lbl_day.Name = "lbl_day";
            lbl_day.Size = new Size(247, 56);
            lbl_day.TabIndex = 2;
            lbl_day.Text = "Poniedziałek";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.BorderStyle = BorderStyle.FixedSingle;
            lbl_date.Font = new Font("Segoe UI", 30F);
            lbl_date.ForeColor = SystemColors.ButtonHighlight;
            lbl_date.Location = new Point(136, 292);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(234, 56);
            lbl_date.TabIndex = 3;
            lbl_date.Text = "26.Paź.2025";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_date);
            Controls.Add(lbl_day);
            Controls.Add(lbl_seconds);
            Controls.Add(lbl_Time);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Digital Clock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Time;
        private Label lbl_seconds;
        private Label lbl_day;
        private Label lbl_date;
        private System.Windows.Forms.Timer timer1;
    }
}
