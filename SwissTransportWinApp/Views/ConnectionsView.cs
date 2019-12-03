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
        private SwissTransport.ITransport transport = new SwissTransport.Transport();
        public ConnectionsView()
        {
            InitializeComponent();
        }

        private void ConnectionsView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            lstConnections.Items.Clear();
            //SwissTransport.Connections connections = new SwissTransport.Connections();
            //connections.ConnectionList = transport.GetConnections(txtDepartureStation.Text, txtArrivalStation.Text).ConnectionList;
            foreach (SwissTransport.Connection connection in transport.GetConnections(cboDepartureStation.Text, cboArrivalStation.Text).ConnectionList) {
                lstConnections.Items.Add(getConnectionInfos(connection));
            }
        }

        private string getConnectionInfos(SwissTransport.Connection connection)
        {
            string departureStation = connection.From.Station.Name;
            string departureTime = connection.From.Departure;
            string arrivalStation = connection.To.Station.Name;
            string arrivalTime = connection.To.Arrival;

            return "von: " + departureStation + "; Abfahrtszeit: " + departureTime + "; nach: " + arrivalStation + "; Ankunftszeit: " + arrivalTime;
        }

        private void cboDepartureStation_TextChanged(object sender, EventArgs e)
        {
            //cboDepartureStation.Items.Clear();
            //cboArrivalStation.SelectionStart = cboArrivalStation.Text.Length;
            if (cboDepartureStation.Text.Length > 3)
            {
                foreach (SwissTransport.Station station in transport.GetStations(cboDepartureStation.Text).StationList)
                {
                    if (station != null) { 
                        cboDepartureStation.Items.Add(station.Name);
                    }
                }
            }
        }

        private void cboArrivalStation_TextChanged(object sender, EventArgs e)
        {
            if (cboArrivalStation.Text.Length > 3)
            {
                foreach (SwissTransport.Station station in transport.GetStations(cboArrivalStation.Text).StationList)
                {
                    cboArrivalStation.Items.Add(station.Name);
                }
            }
        }
    }
}
