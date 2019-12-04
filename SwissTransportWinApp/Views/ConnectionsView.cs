using SwissTransport;
using System;
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
        private void cboDepartureStation_TextUpdate(object sender, EventArgs e)
        {
            ClearItemsOutOfCbo(cboDepartureStation);
            AddItemsToDropdown(cboDepartureStation);
        }

        private void cboArrivalStation_TextUpdate(object sender, EventArgs e)
        {
            ClearItemsOutOfCbo(cboArrivalStation);
            AddItemsToDropdown(cboArrivalStation);
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            lstConnections.Items.Clear();
            string date = dtpConnections.Value.Year + "-" + dtpConnections.Value.Month + "-" + dtpConnections.Value.Day;
            foreach (SwissTransport.Connection connection in transport.GetConnections(cboDepartureStation.Text, cboArrivalStation.Text, date, txtTimeConnections.Text).ConnectionList) {
                lstConnections.Items.Add(ShowConnections(connection));
            }
        }

        private ListViewItem ShowConnections(Connection connection)
        {
            string[] connections = {connection.From.Departure.ToString().Substring(0,10) ,connection.From.Departure.ToString().Substring(11, 5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform};
            return new ListViewItem(connections);
        }
        private void AddItemsToDropdown(ComboBox comboBox)
        {
                comboBox.DroppedDown = true;
                foreach (SwissTransport.Station station in transport.GetStations(comboBox.Text).StationList)
                {
                    if (station.Name != null)
                        comboBox.Items.Add(station.Name);
                }
        }

        private void ClearItemsOutOfCbo(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
        }

        private void btnChangeStations_Click(object sender, EventArgs e)
        {
            string newArrivalStation = cboDepartureStation.Text;
            cboDepartureStation.Text = cboArrivalStation.Text;
            cboArrivalStation.Text = newArrivalStation;
            ClearItemsOutOfCbo(cboDepartureStation);
            ClearItemsOutOfCbo(cboArrivalStation);
        }

        private void lstConnections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimeConnections_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
