namespace KeyMouse
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.speedL = new System.Windows.Forms.Label();
            this.moveL = new System.Windows.Forms.Label();
            this.moveCB = new System.Windows.Forms.ComboBox();
            this.andL = new System.Windows.Forms.Label();
            this.moveUpL = new System.Windows.Forms.Label();
            this.moveDownL = new System.Windows.Forms.Label();
            this.moveRightL = new System.Windows.Forms.Label();
            this.moveLeftL = new System.Windows.Forms.Label();
            this.applyB = new System.Windows.Forms.Button();
            this.infoL = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.leftL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spamL = new System.Windows.Forms.Label();
            this.rightTB = new System.Windows.Forms.TextBox();
            this.leftTB = new System.Windows.Forms.TextBox();
            this.moveRightTB = new System.Windows.Forms.TextBox();
            this.moveLeftTB = new System.Windows.Forms.TextBox();
            this.moveDownTB = new System.Windows.Forms.TextBox();
            this.moveUpTB = new System.Windows.Forms.TextBox();
            this.captureCB = new System.Windows.Forms.CheckBox();
            this.altCB = new System.Windows.Forms.CheckBox();
            this.shiftCB = new System.Windows.Forms.CheckBox();
            this.ctrlCB = new System.Windows.Forms.CheckBox();
            this.trayCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // speedL
            // 
            this.speedL.AutoSize = true;
            this.speedL.Location = new System.Drawing.Point(12, 13);
            this.speedL.Name = "speedL";
            this.speedL.Size = new System.Drawing.Size(235, 13);
            this.speedL.TabIndex = 0;
            this.speedL.Text = "Combinación de teclas para ajustar la velocidad:";
            // 
            // moveL
            // 
            this.moveL.AutoSize = true;
            this.moveL.Location = new System.Drawing.Point(12, 46);
            this.moveL.Name = "moveL";
            this.moveL.Size = new System.Drawing.Size(180, 13);
            this.moveL.TabIndex = 4;
            this.moveL.Text = "Para desplazarse y hacer clic utilizar ";
            // 
            // moveCB
            // 
            this.moveCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::KeyMouse.Properties.Settings.Default, "move", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moveCB.FormattingEnabled = true;
            this.moveCB.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.moveCB.Location = new System.Drawing.Point(189, 43);
            this.moveCB.Name = "moveCB";
            this.moveCB.Size = new System.Drawing.Size(58, 21);
            this.moveCB.TabIndex = 5;
            this.moveCB.SelectedIndexChanged += new System.EventHandler(this.AnyChanged);
            // 
            // andL
            // 
            this.andL.AutoSize = true;
            this.andL.Location = new System.Drawing.Point(253, 46);
            this.andL.Name = "andL";
            this.andL.Size = new System.Drawing.Size(15, 13);
            this.andL.TabIndex = 6;
            this.andL.Text = "y:";
            // 
            // moveUpL
            // 
            this.moveUpL.AutoSize = true;
            this.moveUpL.Location = new System.Drawing.Point(28, 76);
            this.moveUpL.Name = "moveUpL";
            this.moveUpL.Size = new System.Drawing.Size(138, 13);
            this.moveUpL.TabIndex = 7;
            this.moveUpL.Text = "Para moverse arriba la tecla";
            // 
            // moveDownL
            // 
            this.moveDownL.AutoSize = true;
            this.moveDownL.Location = new System.Drawing.Point(28, 103);
            this.moveDownL.Name = "moveDownL";
            this.moveDownL.Size = new System.Drawing.Size(138, 13);
            this.moveDownL.TabIndex = 9;
            this.moveDownL.Text = "Para moverse abajo la tecla";
            // 
            // moveRightL
            // 
            this.moveRightL.AutoSize = true;
            this.moveRightL.Location = new System.Drawing.Point(28, 157);
            this.moveRightL.Name = "moveRightL";
            this.moveRightL.Size = new System.Drawing.Size(171, 13);
            this.moveRightL.TabIndex = 13;
            this.moveRightL.Text = "Para moverse a la derecha la tecla";
            // 
            // moveLeftL
            // 
            this.moveLeftL.AutoSize = true;
            this.moveLeftL.Location = new System.Drawing.Point(28, 130);
            this.moveLeftL.Name = "moveLeftL";
            this.moveLeftL.Size = new System.Drawing.Size(174, 13);
            this.moveLeftL.TabIndex = 11;
            this.moveLeftL.Text = "Para moverse a la izquierda la tecla";
            // 
            // applyB
            // 
            this.applyB.Location = new System.Drawing.Point(356, 246);
            this.applyB.Name = "applyB";
            this.applyB.Size = new System.Drawing.Size(56, 23);
            this.applyB.TabIndex = 15;
            this.applyB.Text = "Aplicar";
            this.applyB.UseVisualStyleBackColor = true;
            this.applyB.Click += new System.EventHandler(this.applyB_Click);
            // 
            // infoL
            // 
            this.infoL.AutoSize = true;
            this.infoL.Location = new System.Drawing.Point(393, 13);
            this.infoL.Name = "infoL";
            this.infoL.Size = new System.Drawing.Size(19, 13);
            this.infoL.TabIndex = 16;
            this.infoL.Text = "(?)";
            this.toolTip.SetToolTip(this.infoL, "Manteniendo esta combinación de teclas pulsada,\r\npulse un número para ajustar la " +
        "velocidad (0-9).\r\n\r\nTambién puede pulsar dos números mientras las\r\nmantiene para" +
        " ajustar una velocidad de dos cifras.");
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 0;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 0;
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.BalloonTipText = "KeyMouse está en ejecución.\r\n\r\nSi cierra KeyMouse, no podrá\r\ncontrolar el ratón c" +
    "on el teclado.";
            this.tray.BalloonTipTitle = "KeyMouse está en ejecución";
            this.tray.ContextMenuStrip = this.trayCMS;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "KeyMouse";
            this.tray.Visible = true;
            this.tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseClick);
            // 
            // trayCMS
            // 
            this.trayCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTSMI,
            this.exitTSMI});
            this.trayCMS.Name = "trayCMS";
            this.trayCMS.Size = new System.Drawing.Size(113, 48);
            // 
            // settingsTSMI
            // 
            this.settingsTSMI.Name = "settingsTSMI";
            this.settingsTSMI.Size = new System.Drawing.Size(112, 22);
            this.settingsTSMI.Text = "Ajustes";
            this.settingsTSMI.Click += new System.EventHandler(this.settingsTSMI_Click);
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(112, 22);
            this.exitTSMI.Text = "Salir";
            this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // leftL
            // 
            this.leftL.AutoSize = true;
            this.leftL.Location = new System.Drawing.Point(28, 189);
            this.leftL.Name = "leftL";
            this.leftL.Size = new System.Drawing.Size(123, 13);
            this.leftL.TabIndex = 17;
            this.leftL.Text = "Para hacer clic izquierdo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Para hacer clic derecho";
            // 
            // spamL
            // 
            this.spamL.AutoSize = true;
            this.spamL.Location = new System.Drawing.Point(326, 73);
            this.spamL.Name = "spamL";
            this.spamL.Size = new System.Drawing.Size(86, 117);
            this.spamL.TabIndex = 28;
            this.spamL.Text = "Aplicación\r\ndiseñada\r\n== por ==\r\nLonamiWebs\r\n\r\nPara dudas\r\nconsultar\r\nLonamiWebs." +
    "TK\r\n/soporte";
            this.spamL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightTB
            // 
            this.rightTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::KeyMouse.Properties.Settings.Default, "right", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rightTB.Location = new System.Drawing.Point(157, 213);
            this.rightTB.Name = "rightTB";
            this.rightTB.Size = new System.Drawing.Size(137, 20);
            this.rightTB.TabIndex = 27;
            this.rightTB.Text = global::KeyMouse.Properties.Settings.Default.right;
            this.rightTB.TextChanged += new System.EventHandler(this.AnyChanged);
            // 
            // leftTB
            // 
            this.leftTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::KeyMouse.Properties.Settings.Default, "left", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.leftTB.Location = new System.Drawing.Point(157, 186);
            this.leftTB.Name = "leftTB";
            this.leftTB.Size = new System.Drawing.Size(137, 20);
            this.leftTB.TabIndex = 26;
            this.leftTB.Text = global::KeyMouse.Properties.Settings.Default.left;
            this.leftTB.TextChanged += new System.EventHandler(this.AnyChanged);
            // 
            // moveRightTB
            // 
            this.moveRightTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::KeyMouse.Properties.Settings.Default, "moveright", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveRightTB.Location = new System.Drawing.Point(208, 154);
            this.moveRightTB.Name = "moveRightTB";
            this.moveRightTB.Size = new System.Drawing.Size(86, 20);
            this.moveRightTB.TabIndex = 25;
            this.moveRightTB.Text = global::KeyMouse.Properties.Settings.Default.moveright;
            this.moveRightTB.TextChanged += new System.EventHandler(this.AnyChanged);
            // 
            // moveLeftTB
            // 
            this.moveLeftTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::KeyMouse.Properties.Settings.Default, "moveleft", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveLeftTB.Location = new System.Drawing.Point(208, 127);
            this.moveLeftTB.Name = "moveLeftTB";
            this.moveLeftTB.Size = new System.Drawing.Size(86, 20);
            this.moveLeftTB.TabIndex = 24;
            this.moveLeftTB.Text = global::KeyMouse.Properties.Settings.Default.moveleft;
            this.moveLeftTB.TextChanged += new System.EventHandler(this.AnyChanged);
            // 
            // moveDownTB
            // 
            this.moveDownTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::KeyMouse.Properties.Settings.Default, "movedown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveDownTB.Location = new System.Drawing.Point(172, 100);
            this.moveDownTB.Name = "moveDownTB";
            this.moveDownTB.Size = new System.Drawing.Size(122, 20);
            this.moveDownTB.TabIndex = 23;
            this.moveDownTB.Text = global::KeyMouse.Properties.Settings.Default.movedown;
            this.moveDownTB.TextChanged += new System.EventHandler(this.AnyChanged);
            // 
            // moveUpTB
            // 
            this.moveUpTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::KeyMouse.Properties.Settings.Default, "moveup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveUpTB.Location = new System.Drawing.Point(172, 73);
            this.moveUpTB.Name = "moveUpTB";
            this.moveUpTB.Size = new System.Drawing.Size(122, 20);
            this.moveUpTB.TabIndex = 22;
            this.moveUpTB.Text = global::KeyMouse.Properties.Settings.Default.moveup;
            this.moveUpTB.TextChanged += new System.EventHandler(this.AnyChanged);
            // 
            // captureCB
            // 
            this.captureCB.AutoSize = true;
            this.captureCB.Checked = global::KeyMouse.Properties.Settings.Default.capture;
            this.captureCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.captureCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::KeyMouse.Properties.Settings.Default, "capture", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.captureCB.Location = new System.Drawing.Point(12, 250);
            this.captureCB.Name = "captureCB";
            this.captureCB.Size = new System.Drawing.Size(114, 17);
            this.captureCB.TabIndex = 21;
            this.captureCB.Text = "Capturar pulsación";
            this.toolTip.SetToolTip(this.captureCB, "Si se captura la pulsación, la aplicación en la que\r\nse esté no recibirá las puls" +
        "aciones de teclas.\r\n\r\nSe recomienda dejar activado esta casilla");
            this.captureCB.UseVisualStyleBackColor = true;
            // 
            // altCB
            // 
            this.altCB.AutoSize = true;
            this.altCB.Checked = global::KeyMouse.Properties.Settings.Default.alt;
            this.altCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::KeyMouse.Properties.Settings.Default, "alt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.altCB.Location = new System.Drawing.Point(300, 12);
            this.altCB.Name = "altCB";
            this.altCB.Size = new System.Drawing.Size(38, 17);
            this.altCB.TabIndex = 3;
            this.altCB.Text = "Alt";
            this.altCB.UseVisualStyleBackColor = true;
            this.altCB.CheckedChanged += new System.EventHandler(this.AnyChanged);
            // 
            // shiftCB
            // 
            this.shiftCB.AutoSize = true;
            this.shiftCB.Checked = global::KeyMouse.Properties.Settings.Default.shift;
            this.shiftCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::KeyMouse.Properties.Settings.Default, "shift", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.shiftCB.Location = new System.Drawing.Point(344, 12);
            this.shiftCB.Name = "shiftCB";
            this.shiftCB.Size = new System.Drawing.Size(47, 17);
            this.shiftCB.TabIndex = 2;
            this.shiftCB.Text = "Shift";
            this.shiftCB.UseVisualStyleBackColor = true;
            this.shiftCB.CheckedChanged += new System.EventHandler(this.AnyChanged);
            // 
            // ctrlCB
            // 
            this.ctrlCB.AutoSize = true;
            this.ctrlCB.Checked = global::KeyMouse.Properties.Settings.Default.control;
            this.ctrlCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctrlCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::KeyMouse.Properties.Settings.Default, "control", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ctrlCB.Location = new System.Drawing.Point(253, 12);
            this.ctrlCB.Name = "ctrlCB";
            this.ctrlCB.Size = new System.Drawing.Size(41, 17);
            this.ctrlCB.TabIndex = 1;
            this.ctrlCB.Text = "Ctrl";
            this.ctrlCB.UseVisualStyleBackColor = true;
            this.ctrlCB.CheckedChanged += new System.EventHandler(this.AnyChanged);
            // 
            // MainF
            // 
            this.ClientSize = new System.Drawing.Size(414, 271);
            this.Controls.Add(this.spamL);
            this.Controls.Add(this.rightTB);
            this.Controls.Add(this.leftTB);
            this.Controls.Add(this.moveRightTB);
            this.Controls.Add(this.moveLeftTB);
            this.Controls.Add(this.moveDownTB);
            this.Controls.Add(this.moveUpTB);
            this.Controls.Add(this.captureCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftL);
            this.Controls.Add(this.infoL);
            this.Controls.Add(this.applyB);
            this.Controls.Add(this.moveRightL);
            this.Controls.Add(this.moveLeftL);
            this.Controls.Add(this.moveDownL);
            this.Controls.Add(this.moveUpL);
            this.Controls.Add(this.andL);
            this.Controls.Add(this.moveCB);
            this.Controls.Add(this.moveL);
            this.Controls.Add(this.altCB);
            this.Controls.Add(this.shiftCB);
            this.Controls.Add(this.ctrlCB);
            this.Controls.Add(this.speedL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainF";
            this.Text = "Ajustes de KeyMouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainF_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainF_FormClosed);
            this.Load += new System.EventHandler(this.MainF_Load);
            this.Resize += new System.EventHandler(this.MainF_Resize);
            this.trayCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedL;
        private System.Windows.Forms.CheckBox ctrlCB;
        private System.Windows.Forms.CheckBox shiftCB;
        private System.Windows.Forms.CheckBox altCB;
        private System.Windows.Forms.Label moveL;
        private System.Windows.Forms.ComboBox moveCB;
        private System.Windows.Forms.Label andL;
        private System.Windows.Forms.Label moveUpL;
        private System.Windows.Forms.Label moveDownL;
        private System.Windows.Forms.Label moveRightL;
        private System.Windows.Forms.Label moveLeftL;
        private System.Windows.Forms.Button applyB;
        private System.Windows.Forms.Label infoL;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayCMS;
        private System.Windows.Forms.ToolStripMenuItem settingsTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.Label leftL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox captureCB;
        private System.Windows.Forms.TextBox moveUpTB;
        private System.Windows.Forms.TextBox moveDownTB;
        private System.Windows.Forms.TextBox moveLeftTB;
        private System.Windows.Forms.TextBox moveRightTB;
        private System.Windows.Forms.TextBox leftTB;
        private System.Windows.Forms.TextBox rightTB;
        private System.Windows.Forms.Label spamL;
    }
}

