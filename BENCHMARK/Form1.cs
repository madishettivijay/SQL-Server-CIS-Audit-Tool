using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BENCHMARK
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        private BackgroundWorker myWorker = new BackgroundWorker();
        private string Server;

        // FORM
        public Form1()
        {
            InitializeComponent();
            myWorker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            myWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            myWorker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
            myWorker.WorkerReportsProgress = true;
            myWorker.WorkerSupportsCancellation = true;
        }

        private int PerformHeavyOperation(int i)
        {
            System.Threading.Thread.Sleep(250);
            return i * 1000;
        }

        // SCAN BUTTON CLICK EVENT
        private void Scan(object sender, EventArgs e)
        {
            Server = comboBox1.Text;
            STOP.Visible = true;
            scan.Visible = false;
            if (!myWorker.IsBusy)
            {
                myWorker.RunWorkerAsync();//Call the background worker
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            STOP.Visible = false;
            scan.Visible = true;
            comboBox1.Enabled = true;
            UNAME.Enabled = true;
            PASSWORD.Enabled = true;
            HOST.Enabled = true;
            progressBar1.Value = 0;
            myWorker.CancelAsync();//Issue a cancellation request to stop the background worker
        }

        // PROCESSING BACKGROUND WORKER
        protected void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker sendingWorker = (BackgroundWorker)sender;//Capture the BackgroundWorker that fired the event
            if (Validate() == true)
            {
                if (CheckCon() == true)
                {
                    var dt = new DataTable();

                    dt.Columns.Add("S.NO", typeof(string));
                    dt.Columns.Add("CONTROL", typeof(string));
                    dt.Columns.Add("STATUS", typeof(string));
                    string ConString =
        "Data Source=" + HOST.Text + ";" +
        "Initial Catalog=master;" +
        "User id=" + UNAME.Text + ";" +
        "Password=" + PASSWORD.Text + ";";
                    using (SqlConnection con = new SqlConnection(ConString))
                    {
                        using (dbconn db = new dbconn())
                        {
                            var Count = db.DATA_TABLE.Where(x => x.COMMAND != null).Count();
                            var model = (from S in db.DATA_TABLE
                                         where S.SERVER == Server
                                         select new
                                         {
                                             CONTROL = S.CONTROL,
                                             COMMAND = S.COMMAND,
                                             VALUE_CON = S.VALUE_CONFIGURED,
                                             VALUE_USED = S.VALUE_IN_USE,
                                             SONO = S.SNO
                                         }).ToList();
                            int Total = Convert.ToInt32(Count);
                            foreach (var item in model)
                            {
                                if (!sendingWorker.CancellationPending)
                                {
                                    if (item.COMMAND != null)
                                    {
                                        var ds = new DataSet();
                                        var cmd = new SqlCommand(item.COMMAND, con);
                                        using (var da = new SqlDataAdapter(cmd))
                                        {
                                            da.Fill(ds);
                                            DataRow dr = dt.NewRow();
                                            dr[0] = item.SONO;
                                            dr[1] = item.CONTROL;
                                            try
                                            {
                                                if (ds.Tables[0].Rows[0][1].ToString() != null || ds.Tables[0].Rows[0][2].ToString() != null)
                                                {
                                                    try
                                                    {
                                                        if (item.VALUE_CON == Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString()))
                                                        {
                                                            if (item.VALUE_USED == Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString()))
                                                            {
                                                                dr[2] = "PASS";
                                                            }
                                                        }
                                                        else
                                                        {
                                                            dr[2] = "FAIL";
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        dr[2] = "PASS";
                                                    }
                                                }
                                                else
                                                {
                                                    dr[2] = "PASS";
                                                }
                                            }
                                            catch
                                            {
                                                dr[2] = "FAIL";
                                            }
                                            dt.Rows.Add(dr);
                                        }
                                    }

                                    int percentage = (dt.Rows.Count) * 100 / Total;
                                    myWorker.ReportProgress(percentage);  // use not myBGWorker but worker from sender
                                }
                                else
                                {
                                    e.Cancel = true;//If a cancellation request is pending,assgine this flag a value of true
                                    break;// If a cancellation request is pending, break to exit the loop
                                }
                            }

                            e.Result = dt;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            else
            {
            }
        }

        //WORK PROGRESS CHANGED
        protected void myWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        //WORK PROGRESS COMPLETED
        protected void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled &&
          e.Error == null)//Check if the worker has been canceled or if an error occurred
            {
                dataGridView1.DataSource = e.Result;
                STOP.Visible = false;
                scan.Visible = true;
                if (e.Result != null)
                {
                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[1].Width = 600;
                    dataGridView1.Columns[2].Width = 100;
                }
            }
            else if (e.Cancelled)
            {
                progressBar1.Value = 0;
            }
        }

        //VALIDATING FIELDS
        public new bool Validate()
        {
            if (string.IsNullOrEmpty(HOST.Text))
            {
                MessageBox.Show("Enter Hostname"); return false;
            }
            else if (string.IsNullOrEmpty(UNAME.Text))
            {
                MessageBox.Show("Enter Username"); return false;
            }
            else if (string.IsNullOrEmpty(PASSWORD.Text))
            {
                MessageBox.Show("Enter Username"); return false;
            }
            else
            {
                return true;
            }
        }

        //CHECK CONNECTIVITY
        public bool CheckCon()
        {
            try
            {
                using (var conn = new SqlConnection())
                {
                    conn.ConnectionString =
"Data Source=" + HOST.Text + ";" +
"Initial Catalog=master;" +
"User id=" + UNAME.Text + ";" +
"Password=" + PASSWORD.Text + ";";
                    conn.Open();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}