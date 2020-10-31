using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class Form1 : Form
    {

        List<string> records;
        private const string host = "127.0.0.1";
        private const int port = 8888;

        static TcpClient client;
        static NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            client = new TcpClient();
            client.Connect(host, port);
            stream = client.GetStream();
        }

        private void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
         {
            try
            {
                Connect();
            }
            catch (Exception ex) { };
            recordGrid.AutoGenerateColumns = false;
            SendRequest(Requests.GET_RECORDS);
            records = RecieveData().Split(';').ToList<string>();
            populateTable();
        }

        private string RecieveData()
        {
            try
            {
                byte[] data = new byte[4];
                stream.Read(data, 0, data.Length);
                int size = BitConverter.ToInt32(data, 0) * 2;
                data = new byte[size];

                stream.Read(data, 0, size);
                return Encoding.Unicode.GetString(data);
            }
            catch (Exception ex)
            {
                Disconnect();
                return string.Empty;
            }
        }

        private void SendRequest(string request)
        {
            byte[] data = BitConverter.GetBytes(request.Length);
            stream.Write(data, 0, data.Length);
            data = Encoding.Unicode.GetBytes(request);
            string a = Encoding.Unicode.GetString(data);
            stream.Write(data, 0, data.Length);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SendRequest(Requests.SAVE_REPORT);
            string[] rows = updateState();
            SendRequest(string.Join(";", rows));
        }

        private string[] updateState()
        {
            string[] rows = new string[recordGrid.RowCount];
            for (int i = 0; i < recordGrid.RowCount - 1; i++)
            {
                string row = "";
                for (int j = 1; j < recordGrid.ColumnCount; j++)
                {
                    if (j == 2)
                    {
                        row += ": ";
                    }
                    row += recordGrid[j, i].Value.ToString();
                }
                rows[i] = row;
            }
            records = new List<String>(rows);
            return rows;
        }

        private void populateTable()
        {
            foreach (string record in records)
            {
                if (record == null || "".Equals(record))
                {
                    continue;
                }
                int dateLength = "дд.мм.гггг".Length;
                string date = record.Substring(0, dateLength);
                string compCount = record.Substring(dateLength + 2, record.Length - (dateLength + 2));
                recordGrid.Rows.Add(false, date, compCount);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string dt = dateInput.Value.ToShortDateString();
            recordGrid.Rows.Clear();
            foreach (string record in records)
            {
                if (record == null || "".Equals(record))
                {
                    continue;
                }
                int dateLength = "дд.мм.гггг".Length;
                string date = record.Substring(0, dateLength);
                string compCount = record.Substring(dateLength + 2, record.Length - (dateLength + 2));
                if (date.Equals(dt))
                {
                    recordGrid.Rows.Add(false, date, compCount);
                }
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            recordGrid.Rows.Clear();
            populateTable();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int checkColumnId = 0;
            bool continueRemove = true;
            while (continueRemove)
            {
                continueRemove = false;
                for (int i = 0; i < recordGrid.RowCount - 1; i++)
                {
                    if ((bool)recordGrid[checkColumnId, i].Value == true)
                    {
                        recordGrid.Rows.RemoveAt(i);
                        continueRemove = true;
                        break;
                    }
                }
            }
        }

    }
}
