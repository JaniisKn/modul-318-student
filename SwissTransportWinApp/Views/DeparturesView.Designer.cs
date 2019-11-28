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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDepartureStation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearchDepartures
            // 
            this.btnSearchDepartures.BackColor = System.Drawing.Color.LightGray;
            this.btnSearchDepartures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchDepartures.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDepartures.Location = new System.Drawing.Point(606, 38);
            this.btnSearchDepartures.Name = "btnSearchDepartures";
            this.btnSearchDepartures.Size = new System.Drawing.Size(149, 43);
            this.btnSearchDepartures.TabIndex = 3;
            this.btnSearchDepartures.Text = "suchen";
            this.btnSearchDepartures.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(54, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(701, 292);
            this.listBox1.TabIndex = 4;
            // 
            // txtDepartureStation
            // 
            this.txtDepartureStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartureStation.Location = new System.Drawing.Point(54, 44);
            this.txtDepartureStation.Name = "txtDepartureStation";
            this.txtDepartureStation.Size = new System.Drawing.Size(510, 30);
            this.txtDepartureStation.TabIndex = 1;
            // 
            // DeparturesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearchDepartures);
            this.Controls.Add(this.txtDepartureStation);
            this.Name = "DeparturesView";
            this.Text = "Departures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchDepartures;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtDepartureStation;
    }
}