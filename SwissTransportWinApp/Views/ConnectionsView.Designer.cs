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
            this.lstConnections = new System.Windows.Forms.ListBox();
            this.cboDepartureStation = new System.Windows.Forms.ComboBox();
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboArrivalStation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.BackColor = System.Drawing.Color.LightGray;
            this.btnSearchConnections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchConnections.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnections.Location = new System.Drawing.Point(316, 130);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(149, 43);
            this.btnSearchConnections.TabIndex = 2;
            this.btnSearchConnections.Text = "suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = false;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // lstConnections
            // 
            this.lstConnections.FormattingEnabled = true;
            this.lstConnections.ItemHeight = 16;
            this.lstConnections.Location = new System.Drawing.Point(12, 209);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(776, 212);
            this.lstConnections.TabIndex = 3;
            // 
            // cboDepartureStation
            // 
            this.cboDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureStation.FormattingEnabled = true;
            this.cboDepartureStation.Location = new System.Drawing.Point(87, 71);
            this.cboDepartureStation.Name = "cboDepartureStation";
            this.cboDepartureStation.Size = new System.Drawing.Size(231, 33);
            this.cboDepartureStation.TabIndex = 4;
            this.cboDepartureStation.TextChanged += new System.EventHandler(this.cboDepartureStation_TextChanged);
            // 
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataSource = typeof(SwissTransport.Connections);
            // 
            // cboArrivalStation
            // 
            this.cboArrivalStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArrivalStation.FormattingEnabled = true;
            this.cboArrivalStation.Location = new System.Drawing.Point(460, 71);
            this.cboArrivalStation.Name = "cboArrivalStation";
            this.cboArrivalStation.Size = new System.Drawing.Size(231, 33);
            this.cboArrivalStation.TabIndex = 5;
            this.cboArrivalStation.TextChanged += new System.EventHandler(this.cboArrivalStation_TextChanged);
            // 
            // ConnectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboArrivalStation);
            this.Controls.Add(this.cboDepartureStation);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.btnSearchConnections);
            this.Name = "ConnectionsView";
            this.Text = "ConnectionsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.BindingSource connectionsBindingSource;
        private System.Windows.Forms.ListBox lstConnections;
        private System.Windows.Forms.ComboBox cboDepartureStation;
        private System.Windows.Forms.ComboBox cboArrivalStation;
    }
}