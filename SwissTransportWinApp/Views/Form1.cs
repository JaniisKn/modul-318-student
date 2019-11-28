using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportWinApp
{
    public partial class SelectionMenu : Form
    {
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void btnGoToConnection_Click(object sender, EventArgs e)
        {
            ConnectionsView connectionsView = new ConnectionsView();
            connectionsView.ShowDialog();
        }

        private void btnGoToDepartures_Click(object sender, EventArgs e)
        {
            DeparturesView departuresView = new DeparturesView();
            departuresView.ShowDialog();
        }
    }
}
