using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFOUseExample
{
    public partial class Form1 : Form
    {

        ComputerService service;
        List<Computer> computerList = new List<Computer>(); 

        public Form1()
        {
            service = new ComputerService();
            InitializeComponent();
            BindData();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            service.AddComputer(new Computer(DistrictField.Text, typeBox.Text, (int)AmountField.Value));
            BindData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string type = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            service.DeleteComputer(type, date);
            BindData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string type = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            service.DeleteComputer(type, date);

            service.AddComputer(new Computer(DistrictField.Text, typeBox.Text, int.Parse(AmountField.Text)));
            BindData();
        }

        private void BindData()
        {
            computerList = service.GetComputers();
            var bindingList = new BindingList<Computer>(computerList);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DistrictField.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            typeBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AmountField.Value = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
