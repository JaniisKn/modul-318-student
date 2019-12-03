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
            this.lstDepartures = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboDepartureStation = new System.Windows.Forms.ComboBox();
            this.lblDepartures = new System.Windows.Forms.Label();
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
            this.btnSearchDepartures.TabIndex = 3;
            this.btnSearchDepartures.Text = "suchen";
            this.btnSearchDepartures.UseVisualStyleBackColor = false;
            this.btnSearchDepartures.Click += new System.EventHandler(this.btnSearchDepartures_Click);
            // 
            // lstDepartures
            // 
            this.lstDepartures.FormattingEnabled = true;
            this.lstDepartures.ItemHeight = 16;
            this.lstDepartures.Location = new System.Drawing.Point(12, 183);
            this.lstDepartures.Name = "lstDepartures";
            this.lstDepartures.Size = new System.Drawing.Size(958, 308);
            this.lstDepartures.TabIndex = 4;
            // 
            // cboDepartureStation
            // 
            this.cboDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureStation.FormattingEnabled = true;
            this.cboDepartureStation.Location = new System.Drawing.Point(12, 136);
            this.cboDepartureStation.Name = "cboDepartureStation";
            this.cboDepartureStation.Size = new System.Drawing.Size(746, 33);
            this.cboDepartureStation.TabIndex = 5;
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
            // DeparturesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.lblDepartures);
            this.Controls.Add(this.cboDepartureStation);
            this.Controls.Add(this.lstDepartures);
            this.Controls.Add(this.btnSearchDepartures);
            this.Name = "DeparturesView";
            this.Text = "Departures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchDepartures;
        private System.Windows.Forms.ListBox lstDepartures;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboDepartureStation;
        private System.Windows.Forms.Label lblDepartures;
    }
}