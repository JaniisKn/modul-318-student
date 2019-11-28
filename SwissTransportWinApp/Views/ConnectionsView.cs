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
    public partial class ConnectionsView : Form
    {
        private SwissTransport. ITransport transport;
        public ConnectionsView()
        {
            InitializeComponent();
        }

        private void ConnectionsView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            transport = new SwissTransport.Transport();
            //SwissTransport.Connections connections = new SwissTransport.Connections();
            //connections.ConnectionList = transport.GetConnections(txtDepartureStation.Text, txtArrivalStation.Text).ConnectionList;
            foreach (SwissTransport.Connection connection in transport.GetConnections(txtDepartureStation.Text, txtArrivalStation.Text).ConnectionList) {
            lstConnections.Items.Add(connection.From.Station.Name);
            }
        }
    }
}
