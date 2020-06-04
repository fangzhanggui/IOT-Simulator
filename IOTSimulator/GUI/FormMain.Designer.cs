namespace IOTSimulator
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIOTStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnectIOT = new System.Windows.Forms.Button();
            this.teDeviceID = new System.Windows.Forms.TextBox();
            this.teConnectionKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDBSetting = new System.Windows.Forms.GroupBox();
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.lbDBStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.teDBName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.teDBServerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectDB = new System.Windows.Forms.Button();
            this.teDBFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxIOTSetting = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMeasData = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxMeasDataUploadMode2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numMeasIntervalTimeMode2 = new System.Windows.Forms.NumericUpDown();
            this.btnSelectMeasDataFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.teMeasPath = new System.Windows.Forms.TextBox();
            this.btnMeasDataUploadMode2 = new System.Windows.Forms.Button();
            this.gbxMeasDataUploadMode1 = new System.Windows.Forms.GroupBox();
            this.dtpMeasEndDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpMeasStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMeasDataUploadMode1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numMeasIntervalTimeMode1 = new System.Windows.Forms.NumericUpDown();
            this.tabErrCmd = new System.Windows.Forms.TabPage();
            this.tabDueDate = new System.Windows.Forms.TabPage();
            this.tabLogFile = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lable = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkMeasIsSkipFlgMode1 = new System.Windows.Forms.CheckBox();
            this.chkMeasIsSkipFlgMode2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbxDBSetting.SuspendLayout();
            this.gbxIOTSetting.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMeasData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxMeasDataUploadMode2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasIntervalTimeMode2)).BeginInit();
            this.gbxMeasDataUploadMode1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasIntervalTimeMode1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbIOTStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnConnectIOT);
            this.groupBox1.Controls.Add(this.teDeviceID);
            this.groupBox1.Controls.Add(this.teConnectionKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IOT配置";
            // 
            // lbIOTStatus
            // 
            this.lbIOTStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIOTStatus.AutoSize = true;
            this.lbIOTStatus.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIOTStatus.ForeColor = System.Drawing.Color.Red;
            this.lbIOTStatus.Location = new System.Drawing.Point(218, 90);
            this.lbIOTStatus.Name = "lbIOTStatus";
            this.lbIOTStatus.Size = new System.Drawing.Size(31, 12);
            this.lbIOTStatus.TabIndex = 4;
            this.lbIOTStatus.Text = "离线";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "连接状态";
            // 
            // btnConnectIOT
            // 
            this.btnConnectIOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectIOT.Location = new System.Drawing.Point(348, 85);
            this.btnConnectIOT.Name = "btnConnectIOT";
            this.btnConnectIOT.Size = new System.Drawing.Size(75, 23);
            this.btnConnectIOT.TabIndex = 2;
            this.btnConnectIOT.Text = "连接";
            this.btnConnectIOT.UseVisualStyleBackColor = true;
            // 
            // teDeviceID
            // 
            this.teDeviceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teDeviceID.Location = new System.Drawing.Point(79, 47);
            this.teDeviceID.Name = "teDeviceID";
            this.teDeviceID.Size = new System.Drawing.Size(344, 21);
            this.teDeviceID.TabIndex = 1;
            // 
            // teConnectionKey
            // 
            this.teConnectionKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teConnectionKey.Location = new System.Drawing.Point(79, 19);
            this.teConnectionKey.Name = "teConnectionKey";
            this.teConnectionKey.Size = new System.Drawing.Size(344, 21);
            this.teConnectionKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接密钥";
            // 
            // gbxDBSetting
            // 
            this.gbxDBSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDBSetting.Controls.Add(this.btnConnectDB);
            this.gbxDBSetting.Controls.Add(this.lbDBStatus);
            this.gbxDBSetting.Controls.Add(this.label9);
            this.gbxDBSetting.Controls.Add(this.teDBName);
            this.gbxDBSetting.Controls.Add(this.label7);
            this.gbxDBSetting.Controls.Add(this.teDBServerName);
            this.gbxDBSetting.Controls.Add(this.label6);
            this.gbxDBSetting.Controls.Add(this.btnSelectDB);
            this.gbxDBSetting.Controls.Add(this.teDBFilePath);
            this.gbxDBSetting.Controls.Add(this.label5);
            this.gbxDBSetting.Location = new System.Drawing.Point(439, 3);
            this.gbxDBSetting.Name = "gbxDBSetting";
            this.gbxDBSetting.Size = new System.Drawing.Size(540, 113);
            this.gbxDBSetting.TabIndex = 2;
            this.gbxDBSetting.TabStop = false;
            this.gbxDBSetting.Text = "数据库配置";
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectDB.Location = new System.Drawing.Point(459, 79);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDB.TabIndex = 10;
            this.btnConnectDB.Text = "连接";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            // 
            // lbDBStatus
            // 
            this.lbDBStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDBStatus.AutoSize = true;
            this.lbDBStatus.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDBStatus.ForeColor = System.Drawing.Color.Red;
            this.lbDBStatus.Location = new System.Drawing.Point(280, 90);
            this.lbDBStatus.Name = "lbDBStatus";
            this.lbDBStatus.Size = new System.Drawing.Size(31, 12);
            this.lbDBStatus.TabIndex = 9;
            this.lbDBStatus.Text = "离线";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "连接状态";
            // 
            // teDBName
            // 
            this.teDBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teDBName.Location = new System.Drawing.Point(389, 52);
            this.teDBName.Name = "teDBName";
            this.teDBName.Size = new System.Drawing.Size(145, 21);
            this.teDBName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "数据库名称";
            // 
            // teDBServerName
            // 
            this.teDBServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teDBServerName.Location = new System.Drawing.Point(91, 53);
            this.teDBServerName.Name = "teDBServerName";
            this.teDBServerName.Size = new System.Drawing.Size(220, 21);
            this.teDBServerName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "服务器名称";
            // 
            // btnSelectDB
            // 
            this.btnSelectDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDB.Location = new System.Drawing.Point(503, 18);
            this.btnSelectDB.Name = "btnSelectDB";
            this.btnSelectDB.Size = new System.Drawing.Size(31, 21);
            this.btnSelectDB.TabIndex = 3;
            this.btnSelectDB.Text = "...";
            this.btnSelectDB.UseVisualStyleBackColor = true;
            // 
            // teDBFilePath
            // 
            this.teDBFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teDBFilePath.Location = new System.Drawing.Point(91, 19);
            this.teDBFilePath.Name = "teDBFilePath";
            this.teDBFilePath.Size = new System.Drawing.Size(406, 21);
            this.teDBFilePath.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "数据库路径";
            // 
            // gbxIOTSetting
            // 
            this.gbxIOTSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxIOTSetting.Controls.Add(this.gbxDBSetting);
            this.gbxIOTSetting.Controls.Add(this.groupBox1);
            this.gbxIOTSetting.Location = new System.Drawing.Point(12, 12);
            this.gbxIOTSetting.Name = "gbxIOTSetting";
            this.gbxIOTSetting.Size = new System.Drawing.Size(984, 122);
            this.gbxIOTSetting.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabMeasData);
            this.tabControl.Controls.Add(this.tabErrCmd);
            this.tabControl.Controls.Add(this.tabDueDate);
            this.tabControl.Controls.Add(this.tabLogFile);
            this.tabControl.Location = new System.Drawing.Point(12, 140);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 194);
            this.tabControl.TabIndex = 4;
            // 
            // tabMeasData
            // 
            this.tabMeasData.BackColor = System.Drawing.Color.Gainsboro;
            this.tabMeasData.Controls.Add(this.panel1);
            this.tabMeasData.Controls.Add(this.gbxMeasDataUploadMode2);
            this.tabMeasData.Controls.Add(this.gbxMeasDataUploadMode1);
            this.tabMeasData.Location = new System.Drawing.Point(4, 22);
            this.tabMeasData.Name = "tabMeasData";
            this.tabMeasData.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeasData.Size = new System.Drawing.Size(976, 168);
            this.tabMeasData.TabIndex = 0;
            this.tabMeasData.Text = "检测结果数据上传";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 33);
            this.panel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(13, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(491, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "特别说明:由于每日上传量有限（IOT仓库日上限为40W），单台仪器日均建议控制在1W条以内";
            // 
            // gbxMeasDataUploadMode2
            // 
            this.gbxMeasDataUploadMode2.Controls.Add(this.chkMeasIsSkipFlgMode2);
            this.gbxMeasDataUploadMode2.Controls.Add(this.label13);
            this.gbxMeasDataUploadMode2.Controls.Add(this.label14);
            this.gbxMeasDataUploadMode2.Controls.Add(this.numMeasIntervalTimeMode2);
            this.gbxMeasDataUploadMode2.Controls.Add(this.btnSelectMeasDataFile);
            this.gbxMeasDataUploadMode2.Controls.Add(this.label12);
            this.gbxMeasDataUploadMode2.Controls.Add(this.teMeasPath);
            this.gbxMeasDataUploadMode2.Controls.Add(this.btnMeasDataUploadMode2);
            this.gbxMeasDataUploadMode2.Location = new System.Drawing.Point(435, 6);
            this.gbxMeasDataUploadMode2.Name = "gbxMeasDataUploadMode2";
            this.gbxMeasDataUploadMode2.Size = new System.Drawing.Size(534, 120);
            this.gbxMeasDataUploadMode2.TabIndex = 7;
            this.gbxMeasDataUploadMode2.TabStop = false;
            this.gbxMeasDataUploadMode2.Text = "方式二：选择文件上传";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(164, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "(s)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "缓冲时间";
            // 
            // numMeasIntervalTimeMode2
            // 
            this.numMeasIntervalTimeMode2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMeasIntervalTimeMode2.Location = new System.Drawing.Point(91, 96);
            this.numMeasIntervalTimeMode2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeasIntervalTimeMode2.Name = "numMeasIntervalTimeMode2";
            this.numMeasIntervalTimeMode2.Size = new System.Drawing.Size(67, 21);
            this.numMeasIntervalTimeMode2.TabIndex = 9;
            this.numMeasIntervalTimeMode2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSelectMeasDataFile
            // 
            this.btnSelectMeasDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectMeasDataFile.Location = new System.Drawing.Point(503, 28);
            this.btnSelectMeasDataFile.Name = "btnSelectMeasDataFile";
            this.btnSelectMeasDataFile.Size = new System.Drawing.Size(31, 21);
            this.btnSelectMeasDataFile.TabIndex = 6;
            this.btnSelectMeasDataFile.Text = "...";
            this.btnSelectMeasDataFile.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "文件路径";
            this.toolTip1.SetToolTip(this.label12, "选择由[Caris200/Wan200]设备导出的CSV文件进行上传");
            // 
            // teMeasPath
            // 
            this.teMeasPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teMeasPath.Location = new System.Drawing.Point(91, 28);
            this.teMeasPath.Name = "teMeasPath";
            this.teMeasPath.Size = new System.Drawing.Size(406, 21);
            this.teMeasPath.TabIndex = 2;
            // 
            // btnMeasDataUploadMode2
            // 
            this.btnMeasDataUploadMode2.Location = new System.Drawing.Point(459, 98);
            this.btnMeasDataUploadMode2.Name = "btnMeasDataUploadMode2";
            this.btnMeasDataUploadMode2.Size = new System.Drawing.Size(75, 21);
            this.btnMeasDataUploadMode2.TabIndex = 5;
            this.btnMeasDataUploadMode2.Text = "上传";
            this.btnMeasDataUploadMode2.UseVisualStyleBackColor = true;
            // 
            // gbxMeasDataUploadMode1
            // 
            this.gbxMeasDataUploadMode1.Controls.Add(this.chkMeasIsSkipFlgMode1);
            this.gbxMeasDataUploadMode1.Controls.Add(this.dtpMeasEndDate);
            this.gbxMeasDataUploadMode1.Controls.Add(this.label15);
            this.gbxMeasDataUploadMode1.Controls.Add(this.dtpMeasStartDate);
            this.gbxMeasDataUploadMode1.Controls.Add(this.label11);
            this.gbxMeasDataUploadMode1.Controls.Add(this.btnMeasDataUploadMode1);
            this.gbxMeasDataUploadMode1.Controls.Add(this.label4);
            this.gbxMeasDataUploadMode1.Controls.Add(this.label8);
            this.gbxMeasDataUploadMode1.Controls.Add(this.numMeasIntervalTimeMode1);
            this.gbxMeasDataUploadMode1.Location = new System.Drawing.Point(6, 6);
            this.gbxMeasDataUploadMode1.Name = "gbxMeasDataUploadMode1";
            this.gbxMeasDataUploadMode1.Size = new System.Drawing.Size(423, 120);
            this.gbxMeasDataUploadMode1.TabIndex = 6;
            this.gbxMeasDataUploadMode1.TabStop = false;
            this.gbxMeasDataUploadMode1.Text = "方式一：数据库上传";
            // 
            // dtpMeasEndDate
            // 
            this.dtpMeasEndDate.Location = new System.Drawing.Point(257, 27);
            this.dtpMeasEndDate.Name = "dtpMeasEndDate";
            this.dtpMeasEndDate.Size = new System.Drawing.Size(160, 21);
            this.dtpMeasEndDate.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "-";
            this.toolTip1.SetToolTip(this.label15, "选择指定测试日期内的数据进行上传");
            // 
            // dtpMeasStartDate
            // 
            this.dtpMeasStartDate.Location = new System.Drawing.Point(73, 27);
            this.dtpMeasStartDate.Name = "dtpMeasStartDate";
            this.dtpMeasStartDate.Size = new System.Drawing.Size(160, 21);
            this.dtpMeasStartDate.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "检测日期";
            this.toolTip1.SetToolTip(this.label11, "选择指定检测日期内的数据进行上传");
            // 
            // btnMeasDataUploadMode1
            // 
            this.btnMeasDataUploadMode1.Location = new System.Drawing.Point(342, 98);
            this.btnMeasDataUploadMode1.Name = "btnMeasDataUploadMode1";
            this.btnMeasDataUploadMode1.Size = new System.Drawing.Size(75, 21);
            this.btnMeasDataUploadMode1.TabIndex = 7;
            this.btnMeasDataUploadMode1.Text = "上传";
            this.btnMeasDataUploadMode1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "缓冲时间";
            this.toolTip1.SetToolTip(this.label8, "设定每条数据上传的时间间隔，默认为1s");
            // 
            // numMeasIntervalTimeMode1
            // 
            this.numMeasIntervalTimeMode1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMeasIntervalTimeMode1.Location = new System.Drawing.Point(73, 96);
            this.numMeasIntervalTimeMode1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeasIntervalTimeMode1.Name = "numMeasIntervalTimeMode1";
            this.numMeasIntervalTimeMode1.Size = new System.Drawing.Size(67, 21);
            this.numMeasIntervalTimeMode1.TabIndex = 6;
            this.numMeasIntervalTimeMode1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabErrCmd
            // 
            this.tabErrCmd.BackColor = System.Drawing.Color.Gainsboro;
            this.tabErrCmd.Location = new System.Drawing.Point(4, 22);
            this.tabErrCmd.Name = "tabErrCmd";
            this.tabErrCmd.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrCmd.Size = new System.Drawing.Size(976, 168);
            this.tabErrCmd.TabIndex = 1;
            this.tabErrCmd.Text = "故障日志上传";
            // 
            // tabDueDate
            // 
            this.tabDueDate.BackColor = System.Drawing.Color.Gainsboro;
            this.tabDueDate.Location = new System.Drawing.Point(4, 22);
            this.tabDueDate.Name = "tabDueDate";
            this.tabDueDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDueDate.Size = new System.Drawing.Size(976, 168);
            this.tabDueDate.TabIndex = 2;
            this.tabDueDate.Text = "交期数据上传";
            // 
            // tabLogFile
            // 
            this.tabLogFile.BackColor = System.Drawing.Color.Gainsboro;
            this.tabLogFile.Location = new System.Drawing.Point(4, 22);
            this.tabLogFile.Name = "tabLogFile";
            this.tabLogFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogFile.Size = new System.Drawing.Size(976, 168);
            this.tabLogFile.TabIndex = 3;
            this.tabLogFile.Text = "系统日志上传";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 336);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(984, 379);
            this.txtLog.TabIndex = 5;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLog.Location = new System.Drawing.Point(840, 726);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 21);
            this.btnClearLog.TabIndex = 23;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // lable
            // 
            this.lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(10, 730);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(41, 12);
            this.lable.TabIndex = 24;
            this.lable.Text = "版本：";
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(48, 730);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(35, 12);
            this.lbVersion.TabIndex = 25;
            this.lbVersion.Text = "- - -";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveConfig.Location = new System.Drawing.Point(921, 726);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 21);
            this.btnSaveConfig.TabIndex = 26;
            this.btnSaveConfig.Text = "保存配置";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // chkMeasIsSkipFlgMode1
            // 
            this.chkMeasIsSkipFlgMode1.AutoSize = true;
            this.chkMeasIsSkipFlgMode1.Checked = true;
            this.chkMeasIsSkipFlgMode1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMeasIsSkipFlgMode1.Location = new System.Drawing.Point(16, 65);
            this.chkMeasIsSkipFlgMode1.Name = "chkMeasIsSkipFlgMode1";
            this.chkMeasIsSkipFlgMode1.Size = new System.Drawing.Size(156, 16);
            this.chkMeasIsSkipFlgMode1.TabIndex = 27;
            this.chkMeasIsSkipFlgMode1.Text = "是否跳过已经上传的数据";
            this.chkMeasIsSkipFlgMode1.UseVisualStyleBackColor = true;
            // 
            // chkMeasIsSkipFlgMode2
            // 
            this.chkMeasIsSkipFlgMode2.AutoSize = true;
            this.chkMeasIsSkipFlgMode2.Checked = true;
            this.chkMeasIsSkipFlgMode2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMeasIsSkipFlgMode2.Location = new System.Drawing.Point(31, 65);
            this.chkMeasIsSkipFlgMode2.Name = "chkMeasIsSkipFlgMode2";
            this.chkMeasIsSkipFlgMode2.Size = new System.Drawing.Size(156, 16);
            this.chkMeasIsSkipFlgMode2.TabIndex = 28;
            this.chkMeasIsSkipFlgMode2.Text = "是否跳过已经上传的数据";
            this.chkMeasIsSkipFlgMode2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 754);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gbxIOTSetting);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOT数据上传助手";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDBSetting.ResumeLayout(false);
            this.gbxDBSetting.PerformLayout();
            this.gbxIOTSetting.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMeasData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxMeasDataUploadMode2.ResumeLayout(false);
            this.gbxMeasDataUploadMode2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasIntervalTimeMode2)).EndInit();
            this.gbxMeasDataUploadMode1.ResumeLayout(false);
            this.gbxMeasDataUploadMode1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasIntervalTimeMode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectIOT;
        private System.Windows.Forms.TextBox teDeviceID;
        private System.Windows.Forms.TextBox teConnectionKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIOTStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDBSetting;
        private System.Windows.Forms.TextBox teDBName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teDBServerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectDB;
        private System.Windows.Forms.TextBox teDBFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.Label lbDBStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel gbxIOTSetting;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMeasData;
        private System.Windows.Forms.Button btnMeasDataUploadMode2;
        private System.Windows.Forms.TextBox teMeasPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabErrCmd;
        private System.Windows.Forms.TabPage tabDueDate;
        private System.Windows.Forms.TabPage tabLogFile;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox gbxMeasDataUploadMode2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMeasIntervalTimeMode2;
        private System.Windows.Forms.Button btnSelectMeasDataFile;
        private System.Windows.Forms.GroupBox gbxMeasDataUploadMode1;
        private System.Windows.Forms.Button btnMeasDataUploadMode1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMeasIntervalTimeMode1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpMeasEndDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpMeasStartDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkMeasIsSkipFlgMode2;
        private System.Windows.Forms.CheckBox chkMeasIsSkipFlgMode1;
    }
}

