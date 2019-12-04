namespace SwissTransportWinApp
{
    partial class DeparturesView
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
            this.btnSearchDepartures = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboDepartureStation = new System.Windows.Forms.ComboBox();
            this.lblDepartures = new System.Windows.Forms.Label();
            this.lstvDepartures = new System.Windows.Forms.ListView();
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSearchDepartures
            // 
            this.btnSearchDepartures.BackColor = System.Drawing.Color.LightGray;
            this.btnSearchDepartures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchDepartures.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDepartures.Location = new System.Drawing.Point(764, 130);
            this.btnSearchDepartures.Name = "btnSearchDepartures";
            this.btnSearchDepartures.Size = new System.Drawing.Size(206, 43);
            this.btnSearchDepartures.TabIndex = 1;
            this.btnSearchDepartures.Text = "suchen";
            this.btnSearchDepartures.UseVisualStyleBackColor = false;
            this.btnSearchDepartures.Click += new System.EventHandler(this.btnSearchDepartures_Click);
            // 
            // cboDepartureStation
            // 
            this.cboDepartureStation.BackColor = System.Drawing.SystemColors.Window;
            this.cboDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureStation.FormattingEnabled = true;
            this.cboDepartureStation.Location = new System.Drawing.Point(12, 136);
            this.cboDepartureStation.Name = "cboDepartureStation";
            this.cboDepartureStation.Size = new System.Drawing.Size(746, 33);
            this.cboDepartureStation.TabIndex = 0;
            this.cboDepartureStation.TextUpdate += new System.EventHandler(this.cboDepartureStation_TextUpdate);
            // 
            // lblDepartures
            // 
            this.lblDepartures.AutoSize = true;
            this.lblDepartures.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblDepartures.Location = new System.Drawing.Point(86, 35);
            this.lblDepartures.Name = "lblDepartures";
            this.lblDepartures.Size = new System.Drawing.Size(779, 48);
            this.lblDepartures.TabIndex = 6;
            this.lblDepartures.Text = "Die nächsten Verbindungen einer Station";
            // 
            // lstvDepartures
            // 
            this.lstvDepartures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepartureTime,
            this.cArrivalStation,
            this.cLine});
            this.lstvDepartures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDepartures.HideSelection = false;
            this.lstvDepartures.Location = new System.Drawing.Point(12, 179);
            this.lstvDepartures.Name = "lstvDepartures";
            this.lstvDepartures.Size = new System.Drawing.Size(958, 299);
            this.lstvDepartures.TabIndex = 2;
            this.lstvDepartures.UseCompatibleStateImageBehavior = false;
            this.lstvDepartures.View = System.Windows.Forms.View.Details;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Abfahrtszeit";
            this.cDepartureTime.Width = 140;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Nach";
            this.cArrivalStation.Width = 180;
            // 
            // cLine
            // 
            this.cLine.Text = "Linie";
            this.cLine.Width = 100;
            // 
            // DeparturesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.lstvDepartures);
            this.Controls.Add(this.lblDepartures);
            this.Controls.Add(this.cboDepartureStation);
            this.Controls.Add(this.btnSearchDepartures);
            this.Name = "DeparturesView";
            this.Text = "Departures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchDepartures;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboDepartureStation;
        private System.Windows.Forms.Label lblDepartures;
        private System.Windows.Forms.ListView lstvDepartures;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cArrivalStation;
        private System.Windows.Forms.ColumnHeader cLine;
    }
}