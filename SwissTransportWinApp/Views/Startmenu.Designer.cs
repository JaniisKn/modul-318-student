namespace SwissTransportWinApp
{
    partial class StartMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoToConnection = new System.Windows.Forms.Button();
            this.btnGoToDepartures = new System.Windows.Forms.Button();
            this.lblTitleStartmenu = new System.Windows.Forms.Label();
            this.pctConnections = new System.Windows.Forms.PictureBox();
            this.pctDepartures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDepartures)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToConnection
            // 
            this.btnGoToConnection.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoToConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToConnection.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToConnection.Location = new System.Drawing.Point(107, 331);
            this.btnGoToConnection.Name = "btnGoToConnection";
            this.btnGoToConnection.Size = new System.Drawing.Size(269, 93);
            this.btnGoToConnection.TabIndex = 3;
            this.btnGoToConnection.Text = "Nach Verbindungen suchen";
            this.btnGoToConnection.UseVisualStyleBackColor = false;
            this.btnGoToConnection.Click += new System.EventHandler(this.btnGoToConnection_Click_1);
            // 
            // btnGoToDepartures
            // 
            this.btnGoToDepartures.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoToDepartures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToDepartures.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDepartures.Location = new System.Drawing.Point(588, 331);
            this.btnGoToDepartures.Name = "btnGoToDepartures";
            this.btnGoToDepartures.Size = new System.Drawing.Size(269, 93);
            this.btnGoToDepartures.TabIndex = 4;
            this.btnGoToDepartures.Text = "Nach Abfahrten suchen";
            this.btnGoToDepartures.UseVisualStyleBackColor = false;
            this.btnGoToDepartures.Click += new System.EventHandler(this.btnGoToDepartures_Click_1);
            // 
            // lblTitleStartmenu
            // 
            this.lblTitleStartmenu.AutoSize = true;
            this.lblTitleStartmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitleStartmenu.Location = new System.Drawing.Point(233, 41);
            this.lblTitleStartmenu.Name = "lblTitleStartmenu";
            this.lblTitleStartmenu.Size = new System.Drawing.Size(434, 48);
            this.lblTitleStartmenu.TabIndex = 6;
            this.lblTitleStartmenu.Text = "Was möchtest du tun?";
            // 
            // pctConnections
            // 
            this.pctConnections.Image = global::SwissTransportWinApp.Properties.Resources.AnachBklein;
            this.pctConnections.Location = new System.Drawing.Point(127, 148);
            this.pctConnections.Name = "pctConnections";
            this.pctConnections.Size = new System.Drawing.Size(227, 177);
            this.pctConnections.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctConnections.TabIndex = 7;
            this.pctConnections.TabStop = false;
            // 
            // pctDepartures
            // 
            this.pctDepartures.Image = global::SwissTransportWinApp.Properties.Resources.iconBhfTafelKlein;
            this.pctDepartures.Location = new System.Drawing.Point(609, 148);
            this.pctDepartures.Name = "pctDepartures";
            this.pctDepartures.Size = new System.Drawing.Size(227, 177);
            this.pctDepartures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctDepartures.TabIndex = 8;
            this.pctDepartures.TabStop = false;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.pctDepartures);
            this.Controls.Add(this.pctConnections);
            this.Controls.Add(this.lblTitleStartmenu);
            this.Controls.Add(this.btnGoToDepartures);
            this.Controls.Add(this.btnGoToConnection);
            this.Name = "StartMenu";
            this.Text = "Auswahl treffen";
            ((System.ComponentModel.ISupportInitialize)(this.pctConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDepartures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToConnection;
        private System.Windows.Forms.Button btnGoToDepartures;
        private System.Windows.Forms.Label lblTitleStartmenu;
        private System.Windows.Forms.PictureBox pctConnections;
        private System.Windows.Forms.PictureBox pctDepartures;
    }
}

