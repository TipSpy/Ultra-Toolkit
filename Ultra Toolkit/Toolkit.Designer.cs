namespace Ultra_Toolkit
{
    partial class Main
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
            this.LogRTB = new System.Windows.Forms.RichTextBox();
            this.hostname = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.rebootBTN = new System.Windows.Forms.Button();
            this.killSarOps = new System.Windows.Forms.Button();
            this.superCal = new System.Windows.Forms.Button();
            this.restartFreedompay = new System.Windows.Forms.Button();
            this.redownload = new System.Windows.Forms.Button();
            this.startExplorer = new System.Windows.Forms.Button();
            this.damewareConnect = new System.Windows.Forms.Button();
            this.getServices = new System.Windows.Forms.Button();
            this.displayMessage = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.startOps = new System.Windows.Forms.Button();
            this.serviceList = new System.Windows.Forms.DataGridView();
            this.refreshServiceList = new System.Windows.Forms.Button();
            this.stopService = new System.Windows.Forms.Button();
            this.startService = new System.Windows.Forms.Button();
            this.restartService = new System.Windows.Forms.Button();
            this.hideServicesList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.micros = new System.Windows.Forms.TabPage();
            this.gateCentral = new System.Windows.Forms.TabPage();
            this.closeGC = new System.Windows.Forms.Button();
            this.openGC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.general.SuspendLayout();
            this.micros.SuspendLayout();
            this.gateCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogRTB
            // 
            this.LogRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogRTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogRTB.Location = new System.Drawing.Point(328, 40);
            this.LogRTB.Name = "LogRTB";
            this.LogRTB.ReadOnly = true;
            this.LogRTB.Size = new System.Drawing.Size(329, 565);
            this.LogRTB.TabIndex = 999;
            this.LogRTB.TabStop = false;
            this.LogRTB.Text = "";
            // 
            // hostname
            // 
            this.hostname.Location = new System.Drawing.Point(328, 17);
            this.hostname.Name = "hostname";
            this.hostname.Size = new System.Drawing.Size(213, 20);
            this.hostname.TabIndex = 0;
            this.hostname.TextChanged += new System.EventHandler(this.hostname_TextChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.Enabled = false;
            this.connectBtn.Location = new System.Drawing.Point(547, 17);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(110, 21);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(348, 3);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(171, 13);
            this.hostnameLabel.TabIndex = 3;
            this.hostnameLabel.Text = "To begin, enter a hostname below.";
            // 
            // rebootBTN
            // 
            this.rebootBTN.Location = new System.Drawing.Point(6, 6);
            this.rebootBTN.Name = "rebootBTN";
            this.rebootBTN.Size = new System.Drawing.Size(141, 70);
            this.rebootBTN.TabIndex = 1000;
            this.rebootBTN.Text = "Reboot";
            this.rebootBTN.UseVisualStyleBackColor = true;
            this.rebootBTN.Click += new System.EventHandler(this.rebootBTN_Click);
            // 
            // killSarOps
            // 
            this.killSarOps.Location = new System.Drawing.Point(6, 6);
            this.killSarOps.Name = "killSarOps";
            this.killSarOps.Size = new System.Drawing.Size(141, 70);
            this.killSarOps.TabIndex = 1001;
            this.killSarOps.Text = "Close OPS";
            this.killSarOps.UseVisualStyleBackColor = true;
            this.killSarOps.Click += new System.EventHandler(this.killSarOps_Click);
            // 
            // superCal
            // 
            this.superCal.Location = new System.Drawing.Point(153, 82);
            this.superCal.Name = "superCal";
            this.superCal.Size = new System.Drawing.Size(140, 70);
            this.superCal.TabIndex = 1002;
            this.superCal.Text = "Launch SuperCAL";
            this.superCal.UseVisualStyleBackColor = true;
            // 
            // restartFreedompay
            // 
            this.restartFreedompay.Location = new System.Drawing.Point(152, 158);
            this.restartFreedompay.Name = "restartFreedompay";
            this.restartFreedompay.Size = new System.Drawing.Size(141, 70);
            this.restartFreedompay.TabIndex = 1003;
            this.restartFreedompay.Text = "Restart FreedomPay Service";
            this.restartFreedompay.UseVisualStyleBackColor = true;
            // 
            // redownload
            // 
            this.redownload.Location = new System.Drawing.Point(6, 82);
            this.redownload.Name = "redownload";
            this.redownload.Size = new System.Drawing.Size(141, 69);
            this.redownload.TabIndex = 1004;
            this.redownload.Text = "Re-Download";
            this.redownload.UseVisualStyleBackColor = true;
            // 
            // startExplorer
            // 
            this.startExplorer.Location = new System.Drawing.Point(6, 157);
            this.startExplorer.Name = "startExplorer";
            this.startExplorer.Size = new System.Drawing.Size(141, 70);
            this.startExplorer.TabIndex = 1005;
            this.startExplorer.Text = "Start Explorer.exe";
            this.startExplorer.UseVisualStyleBackColor = true;
            // 
            // damewareConnect
            // 
            this.damewareConnect.Location = new System.Drawing.Point(153, 6);
            this.damewareConnect.Name = "damewareConnect";
            this.damewareConnect.Size = new System.Drawing.Size(141, 70);
            this.damewareConnect.TabIndex = 1007;
            this.damewareConnect.Text = "Connect With Dameware";
            this.damewareConnect.UseVisualStyleBackColor = true;
            this.damewareConnect.Click += new System.EventHandler(this.damewareConnect_Click);
            // 
            // getServices
            // 
            this.getServices.Location = new System.Drawing.Point(6, 82);
            this.getServices.Name = "getServices";
            this.getServices.Size = new System.Drawing.Size(141, 69);
            this.getServices.TabIndex = 1008;
            this.getServices.Text = "List Services";
            this.getServices.UseVisualStyleBackColor = true;
            this.getServices.Click += new System.EventHandler(this.getServices_Click);
            // 
            // displayMessage
            // 
            this.displayMessage.Location = new System.Drawing.Point(158, 538);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(141, 22);
            this.displayMessage.TabIndex = 1009;
            this.displayMessage.Text = "Display Message";
            this.displayMessage.UseVisualStyleBackColor = true;
            this.displayMessage.Click += new System.EventHandler(this.displayMessage_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(3, 517);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(296, 20);
            this.message.TabIndex = 1010;
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(22, 543);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(122, 13);
            this.msgLabel.TabIndex = 1012;
            this.msgLabel.Text = "Enter a message above.";
            // 
            // startOps
            // 
            this.startOps.Location = new System.Drawing.Point(153, 7);
            this.startOps.Name = "startOps";
            this.startOps.Size = new System.Drawing.Size(140, 69);
            this.startOps.TabIndex = 1013;
            this.startOps.Text = "Start OPS";
            this.startOps.UseVisualStyleBackColor = true;
            // 
            // serviceList
            // 
            this.serviceList.AllowUserToAddRows = false;
            this.serviceList.AllowUserToDeleteRows = false;
            this.serviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.serviceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.serviceList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.serviceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.serviceList.Location = new System.Drawing.Point(688, 31);
            this.serviceList.Name = "serviceList";
            this.serviceList.ReadOnly = true;
            this.serviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceList.Size = new System.Drawing.Size(699, 578);
            this.serviceList.TabIndex = 1017;
            // 
            // refreshServiceList
            // 
            this.refreshServiceList.Location = new System.Drawing.Point(815, 5);
            this.refreshServiceList.Name = "refreshServiceList";
            this.refreshServiceList.Size = new System.Drawing.Size(75, 23);
            this.refreshServiceList.TabIndex = 1018;
            this.refreshServiceList.Text = "Refresh";
            this.refreshServiceList.UseVisualStyleBackColor = true;
            // 
            // stopService
            // 
            this.stopService.Location = new System.Drawing.Point(1245, 5);
            this.stopService.Name = "stopService";
            this.stopService.Size = new System.Drawing.Size(142, 23);
            this.stopService.TabIndex = 1019;
            this.stopService.Text = "Stop Selected Service";
            this.stopService.UseVisualStyleBackColor = true;
            this.stopService.Click += new System.EventHandler(this.stopService_Click);
            // 
            // startService
            // 
            this.startService.Location = new System.Drawing.Point(1097, 5);
            this.startService.Name = "startService";
            this.startService.Size = new System.Drawing.Size(142, 23);
            this.startService.TabIndex = 1020;
            this.startService.Text = "Start Selected Service";
            this.startService.UseVisualStyleBackColor = true;
            this.startService.Click += new System.EventHandler(this.startService_Click);
            // 
            // restartService
            // 
            this.restartService.Location = new System.Drawing.Point(949, 5);
            this.restartService.Name = "restartService";
            this.restartService.Size = new System.Drawing.Size(142, 23);
            this.restartService.TabIndex = 1021;
            this.restartService.Text = "Restart Selected Service";
            this.restartService.UseVisualStyleBackColor = true;
            this.restartService.Click += new System.EventHandler(this.restartService_Click);
            // 
            // hideServicesList
            // 
            this.hideServicesList.Location = new System.Drawing.Point(688, 5);
            this.hideServicesList.Name = "hideServicesList";
            this.hideServicesList.Size = new System.Drawing.Size(75, 23);
            this.hideServicesList.TabIndex = 1022;
            this.hideServicesList.Text = "<- Hide";
            this.hideServicesList.UseVisualStyleBackColor = true;
            this.hideServicesList.Click += new System.EventHandler(this.hideServicesList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.general);
            this.tabControl1.Controls.Add(this.micros);
            this.tabControl1.Controls.Add(this.gateCentral);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 596);
            this.tabControl1.TabIndex = 1023;
            // 
            // general
            // 
            this.general.Controls.Add(this.rebootBTN);
            this.general.Controls.Add(this.damewareConnect);
            this.general.Controls.Add(this.getServices);
            this.general.Controls.Add(this.message);
            this.general.Controls.Add(this.displayMessage);
            this.general.Controls.Add(this.msgLabel);
            this.general.Location = new System.Drawing.Point(4, 22);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(302, 563);
            this.general.TabIndex = 0;
            this.general.Text = "General Tools";
            this.general.UseVisualStyleBackColor = true;
            // 
            // micros
            // 
            this.micros.Controls.Add(this.killSarOps);
            this.micros.Controls.Add(this.startOps);
            this.micros.Controls.Add(this.redownload);
            this.micros.Controls.Add(this.superCal);
            this.micros.Controls.Add(this.startExplorer);
            this.micros.Controls.Add(this.restartFreedompay);
            this.micros.Location = new System.Drawing.Point(4, 22);
            this.micros.Name = "micros";
            this.micros.Padding = new System.Windows.Forms.Padding(3);
            this.micros.Size = new System.Drawing.Size(302, 563);
            this.micros.TabIndex = 1;
            this.micros.Text = "Micros Tools";
            this.micros.UseVisualStyleBackColor = true;
            // 
            // gateCentral
            // 
            this.gateCentral.Controls.Add(this.openGC);
            this.gateCentral.Controls.Add(this.closeGC);
            this.gateCentral.Location = new System.Drawing.Point(4, 22);
            this.gateCentral.Name = "gateCentral";
            this.gateCentral.Padding = new System.Windows.Forms.Padding(3);
            this.gateCentral.Size = new System.Drawing.Size(302, 570);
            this.gateCentral.TabIndex = 2;
            this.gateCentral.Text = "Gate Central Tools";
            this.gateCentral.UseVisualStyleBackColor = true;
            // 
            // closeGC
            // 
            this.closeGC.Location = new System.Drawing.Point(6, 6);
            this.closeGC.Name = "closeGC";
            this.closeGC.Size = new System.Drawing.Size(139, 69);
            this.closeGC.TabIndex = 1014;
            this.closeGC.Text = "Close GC";
            this.closeGC.UseVisualStyleBackColor = true;
            // 
            // openGC
            // 
            this.openGC.Location = new System.Drawing.Point(151, 6);
            this.openGC.Name = "openGC";
            this.openGC.Size = new System.Drawing.Size(139, 69);
            this.openGC.TabIndex = 1015;
            this.openGC.Text = "Open GC";
            this.openGC.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.hideServicesList);
            this.Controls.Add(this.restartService);
            this.Controls.Add(this.startService);
            this.Controls.Add(this.stopService);
            this.Controls.Add(this.refreshServiceList);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.hostnameLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.hostname);
            this.Controls.Add(this.LogRTB);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultra Toolkit | Idle";
            ((System.ComponentModel.ISupportInitialize)(this.serviceList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.micros.ResumeLayout(false);
            this.gateCentral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogRTB;
        private System.Windows.Forms.TextBox hostname;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.Button rebootBTN;
        private System.Windows.Forms.Button killSarOps;
        private System.Windows.Forms.Button superCal;
        private System.Windows.Forms.Button restartFreedompay;
        private System.Windows.Forms.Button redownload;
        private System.Windows.Forms.Button startExplorer;
        private System.Windows.Forms.Button damewareConnect;
        private System.Windows.Forms.Button getServices;
        private System.Windows.Forms.Button displayMessage;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button startOps;
        private System.Windows.Forms.DataGridView serviceList;
        private System.Windows.Forms.Button refreshServiceList;
        private System.Windows.Forms.Button stopService;
        private System.Windows.Forms.Button startService;
        private System.Windows.Forms.Button restartService;
        private System.Windows.Forms.Button hideServicesList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage micros;
        private System.Windows.Forms.TabPage gateCentral;
        private System.Windows.Forms.Button openGC;
        private System.Windows.Forms.Button closeGC;
    }
}

