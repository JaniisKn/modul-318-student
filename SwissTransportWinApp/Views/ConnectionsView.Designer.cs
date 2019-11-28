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
            this.txtDepartureStation = new System.Windows.Forms.TextBox();
            this.txtArrivalStation = new System.Windows.Forms.TextBox();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstConnections = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDepartureStation
            // 
            this.txtDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartureStation.Location = new System.Drawing.Point(102, 71);
            this.txtDepartureStation.Name = "txtDepartureStation";
            this.txtDepartureStation.Size = new System.Drawing.Size(231, 30);
            this.txtDepartureStation.TabIndex = 0;
            this.txtDepartureStation.Text = "Abfahrtsstation";
            // 
            // txtArrivalStation
            // 
            this.txtArrivalStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrivalStation.Location = new System.Drawing.Point(454, 71);
            this.txtArrivalStation.Name = "txtArrivalStation";
            this.txtArrivalStation.Size = new System.Drawing.Size(237, 30);
            this.txtArrivalStation.TabIndex = 1;
            this.txtArrivalStation.Text = "Ankuftsstation";
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
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataSource = typeof(SwissTransport.Connections);
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
            // ConnectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.btnSearchConnections);
            this.Controls.Add(this.txtArrivalStation);
            this.Controls.Add(this.txtDepartureStation);
            this.Name = "ConnectionsView";
            this.Text = "ConnectionsMenu";
            this.Load += new System.EventHandler(this.ConnectionsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartureStation;
        private System.Windows.Forms.TextBox txtArrivalStation;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.BindingSource connectionsBindingSource;
        private System.Windows.Forms.ListBox lstConnections;
    }
}