namespace SwissTransportWinApp
{
    partial class SelectionMenu
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
            this.SuspendLayout();
            // 
            // btnGoToConnection
            // 
            this.btnGoToConnection.BackColor = System.Drawing.Color.LightGray;
            this.btnGoToConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToConnection.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToConnection.Location = new System.Drawing.Point(89, 368);
            this.btnGoToConnection.Name = "btnGoToConnection";
            this.btnGoToConnection.Size = new System.Drawing.Size(269, 80);
            this.btnGoToConnection.TabIndex = 0;
            this.btnGoToConnection.Text = "Nach Verbindungen suchen";
            this.btnGoToConnection.UseVisualStyleBackColor = false;
            this.btnGoToConnection.Click += new System.EventHandler(this.btnGoToConnection_Click);
            // 
            // btnGoToDepartures
            // 
            this.btnGoToDepartures.BackColor = System.Drawing.Color.LightGray;
            this.btnGoToDepartures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToDepartures.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDepartures.Location = new System.Drawing.Point(461, 368);
            this.btnGoToDepartures.Name = "btnGoToDepartures";
            this.btnGoToDepartures.Size = new System.Drawing.Size(269, 80);
            this.btnGoToDepartures.TabIndex = 1;
            this.btnGoToDepartures.Text = "Nach Abfahrten suchen";
            this.btnGoToDepartures.UseVisualStyleBackColor = false;
            this.btnGoToDepartures.Click += new System.EventHandler(this.btnGoToDepartures_Click);
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 653);
            this.Controls.Add(this.btnGoToDepartures);
            this.Controls.Add(this.btnGoToConnection);
            this.Name = "SelectionMenu";
            this.Text = "Auswahl treffen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToConnection;
        private System.Windows.Forms.Button btnGoToDepartures;
    }
}

