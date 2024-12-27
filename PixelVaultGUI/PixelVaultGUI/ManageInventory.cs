﻿using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class ManageInventory : UserControl
    {
        Controller controller = new Controller();
        public string UserName;
        public ManageInventory()
        {

            InitializeComponent();
            DataTable dt = controller.GetInventory(UserName);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            DataTable dt = controller.GetInventory(UserName);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void AdjustPrice_Click(object sender, EventArgs e)
        {
            if(this.Visible=true)
            {
                DataTable dt = controller.GetInventory(UserName);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Refresh();
            }
            string GameName;
            float price=float.Parse(NewPrice.Text);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GameName = dataGridView1.SelectedRows[0].Cells["GameName"].Value.ToString();


                
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    int result = controller.AdjustPrice(UserName,GameName,price);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to remove Partner !");
                        return;
                    }
                    else
                    {
                        DataTable dataTable = new DataTable();
                        dataTable = controller.GetInventory(UserName);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.Refresh();

                        MessageBox.Show("Game Price Updated Successfuly !");
                        return;
                    }
                
            }
            else
            {
                MessageBox.Show("Please select a Partner to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}