namespace FCFS
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
            txtArrivalTime = new TextBox();
            txtBurstTime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lbProcesses = new ListBox();
            button2 = new Button();
            lbResult = new ListBox();
            label3 = new Label();
            tbxwait = new TextBox();
            SuspendLayout();
            // 
            // txtArrivalTime
            // 
            txtArrivalTime.Location = new Point(128, 90);
            txtArrivalTime.Margin = new Padding(4, 3, 4, 3);
            txtArrivalTime.Name = "txtArrivalTime";
            txtArrivalTime.Size = new Size(235, 30);
            txtArrivalTime.TabIndex = 0;
            // 
            // txtBurstTime
            // 
            txtBurstTime.Location = new Point(462, 90);
            txtBurstTime.Margin = new Padding(4, 3, 4, 3);
            txtBurstTime.Name = "txtBurstTime";
            txtBurstTime.Size = new Size(235, 30);
            txtBurstTime.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 2;
            label1.Text = "Arrival TIme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 3;
            label2.Text = "Burst Time";
            // 
            // button1
            // 
            button1.Location = new Point(802, 89);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbProcesses
            // 
            lbProcesses.FormattingEnabled = true;
            lbProcesses.ItemHeight = 23;
            lbProcesses.Location = new Point(135, 150);
            lbProcesses.Margin = new Padding(4, 3, 4, 3);
            lbProcesses.Name = "lbProcesses";
            lbProcesses.Size = new Size(784, 119);
            lbProcesses.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(724, 299);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 33);
            button2.TabIndex = 6;
            button2.Text = "RunFCFS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRunFCFS;
            // 
            // lbResult
            // 
            lbResult.FormattingEnabled = true;
            lbResult.ItemHeight = 23;
            lbResult.Location = new Point(135, 366);
            lbResult.Margin = new Padding(4, 3, 4, 3);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(784, 119);
            lbResult.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 532);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 23);
            label3.TabIndex = 2;
            label3.Text = "Thời gian chờ trung bình: ";
            // 
            // tbxwait
            // 
            tbxwait.Location = new Point(764, 529);
            tbxwait.Margin = new Padding(4, 3, 4, 3);
            tbxwait.Name = "tbxwait";
            tbxwait.ReadOnly = true;
            tbxwait.Size = new Size(155, 30);
            tbxwait.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 592);
            Controls.Add(tbxwait);
            Controls.Add(lbResult);
            Controls.Add(button2);
            Controls.Add(lbProcesses);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtBurstTime);
            Controls.Add(txtArrivalTime);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCFS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrivalTime;
        private TextBox txtBurstTime;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox lbProcesses;
        private Button button2;
        private ListBox lbResult;
        private Label label3;
        private TextBox tbxwait;
    }
}