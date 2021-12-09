using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHouse
{
    public partial class MainForm : Form
    {

        Person currentUser = new Person();

        //public MainForm()
        //{
        //    InitializeComponent();
        //    HideSubmenues();
        //}

        public MainForm(Person currentUser)
        {
            InitializeComponent();
            HideSubmenues();

            this.currentUser = currentUser;
            lblWelcome.Text = "Welcome, " + currentUser.PersonName + "!";
        }

        private void HideSubmenues()
        {
            panelMessagesSubmenu.Visible = false;
            panelPlannerSubmenu.Visible = false;
            panelRulesSubmenu.Visible = false;
            panelUtilitiesSubmenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panelMessagesSubmenu.Visible == true)
                panelMessagesSubmenu.Visible = false;
            if (panelPlannerSubmenu.Visible == true)
                panelPlannerSubmenu.Visible = false;
            if (panelRulesSubmenu.Visible == true)
                panelRulesSubmenu.Visible = false;
            if (panelUtilitiesSubmenu.Visible == true)
                panelUtilitiesSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // Messages
        private void btnMessages_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelMessagesSubmenu);
        }

        private void btnMessageBoard_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        // Planner
        private void btnPlanner_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelPlannerSubmenu);
        }

        private void btnSeeEvents_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        // Utilities
        private void btnUtilities_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelUtilitiesSubmenu);

        }

        private void btnSeeUtilities_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnNewUtility_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        // People
        private void btnPeople_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelRulesSubmenu);
        }

        private void btnSeeTenantsRules_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnNewtenantsRule_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnSeeGeneralRules_Click(object sender, EventArgs e)
        {
            //
            HideSubmenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            HideSubmenu();
        }
    }
}
