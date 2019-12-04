using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportWinApp
{
    public partial class DeparturesView : Form
    {
        private SwissTransport.ITransport transport = new SwissTransport.Transport();
        public DeparturesView()
        {
            InitializeComponent();
        }

        private void cboDepartureStation_TextUpdate(object sender, EventArgs e)
        {
            cboDepartureStation.Items.Clear();
            cboDepartureStation.SelectionStart = cboDepartureStation.Text.Length;
            cboDepartureStation.SelectionLength = 0;
            if (cboDepartureStation.Text.Length >= 3)
            {
                foreach (SwissTransport.Station station in transport.GetStations(cboDepartureStation.Text).StationList)
                {
                    if (station.Name != null)
                        cboDepartureStation.Items.Add(station.Name);
                }
            }
        }

        private void btnSearchDepartures_Click(object sender, EventArgs e)
        {
            lstDepartures.Items.Clear();
            SwissTransport.StationBoardRoot stationBoardRoot = transport.GetStationBoard("Sursee", "8502007");
            foreach (StationBoard stationBoard in transport.GetStationBoard(cboDepartureStation.Text, "").Entries) 
            { 
            lstDepartures.Items.Add(stationBoard.Name + " " + stationBoard.To);            
            }
        }

        private string getConnectionInfos(Connection connection)
        {
            string departureStation = connection.From.Station.Name;
            string departureTime = connection.From.Departure.ToString();
            string arrivalStation = connection.To.Station.Name;
            string arrivalTime = connection.To.Arrival.ToString();

            return "von: " + departureStation + "; Abfahrtszeit: " + departureTime + "; nach: " + arrivalStation + "; Ankunftszeit: " + arrivalTime;
        }
    }
}
