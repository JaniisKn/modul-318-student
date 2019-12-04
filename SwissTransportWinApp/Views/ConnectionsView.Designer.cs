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
            this.lblConnections = new System.Windows.Forms.Label();
            this.lstConnections = new System.Windows.Forms.ListView();
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTravelTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeStations = new System.Windows.Forms.Button();
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpConnections = new System.Windows.Forms.DateTimePicker();
            this.txtTimeConnections = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateTimeConnection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchConnections.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnections.Location = new System.Drawing.Point(412, 226);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(149, 43);
            this.btnSearchConnections.TabIndex = 4;
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
            this.cDate,
            this.cDepartureTime,
            this.cDepartureStation,
            this.cArrivalStation,
            this.cArrivalTime,
            this.cTravelTime,
            this.cLine});
            this.lstConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConnections.HideSelection = false;
            this.lstConnections.Location = new System.Drawing.Point(12, 304);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(958, 226);
            this.lstConnections.TabIndex = 7;
            this.lstConnections.TabStop = false;
            this.lstConnections.UseCompatibleStateImageBehavior = false;
            this.lstConnections.View = System.Windows.Forms.View.Details;
            // 
            // cDate
            // 
            this.cDate.Text = "Datum";
            this.cDate.Width = 80;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Ab";
            this.cDepartureTime.Width = 100;
            // 
            // cDepartureStation
            // 
            this.cDepartureStation.Text = "Von";
            this.cDepartureStation.Width = 150;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Nach";
            this.cArrivalStation.Width = 150;
            // 
            // cArrivalTime
            // 
            this.cArrivalTime.Text = "An";
            this.cArrivalTime.Width = 100;
            // 
            // cTravelTime
            // 
            this.cTravelTime.Text = "Reisezeit";
            this.cTravelTime.Width = 80;
            // 
            // cLine
            // 
            this.cLine.Text = "Linie";
            this.cLine.Width = 50;
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
            this.btnChangeStations.TabIndex = 5;
            this.btnChangeStations.UseVisualStyleBackColor = false;
            this.btnChangeStations.Click += new System.EventHandler(this.btnChangeStations_Click);
            // 
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataSource = typeof(SwissTransport.Connections);
            // 
            // dtpConnections
            // 
            this.dtpConnections.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpConnections.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConnections.Location = new System.Drawing.Point(355, 184);
            this.dtpConnections.Name = "dtpConnections";
            this.dtpConnections.Size = new System.Drawing.Size(132, 27);
            this.dtpConnections.TabIndex = 2;
            // 
            // txtTimeConnections
            // 
            this.txtTimeConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeConnections.Location = new System.Drawing.Point(493, 184);
            this.txtTimeConnections.Name = "txtTimeConnections";
            this.txtTimeConnections.Size = new System.Drawing.Size(119, 27);
            this.txtTimeConnections.TabIndex = 3;
            this.txtTimeConnections.Text = "HH:mm";
            this.txtTimeConnections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeConnections.TextChanged += new System.EventHandler(this.txtTimeConnections_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // lblDateTimeConnection
            // 
            this.lblDateTimeConnection.AutoSize = true;
            this.lblDateTimeConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeConnection.Location = new System.Drawing.Point(333, 161);
            this.lblDateTimeConnection.Name = "lblDateTimeConnection";
            this.lblDateTimeConnection.Size = new System.Drawing.Size(301, 20);
            this.lblDateTimeConnection.TabIndex = 13;
            this.lblDateTimeConnection.Text = "Eingabe der gewünschten Abfahrtszeit:";
            // 
            // ConnectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.lblDateTimeConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeConnections);
            this.Controls.Add(this.dtpConnections);
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
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.DateTimePicker dtpConnections;
        private System.Windows.Forms.TextBox txtTimeConnections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTimeConnection;
    }
}