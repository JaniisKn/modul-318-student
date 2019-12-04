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
            cboDepartureStation.DroppedDown = true;
            cboDepartureStation.BackColor = SystemColors.Window;
                foreach (SwissTransport.Station station in transport.GetStations(cboDepartureStation.Text).StationList)
                {
                    if (station.Name != null)
                        cboDepartureStation.Items.Add(station.Name);
                }
        }

        private void btnSearchDepartures_Click(object sender, EventArgs e)
        {
            lstvDepartures.Items.Clear();
            if (IsStationGiven()) {            
            foreach (StationBoard stationBoard in transport.GetStationBoard(cboDepartureStation.Text, "").Entries) 
            {
                lstvDepartures.Items.Add(ShowDepartures(stationBoard));
            }
            }
        }

        private bool IsStationGiven()
        {
            if (cboDepartureStation.Text.Length <= 0 || cboDepartureStation.Text == null)
            {
                cboDepartureStation.BackColor = Color.FromArgb(255, 92, 92);
                return false;
            }
            return true;
        }

        private ListViewItem ShowDepartures(StationBoard stationBoard)
        {
            string[] departures = { stationBoard.Stop.Departure.ToString().Substring(11,5), stationBoard.To, stationBoard.Category + stationBoard.Number};
            return new ListViewItem(departures);
        }
    }
}
