using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
namespace FCFS
{
    public partial class Form1 : Form
    {
        private List<Process> processes = new List<Process>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Thiết lập cột cho DataGridView1
            dataGridView1.Columns.Add("Name", "Tên");
            dataGridView1.Columns.Add("ArrivalTime", "Thời gian đến");
            dataGridView1.Columns.Add("BurstTime", "Thời gian thực hiện");

            //Thiết lập cột cho datagridView2
            dataGridView2.Columns.Add("", "Tên");
            dataGridView2.Columns.Add("", "Thời gian bắt đầu");
            dataGridView2.Columns.Add("", "Thời gian chờ");
            dataGridView2.Columns.Add("", "Thời gian hoàn thành");
            dataGridView2.Columns.Add("", "Thời gian lưu lại");

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArrivalTime.Text) && !string.IsNullOrEmpty(txtBurstTime.Text))
            {
                int arrivalTime = Convert.ToInt32(txtArrivalTime.Text);
                int burstTime = Convert.ToInt32(txtBurstTime.Text);

                Process process = new Process
                {
                    Name = $"P{processes.Count + 1}",
                    ArrivalTime = arrivalTime,
                    BurstTime = burstTime
                };

                // Thêm tiến trình mới vào danh sách
                processes.Add(process);

                // Hiển thị thông tin tiến trình trong ListBox
                //lbProcesses.Items.Add($"{process.Name}: Thời gian vào: {arrivalTime}, Thời gian sử dụng CPU: {burstTime}");
                dataGridView1.Rows.Add(process.Name, process.ArrivalTime, process.BurstTime);
                txtArrivalTime.Text = "";
                txtBurstTime.Text = "";
                txtArrivalTime.Focus();
            }
            else
            {
                // Hiển thị thông báo nếu TextBox không chứa dữ liệu
                MessageBox.Show("Vui lòng nhập thời gian đến và thời gian thực hiện.");
            }
        }

        private void btnRunFCFS(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                // Sắp xếp tiến trình theo thời gian đến
                processes.Sort((p1, p2) => p1.ArrivalTime.CompareTo(p2.ArrivalTime));

                int totalWaitTime = 0;
                //int totalTurnaroundTime = 0;
                int currentTime = 0; // Thời gian bắt đầu dùng CPU
                //lbResult.Text = "Kết quả lịch trình FCFS:\r\n";

                foreach (var process in processes)
                {
                    if (currentTime < process.ArrivalTime)
                    {
                        currentTime = process.ArrivalTime;
                    }
                    int waitTime = currentTime - process.ArrivalTime;
                    //int turnaroundTime = waitTime + process.BurstTime;

                    totalWaitTime += waitTime;
                    //totalTurnaroundTime += turnaroundTime;
                    //lbResult.Items.Add($"{process.Name}: Thời gian bắt đầu = {currentTime}, Thời gian chờ = {waitTime}\r\n, Thời gian hoàn thành = {currentTime + process.BurstTime}\n, Thời gian lưu lại = {currentTime + process.BurstTime - process.ArrivalTime}\r\n");
                    dataGridView2.Rows.Add(process.Name, currentTime, waitTime, currentTime + process.BurstTime, currentTime + process.BurstTime - process.ArrivalTime);
                    currentTime += process.BurstTime;
                }
                // Tính thời gian chờ đợi trung bình
                double averageWaitTime = (double)totalWaitTime / processes.Count;

                //Hiển thị thời gian chờ trung bình
                tbxwait.Text = Convert.ToString(averageWaitTime);
            }
        }
    }

    public class Process
    {
        public string Name { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
    }
}