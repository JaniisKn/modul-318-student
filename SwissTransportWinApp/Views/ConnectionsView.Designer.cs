namespace SwissTransportWinApp
{
    partial class ConnectionsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.cboDepartureStation = new System.Windows.Forms.ComboBox();
            this.cboArrivalStation = new System.Windows.Forms.ComboBox();
            this.btnChangeStations = new System.Windows.Forms.Button();
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblConnections = new System.Windows.Forms.Label();
            this.lstConnections = new System.Windows.Forms.ListView();
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTravelTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchConnections.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnections.Location = new System.Drawing.Point(416, 174);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(149, 43);
            this.btnSearchConnections.TabIndex = 2;
            this.btnSearchConnections.Text = "suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = false;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // cboDepartureStation
            // 
            this.cboDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureStation.FormattingEnabled = true;
            this.cboDepartureStation.Location = new System.Drawing.Point(12, 117);
            this.cboDepartureStation.Name = "cboDepartureStation";
            this.cboDepartureStation.Size = new System.Drawing.Size(420, 33);
            this.cboDepartureStation.TabIndex = 0;
            this.cboDepartureStation.TextUpdate += new System.EventHandler(this.cboDepartureStation_TextUpdate);
            // 
            // cboArrivalStation
            // 
            this.cboArrivalStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArrivalStation.FormattingEnabled = true;
            this.cboArrivalStation.Location = new System.Drawing.Point(550, 117);
            this.cboArrivalStation.Name = "cboArrivalStation";
            this.cboArrivalStation.Size = new System.Drawing.Size(420, 33);
            this.cboArrivalStation.TabIndex = 1;
            this.cboArrivalStation.TextUpdate += new System.EventHandler(this.cboArrivalStation_TextUpdate);
            // 
            // btnChangeStations
            // 
            this.btnChangeStations.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeStations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeStations.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStations.Image = global::SwissTransportWinApp.Properties.Resources.changeStations2;
            this.btnChangeStations.Location = new System.Drawing.Point(447, 108);
            this.btnChangeStations.Name = "btnChangeStations";
            this.btnChangeStations.Size = new System.Drawing.Size(86, 48);
            this.btnChangeStations.TabIndex = 3;
            this.btnChangeStations.UseVisualStyleBackColor = false;
            this.btnChangeStations.Click += new System.EventHandler(this.btnChangeStations_Click);
            // 
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataSource = typeof(SwissTransport.Connections);
            // 
            // lblConnections
            // 
            this.lblConnections.AutoSize = true;
            this.lblConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblConnections.Location = new System.Drawing.Point(243, 26);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(496, 48);
            this.lblConnections.TabIndex = 5;
            this.lblConnections.Text = "ÖV Verbindungen suchen";
            // 
            // lstConnections
            // 
            this.lstConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepartureTime,
            this.cDepartureStation,
            this.cArrivalStation,
            this.cArrivalTime,
            this.cTravelTime,
            this.cLine});
            this.lstConnections.HideSelection = false;
            this.lstConnections.Location = new System.Drawing.Point(12, 241);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(958, 289);
            this.lstConnections.TabIndex = 7;
            this.lstConnections.UseCompatibleStateImageBehavior = false;
            this.lstConnections.View = System.Windows.Forms.View.Details;
            this.lstConnections.SelectedIndexChanged += new System.EventHandler(this.lstConnections_SelectedIndexChanged);
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Abfahrtszeit";
            this.cDepartureTime.Width = 140;
            // 
            // cDepartureStation
            // 
            this.cDepartureStation.Text = "Von";
            this.cDepartureStation.Width = 180;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Nach";
            this.cArrivalStation.Width = 180;
            // 
            // cArrivalTime
            // 
            this.cArrivalTime.Text = "Ankunftszeit";
            this.cArrivalTime.Width = 140;
            // 
            // cTravelTime
            // 
            this.cTravelTime.Text = "Reisezeit";
            this.cTravelTime.Width = 100;
            // 
            // cLine
            // 
            this.cLine.Text = "Linie";
            this.cLine.Width = 100;
            // 
            // ConnectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 641);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.btnChangeStations);
            this.Controls.Add(this.cboArrivalStation);
            this.Controls.Add(this.cboDepartureStation);
            this.Controls.Add(this.btnSearchConnections);
            this.Name = "ConnectionsView";
            this.Text = "ConnectionsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.BindingSource connectionsBindingSource;
        private System.Windows.Forms.ComboBox cboDepartureStation;
        private System.Windows.Forms.ComboBox cboArrivalStation;
        private System.Windows.Forms.Button btnChangeStations;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.ListView lstConnections;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cDepartureStation;
        private System.Windows.Forms.ColumnHeader cArrivalStation;
        private System.Windows.Forms.ColumnHeader cArrivalTime;
        private System.Windows.Forms.ColumnHeader cTravelTime;
        private System.Windows.Forms.ColumnHeader cLine;
    }
}