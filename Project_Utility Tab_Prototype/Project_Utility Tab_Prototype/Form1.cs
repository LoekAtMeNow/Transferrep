using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Utility_Tab_Prototype
{
    public partial class Form1 : Form
    {
        private List<List_Of_Utility> utilities=new List<List_Of_Utility>();
        public List<string> statusList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            statusList.Add("Working");
            statusList.Add("Damaged");
            statusList.Add("Broken");
            statusList.Add("In repair");
        }
        private void AddUTBTN_Click(object sender, EventArgs e)
        {
            string name=UtilityBox.Text;
            if (name == "")
            {
                MessageBox.Show("An item is required!");
            }
            else
            {
                List_Of_Utility utility = new List_Of_Utility();
                utility.Add_Utility(name);
                utilities.Add(utility);
                ShowAll();
            }
        }
        private void ShowAll()
        {
            listBox1.Items.Clear();
            foreach (List_Of_Utility utility in utilities)
            {
                listBox1.Items.Add(utility.Show_All());
            }
        }

        private void RemoveUTBTN_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i>=0)
            {
                utilities.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("An item that doesn't exist can't be removed!");
            }
            ShowAll();
        }
        private void ChangeStatus()
        {
            string iS=null;
            int iI=listBox1.SelectedIndex;
            if (iI >= 0)
            {
                if (WorkingBTN.Checked)
                {
                    iS = listBox1.SelectedIndex.ToString();
                    iS = iS + statusList[0];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                }
                else if (DamagedBTN.Checked)
                {
                    iS = listBox1.SelectedIndex.ToString();
                    iS = iS + statusList[1];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                }
                else if (BrokenBTN.Checked)
                {
                    iS = listBox1.SelectedIndex.ToString();
                    iS = iS + statusList[2];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                }
                else if (InRepairBTN.Checked)
                {
                    iS = listBox1.SelectedIndex.ToString();
                    iS = iS + statusList[3];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                }
            }
        }
        private void WorkingBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (WorkingBTN.Checked) 
            {
                string iS = null;
                int iI = listBox1.SelectedIndex;
                if (iI >= 0)
                {
                    iS = listBox1.Items[iI].ToString();
                    iS = iS + statusList[0];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                    //ColourChange();
                }
                else
                {
                    MessageBox.Show("Select an item!");
                }
            }
        }

        private void DamagedBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (DamagedBTN.Checked)
            {
                int iI = listBox1.SelectedIndex;
                string iS = listBox1.Items[iI].ToString();
                if (iI >= 0)
                {
                    iS = iS + statusList[1];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                    //ColourChange();
                }
                else
                {
                    MessageBox.Show("Select an item!");
                }
            }
        }

        private void BrokenBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (BrokenBTN.Checked)
            {
                int iI = listBox1.SelectedIndex;
                string iS = listBox1.Items[iI].ToString();
                if (iI >= 0)
                {
                    iS = iS + statusList[2];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                    //ColourChange();
                }
                else
                {
                    MessageBox.Show("Select an item!");
                }
            }
        }

        private void InRepairBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (InRepairBTN.Checked)
            {
                int iI = listBox1.SelectedIndex;
                string iS = listBox1.Items[iI].ToString();
                if (iI >= 0)
                {
                    iS = iS + statusList[3];
                    listBox1.Items.RemoveAt(iI);
                    listBox1.Items.Insert(iI, iS);
                    //ColourChange();
                }
                else
                {
                    MessageBox.Show("Select an item!");
                }
            }
        }
        /*private void ColourChange()
        {
            int i=listBox1.SelectedIndex;
            if(i >= 0)
            {
                if(WorkingBTN.Checked)
                {
                    
                    //listBox1.BackColor = Color.Green;
                }
                else if(DamagedBTN.Checked)
                {
                    //listBox1.BackColor= Color.Orange;
                }
                else if(BrokenBTN.Checked)
                {
                    //listBox1.BackColor=Color.Red;
                }
                else if(InRepairBTN.Checked)
                {
                    //listBox1.BackColor = Color.Blue;
                    //listBox1[i].BackColor = Color.Green;
                }
            }
        }
        */

        private void ReserveBTN_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i>=0)
            {

            }
            else
            {
                MessageBox.Show("Select an item!");
            }
            ShowAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text =DateTime.Now.ToLongTimeString();
            DateLabel.Text=DateTime.Now.ToLongDateString();
        }
         /* private void CheckDate()
          {
            List_Of_Utility new_date=new List_Of_Utility();
            new_date = Convert.ToString(DateLabel.Text);
          }*/
    }
}
