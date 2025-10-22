using System.Threading.Tasks;

namespace GModDedicatedServer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_start = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tabs = new System.Windows.Forms.TabControl();
            tab_server = new System.Windows.Forms.TabPage();
            cb_fixedconsolesize = new System.Windows.Forms.CheckBox();
            llbl_ip = new System.Windows.Forms.LinkLabel();
            btn_restart = new System.Windows.Forms.Button();
            btn_safestart = new System.Windows.Forms.Button();
            tab_properties = new System.Windows.Forms.TabPage();
            pProperties = new System.Windows.Forms.Panel();
            lbl_cachesize = new System.Windows.Forms.Label();
            btn_deletecache = new System.Windows.Forms.Button();
            lbl_gmasize = new System.Windows.Forms.Label();
            btn_deletegmas = new System.Windows.Forms.Button();
            btn_gmas = new System.Windows.Forms.Button();
            lbl_restartcode = new System.Windows.Forms.Label();
            rtb_restartcode = new System.Windows.Forms.RichTextBox();
            linklbl_portcheck = new System.Windows.Forms.LinkLabel();
            lbl_missingcontent = new System.Windows.Forms.Label();
            rtxt_rconpassword = new System.Windows.Forms.RichTextBox();
            lbl_rconpassword = new System.Windows.Forms.Label();
            rtxt_password = new System.Windows.Forms.RichTextBox();
            lbl_password = new System.Windows.Forms.Label();
            cb_gamemodes = new System.Windows.Forms.ComboBox();
            cb_maps = new System.Windows.Forms.ComboBox();
            linklbl_tutorials = new System.Windows.Forms.LinkLabel();
            lbl_porttext = new System.Windows.Forms.Label();
            rtxt_hostname = new System.Windows.Forms.RichTextBox();
            btn_configs = new System.Windows.Forms.Button();
            rtxt_servercfg = new System.Windows.Forms.RichTextBox();
            lbl_servercfg = new System.Windows.Forms.Label();
            lbl_hostname = new System.Windows.Forms.Label();
            lbl_maxplayers = new System.Windows.Forms.Label();
            nud_maxplayers = new System.Windows.Forms.NumericUpDown();
            btn_cmds = new System.Windows.Forms.Button();
            nud_port = new System.Windows.Forms.NumericUpDown();
            rtxt_othercmds = new System.Windows.Forms.RichTextBox();
            lbl_addcmds = new System.Windows.Forms.Label();
            lbl_port = new System.Windows.Forms.Label();
            lbl_workshopid = new System.Windows.Forms.Label();
            lbl_maps = new System.Windows.Forms.Label();
            nud_workshopid = new System.Windows.Forms.NumericUpDown();
            btn_workshopid = new System.Windows.Forms.Button();
            lbl_gamemodes = new System.Windows.Forms.Label();
            tab_game = new System.Windows.Forms.TabPage();
            p_game = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            gb_login = new System.Windows.Forms.GroupBox();
            lbl_loginname = new System.Windows.Forms.Label();
            rtxt_loginpassword = new System.Windows.Forms.RichTextBox();
            lbl_loginpassword = new System.Windows.Forms.Label();
            rtxt_loginname = new System.Windows.Forms.RichTextBox();
            lbl_dspath = new System.Windows.Forms.Label();
            rtxt_dspath = new System.Windows.Forms.RichTextBox();
            btn_dspath = new System.Windows.Forms.Button();
            btn_dsinstall = new System.Windows.Forms.Button();
            btn_open_dspath = new System.Windows.Forms.Button();
            cb_game = new System.Windows.Forms.ComboBox();
            lbl_appid = new System.Windows.Forms.Label();
            tab_steam = new System.Windows.Forms.TabPage();
            p_steam = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btn_steamcmdinstall = new System.Windows.Forms.Button();
            btn_open_steamcmdpath = new System.Windows.Forms.Button();
            rtxt_steamcmdpath = new System.Windows.Forms.RichTextBox();
            btn_steamcmdpath = new System.Windows.Forms.Button();
            lbl_steamcmdpath = new System.Windows.Forms.Label();
            tab_about = new System.Windows.Forms.TabPage();
            lbl_allservers = new System.Windows.Forms.Label();
            btn_closeall = new System.Windows.Forms.Button();
            cb_alwaysontop = new System.Windows.Forms.CheckBox();
            btn_donation = new System.Windows.Forms.Button();
            lbl_version2 = new System.Windows.Forms.Label();
            lbl_lang = new System.Windows.Forms.Label();
            cb_lang = new System.Windows.Forms.ComboBox();
            btn_tutorial = new System.Windows.Forms.Button();
            btn_discord = new System.Windows.Forms.Button();
            btn_website = new System.Windows.Forms.Button();
            lbl_version = new System.Windows.Forms.Label();
            p_version = new System.Windows.Forms.Panel();
            btn_download = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            tt_ip = new System.Windows.Forms.ToolTip(components);
            tabs.SuspendLayout();
            tab_server.SuspendLayout();
            tab_properties.SuspendLayout();
            pProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_maxplayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_port).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_workshopid).BeginInit();
            tab_game.SuspendLayout();
            p_game.SuspendLayout();
            gb_login.SuspendLayout();
            tab_steam.SuspendLayout();
            p_steam.SuspendLayout();
            tab_about.SuspendLayout();
            p_version.SuspendLayout();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = System.Drawing.Color.Lime;
            btn_start.Location = new System.Drawing.Point(4, 6);
            btn_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_start.Name = "btn_start";
            btn_start.Size = new System.Drawing.Size(140, 30);
            btn_start.TabIndex = 2;
            btn_start.Text = "Start Server";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += Btn_start_Click;
            btn_start.Paint += Btn_start_Paint;
            btn_start.Enter += Btn_start_Enter;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.MidnightBlue;
            panel1.Location = new System.Drawing.Point(7, 44);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(656, 439);
            panel1.TabIndex = 5;
            // 
            // tabs
            // 
            tabs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabs.Controls.Add(tab_server);
            tabs.Controls.Add(tab_properties);
            tabs.Controls.Add(tab_game);
            tabs.Controls.Add(tab_steam);
            tabs.Controls.Add(tab_about);
            tabs.Location = new System.Drawing.Point(-4, 0);
            tabs.Margin = new System.Windows.Forms.Padding(0);
            tabs.Name = "tabs";
            tabs.Padding = new System.Drawing.Point(0, 0);
            tabs.SelectedIndex = 0;
            tabs.Size = new System.Drawing.Size(678, 520);
            tabs.TabIndex = 0;
            // 
            // tab_server
            // 
            tab_server.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            tab_server.Controls.Add(cb_fixedconsolesize);
            tab_server.Controls.Add(llbl_ip);
            tab_server.Controls.Add(btn_restart);
            tab_server.Controls.Add(btn_safestart);
            tab_server.Controls.Add(btn_start);
            tab_server.Controls.Add(panel1);
            tab_server.Location = new System.Drawing.Point(4, 24);
            tab_server.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_server.Name = "tab_server";
            tab_server.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_server.Size = new System.Drawing.Size(670, 492);
            tab_server.TabIndex = 0;
            tab_server.Text = "tab_server";
            // 
            // cb_fixedconsolesize
            // 
            cb_fixedconsolesize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_fixedconsolesize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cb_fixedconsolesize.ForeColor = System.Drawing.Color.White;
            cb_fixedconsolesize.Location = new System.Drawing.Point(300, 13);
            cb_fixedconsolesize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_fixedconsolesize.Name = "cb_fixedconsolesize";
            cb_fixedconsolesize.Size = new System.Drawing.Size(178, 20);
            cb_fixedconsolesize.TabIndex = 14;
            cb_fixedconsolesize.Text = "LID_consolefixedsize";
            cb_fixedconsolesize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cb_fixedconsolesize.UseVisualStyleBackColor = true;
            cb_fixedconsolesize.CheckedChanged += Cb_fixedconsolesize_CheckedChanged;
            // 
            // llbl_ip
            // 
            llbl_ip.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            llbl_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            llbl_ip.LinkColor = System.Drawing.Color.White;
            llbl_ip.Location = new System.Drawing.Point(483, 8);
            llbl_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            llbl_ip.Name = "llbl_ip";
            llbl_ip.Size = new System.Drawing.Size(180, 27);
            llbl_ip.TabIndex = 13;
            llbl_ip.TabStop = true;
            llbl_ip.Tag = "ip";
            llbl_ip.Text = "255.255.255.255:55555";
            llbl_ip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            llbl_ip.VisitedLinkColor = System.Drawing.Color.White;
            llbl_ip.LinkClicked += Llbl_ip_LinkClicked;
            // 
            // btn_restart
            // 
            btn_restart.BackColor = System.Drawing.Color.Yellow;
            btn_restart.Location = new System.Drawing.Point(152, 6);
            btn_restart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new System.Drawing.Size(140, 30);
            btn_restart.TabIndex = 8;
            btn_restart.Text = "Restart Server";
            btn_restart.UseVisualStyleBackColor = false;
            btn_restart.Visible = false;
            btn_restart.Click += Btn_restart_Click;
            // 
            // btn_safestart
            // 
            btn_safestart.BackColor = System.Drawing.Color.Lime;
            btn_safestart.Location = new System.Drawing.Point(152, 6);
            btn_safestart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_safestart.Name = "btn_safestart";
            btn_safestart.Size = new System.Drawing.Size(233, 30);
            btn_safestart.TabIndex = 7;
            btn_safestart.Text = "Update + Start Server";
            btn_safestart.UseVisualStyleBackColor = false;
            btn_safestart.Click += Btn_safestart_Click;
            // 
            // tab_properties
            // 
            tab_properties.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            tab_properties.Controls.Add(pProperties);
            tab_properties.Location = new System.Drawing.Point(4, 24);
            tab_properties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_properties.Name = "tab_properties";
            tab_properties.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_properties.Size = new System.Drawing.Size(670, 492);
            tab_properties.TabIndex = 1;
            tab_properties.Text = "tab_properties";
            // 
            // pProperties
            // 
            pProperties.AutoScroll = true;
            pProperties.BackColor = System.Drawing.Color.Transparent;
            pProperties.Controls.Add(lbl_cachesize);
            pProperties.Controls.Add(btn_deletecache);
            pProperties.Controls.Add(lbl_gmasize);
            pProperties.Controls.Add(btn_deletegmas);
            pProperties.Controls.Add(btn_gmas);
            pProperties.Controls.Add(lbl_restartcode);
            pProperties.Controls.Add(rtb_restartcode);
            pProperties.Controls.Add(linklbl_portcheck);
            pProperties.Controls.Add(lbl_missingcontent);
            pProperties.Controls.Add(rtxt_rconpassword);
            pProperties.Controls.Add(lbl_rconpassword);
            pProperties.Controls.Add(rtxt_password);
            pProperties.Controls.Add(lbl_password);
            pProperties.Controls.Add(cb_gamemodes);
            pProperties.Controls.Add(cb_maps);
            pProperties.Controls.Add(linklbl_tutorials);
            pProperties.Controls.Add(lbl_porttext);
            pProperties.Controls.Add(rtxt_hostname);
            pProperties.Controls.Add(btn_configs);
            pProperties.Controls.Add(rtxt_servercfg);
            pProperties.Controls.Add(lbl_servercfg);
            pProperties.Controls.Add(lbl_hostname);
            pProperties.Controls.Add(lbl_maxplayers);
            pProperties.Controls.Add(nud_maxplayers);
            pProperties.Controls.Add(btn_cmds);
            pProperties.Controls.Add(nud_port);
            pProperties.Controls.Add(rtxt_othercmds);
            pProperties.Controls.Add(lbl_addcmds);
            pProperties.Controls.Add(lbl_port);
            pProperties.Controls.Add(lbl_workshopid);
            pProperties.Controls.Add(lbl_maps);
            pProperties.Controls.Add(nud_workshopid);
            pProperties.Controls.Add(btn_workshopid);
            pProperties.Controls.Add(lbl_gamemodes);
            pProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            pProperties.Location = new System.Drawing.Point(4, 3);
            pProperties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pProperties.Name = "pProperties";
            pProperties.Size = new System.Drawing.Size(662, 486);
            pProperties.TabIndex = 23;
            // 
            // lbl_cachesize
            // 
            lbl_cachesize.AutoSize = true;
            lbl_cachesize.ForeColor = System.Drawing.Color.White;
            lbl_cachesize.Location = new System.Drawing.Point(478, 111);
            lbl_cachesize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_cachesize.Name = "lbl_cachesize";
            lbl_cachesize.Size = new System.Drawing.Size(93, 15);
            lbl_cachesize.TabIndex = 42;
            lbl_cachesize.Text = "CacheFolderSize";
            lbl_cachesize.Click += Lbl_sizecache_Click;
            // 
            // btn_deletecache
            // 
            btn_deletecache.BackColor = System.Drawing.Color.OrangeRed;
            btn_deletecache.ForeColor = System.Drawing.Color.White;
            btn_deletecache.Location = new System.Drawing.Point(478, 81);
            btn_deletecache.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_deletecache.Name = "btn_deletecache";
            btn_deletecache.Size = new System.Drawing.Size(150, 27);
            btn_deletecache.TabIndex = 41;
            btn_deletecache.Text = "LID_deletecache";
            btn_deletecache.UseVisualStyleBackColor = false;
            btn_deletecache.Click += Btn_deletecache_Click;
            // 
            // lbl_gmasize
            // 
            lbl_gmasize.AutoSize = true;
            lbl_gmasize.ForeColor = System.Drawing.Color.White;
            lbl_gmasize.Location = new System.Drawing.Point(478, 226);
            lbl_gmasize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_gmasize.Name = "lbl_gmasize";
            lbl_gmasize.Size = new System.Drawing.Size(87, 15);
            lbl_gmasize.TabIndex = 40;
            lbl_gmasize.Text = "GMAFolderSize";
            lbl_gmasize.Click += Lbl_gmasize_Click;
            // 
            // btn_deletegmas
            // 
            btn_deletegmas.BackColor = System.Drawing.Color.Red;
            btn_deletegmas.ForeColor = System.Drawing.Color.White;
            btn_deletegmas.Location = new System.Drawing.Point(478, 196);
            btn_deletegmas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_deletegmas.Name = "btn_deletegmas";
            btn_deletegmas.Size = new System.Drawing.Size(150, 27);
            btn_deletegmas.TabIndex = 39;
            btn_deletegmas.Text = "LID_deletegmas";
            btn_deletegmas.UseVisualStyleBackColor = false;
            btn_deletegmas.Click += Btn_deletegmas_Click;
            // 
            // btn_gmas
            // 
            btn_gmas.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_gmas.ForeColor = System.Drawing.Color.White;
            btn_gmas.Location = new System.Drawing.Point(320, 196);
            btn_gmas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_gmas.Name = "btn_gmas";
            btn_gmas.Size = new System.Drawing.Size(150, 27);
            btn_gmas.TabIndex = 38;
            btn_gmas.Text = "GMAs";
            btn_gmas.UseVisualStyleBackColor = false;
            btn_gmas.Click += Btn_gmas_Click;
            // 
            // lbl_restartcode
            // 
            lbl_restartcode.AutoSize = true;
            lbl_restartcode.ForeColor = System.Drawing.Color.White;
            lbl_restartcode.Location = new System.Drawing.Point(320, 62);
            lbl_restartcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_restartcode.Name = "lbl_restartcode";
            lbl_restartcode.Size = new System.Drawing.Size(74, 15);
            lbl_restartcode.TabIndex = 37;
            lbl_restartcode.Text = "Restart Code";
            // 
            // rtb_restartcode
            // 
            rtb_restartcode.BackColor = System.Drawing.Color.Silver;
            rtb_restartcode.Location = new System.Drawing.Point(320, 81);
            rtb_restartcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtb_restartcode.Name = "rtb_restartcode";
            rtb_restartcode.Size = new System.Drawing.Size(150, 27);
            rtb_restartcode.TabIndex = 36;
            rtb_restartcode.Text = "";
            rtb_restartcode.TextChanged += Rtb_restartcode_TextChanged;
            // 
            // linklbl_portcheck
            // 
            linklbl_portcheck.AutoSize = true;
            linklbl_portcheck.LinkColor = System.Drawing.Color.FromArgb(128, 128, 255);
            linklbl_portcheck.Location = new System.Drawing.Point(380, 157);
            linklbl_portcheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linklbl_portcheck.Name = "linklbl_portcheck";
            linklbl_portcheck.Size = new System.Drawing.Size(60, 15);
            linklbl_portcheck.TabIndex = 32;
            linklbl_portcheck.TabStop = true;
            linklbl_portcheck.Text = "Portcheck";
            // 
            // lbl_missingcontent
            // 
            lbl_missingcontent.AutoSize = true;
            lbl_missingcontent.ForeColor = System.Drawing.Color.White;
            lbl_missingcontent.Location = new System.Drawing.Point(320, 257);
            lbl_missingcontent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_missingcontent.Name = "lbl_missingcontent";
            lbl_missingcontent.Size = new System.Drawing.Size(176, 15);
            lbl_missingcontent.TabIndex = 31;
            lbl_missingcontent.Text = "Missing Content? Restart Server.";
            // 
            // rtxt_rconpassword
            // 
            rtxt_rconpassword.BackColor = System.Drawing.Color.Silver;
            rtxt_rconpassword.Location = new System.Drawing.Point(162, 81);
            rtxt_rconpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_rconpassword.Multiline = false;
            rtxt_rconpassword.Name = "rtxt_rconpassword";
            rtxt_rconpassword.Size = new System.Drawing.Size(150, 27);
            rtxt_rconpassword.TabIndex = 29;
            rtxt_rconpassword.Text = "";
            rtxt_rconpassword.TextChanged += Rtxt_rconpassword_TextChanged;
            // 
            // lbl_rconpassword
            // 
            lbl_rconpassword.AutoSize = true;
            lbl_rconpassword.ForeColor = System.Drawing.Color.White;
            lbl_rconpassword.Location = new System.Drawing.Point(162, 62);
            lbl_rconpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_rconpassword.Name = "lbl_rconpassword";
            lbl_rconpassword.Size = new System.Drawing.Size(140, 15);
            lbl_rconpassword.TabIndex = 30;
            lbl_rconpassword.Text = "Admin Password (RCON)";
            // 
            // rtxt_password
            // 
            rtxt_password.BackColor = System.Drawing.Color.Silver;
            rtxt_password.Location = new System.Drawing.Point(4, 81);
            rtxt_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_password.Multiline = false;
            rtxt_password.Name = "rtxt_password";
            rtxt_password.Size = new System.Drawing.Size(150, 27);
            rtxt_password.TabIndex = 27;
            rtxt_password.Text = "";
            rtxt_password.TextChanged += Rtxt_password_TextChanged;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.ForeColor = System.Drawing.Color.White;
            lbl_password.Location = new System.Drawing.Point(0, 62);
            lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new System.Drawing.Size(57, 15);
            lbl_password.TabIndex = 28;
            lbl_password.Text = "Password";
            // 
            // cb_gamemodes
            // 
            cb_gamemodes.BackColor = System.Drawing.Color.Silver;
            cb_gamemodes.FormattingEnabled = true;
            cb_gamemodes.Location = new System.Drawing.Point(4, 254);
            cb_gamemodes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_gamemodes.Name = "cb_gamemodes";
            cb_gamemodes.Size = new System.Drawing.Size(150, 23);
            cb_gamemodes.TabIndex = 26;
            cb_gamemodes.SelectedIndexChanged += Cb_gamemodes_SelectedIndexChanged;
            cb_gamemodes.TextUpdate += Cb_gamemodes_TextUpdate;
            cb_gamemodes.Enter += Cb_gamemodes_Enter;
            // 
            // cb_maps
            // 
            cb_maps.BackColor = System.Drawing.Color.Silver;
            cb_maps.FormattingEnabled = true;
            cb_maps.Location = new System.Drawing.Point(162, 254);
            cb_maps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_maps.Name = "cb_maps";
            cb_maps.Size = new System.Drawing.Size(150, 23);
            cb_maps.TabIndex = 25;
            cb_maps.SelectedIndexChanged += Cb_SelectedIndexChanged;
            cb_maps.TextChanged += Cb_maps_TextChanged;
            cb_maps.Enter += Cb_maps_Enter;
            // 
            // linklbl_tutorials
            // 
            linklbl_tutorials.AutoSize = true;
            linklbl_tutorials.LinkColor = System.Drawing.Color.FromArgb(128, 128, 255);
            linklbl_tutorials.Location = new System.Drawing.Point(320, 157);
            linklbl_tutorials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linklbl_tutorials.Name = "linklbl_tutorials";
            linklbl_tutorials.Size = new System.Drawing.Size(53, 15);
            linklbl_tutorials.TabIndex = 24;
            linklbl_tutorials.TabStop = true;
            linklbl_tutorials.Text = "Tutorials";
            linklbl_tutorials.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // lbl_porttext
            // 
            lbl_porttext.AutoSize = true;
            lbl_porttext.Font = new System.Drawing.Font("Segoe UI", 8F);
            lbl_porttext.ForeColor = System.Drawing.Color.White;
            lbl_porttext.Location = new System.Drawing.Point(320, 140);
            lbl_porttext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_porttext.Name = "lbl_porttext";
            lbl_porttext.Size = new System.Drawing.Size(261, 13);
            lbl_porttext.TabIndex = 23;
            lbl_porttext.Text = "<= This port need to be forwarded (public server)";
            // 
            // rtxt_hostname
            // 
            rtxt_hostname.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtxt_hostname.BackColor = System.Drawing.Color.Silver;
            rtxt_hostname.Location = new System.Drawing.Point(4, 18);
            rtxt_hostname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_hostname.Multiline = false;
            rtxt_hostname.Name = "rtxt_hostname";
            rtxt_hostname.Size = new System.Drawing.Size(470, 27);
            rtxt_hostname.TabIndex = 4;
            rtxt_hostname.Text = "";
            rtxt_hostname.TextChanged += Rtxt_hostname_TextChanged;
            // 
            // btn_configs
            // 
            btn_configs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_configs.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_configs.ForeColor = System.Drawing.Color.White;
            btn_configs.Location = new System.Drawing.Point(324, 393);
            btn_configs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_configs.Name = "btn_configs";
            btn_configs.Size = new System.Drawing.Size(150, 27);
            btn_configs.TabIndex = 20;
            btn_configs.Text = "Configs";
            btn_configs.UseVisualStyleBackColor = false;
            btn_configs.Click += Btn_configs_Click;
            // 
            // rtxt_servercfg
            // 
            rtxt_servercfg.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtxt_servercfg.BackColor = System.Drawing.Color.Silver;
            rtxt_servercfg.Location = new System.Drawing.Point(4, 393);
            rtxt_servercfg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_servercfg.Name = "rtxt_servercfg";
            rtxt_servercfg.Size = new System.Drawing.Size(312, 73);
            rtxt_servercfg.TabIndex = 21;
            rtxt_servercfg.Text = "";
            rtxt_servercfg.TextChanged += Rtxt_servercfg_TextChanged;
            // 
            // lbl_servercfg
            // 
            lbl_servercfg.AutoSize = true;
            lbl_servercfg.ForeColor = System.Drawing.Color.White;
            lbl_servercfg.Location = new System.Drawing.Point(4, 374);
            lbl_servercfg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_servercfg.Name = "lbl_servercfg";
            lbl_servercfg.Size = new System.Drawing.Size(348, 15);
            lbl_servercfg.TabIndex = 22;
            lbl_servercfg.Text = "server.cfg (Config File, for more settings, example: sv_loadingurl)";
            // 
            // lbl_hostname
            // 
            lbl_hostname.AutoSize = true;
            lbl_hostname.ForeColor = System.Drawing.Color.White;
            lbl_hostname.Location = new System.Drawing.Point(0, 0);
            lbl_hostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_hostname.Name = "lbl_hostname";
            lbl_hostname.Size = new System.Drawing.Size(62, 15);
            lbl_hostname.TabIndex = 0;
            lbl_hostname.Text = "Hostname";
            // 
            // lbl_maxplayers
            // 
            lbl_maxplayers.AutoSize = true;
            lbl_maxplayers.ForeColor = System.Drawing.Color.White;
            lbl_maxplayers.Location = new System.Drawing.Point(0, 121);
            lbl_maxplayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_maxplayers.Name = "lbl_maxplayers";
            lbl_maxplayers.Size = new System.Drawing.Size(66, 15);
            lbl_maxplayers.TabIndex = 9;
            lbl_maxplayers.Text = "MaxPlayers";
            // 
            // nud_maxplayers
            // 
            nud_maxplayers.BackColor = System.Drawing.Color.Silver;
            nud_maxplayers.Location = new System.Drawing.Point(4, 140);
            nud_maxplayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nud_maxplayers.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            nud_maxplayers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_maxplayers.Name = "nud_maxplayers";
            nud_maxplayers.Size = new System.Drawing.Size(150, 23);
            nud_maxplayers.TabIndex = 8;
            nud_maxplayers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_maxplayers.ValueChanged += Nud_maxplayers_ValueChanged;
            // 
            // btn_cmds
            // 
            btn_cmds.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_cmds.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_cmds.ForeColor = System.Drawing.Color.White;
            btn_cmds.Location = new System.Drawing.Point(324, 304);
            btn_cmds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_cmds.Name = "btn_cmds";
            btn_cmds.Size = new System.Drawing.Size(150, 28);
            btn_cmds.TabIndex = 19;
            btn_cmds.Text = "Commands";
            btn_cmds.UseVisualStyleBackColor = false;
            btn_cmds.Click += Btn_cmds_Click;
            // 
            // nud_port
            // 
            nud_port.BackColor = System.Drawing.Color.Silver;
            nud_port.Location = new System.Drawing.Point(162, 140);
            nud_port.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nud_port.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nud_port.Name = "nud_port";
            nud_port.Size = new System.Drawing.Size(150, 23);
            nud_port.TabIndex = 12;
            nud_port.ValueChanged += Nud_port_ValueChanged;
            // 
            // rtxt_othercmds
            // 
            rtxt_othercmds.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtxt_othercmds.BackColor = System.Drawing.Color.Silver;
            rtxt_othercmds.Location = new System.Drawing.Point(4, 304);
            rtxt_othercmds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_othercmds.Name = "rtxt_othercmds";
            rtxt_othercmds.Size = new System.Drawing.Size(312, 62);
            rtxt_othercmds.TabIndex = 17;
            rtxt_othercmds.Text = "";
            rtxt_othercmds.TextChanged += Rtxt_othercmds_TextChanged;
            // 
            // lbl_addcmds
            // 
            lbl_addcmds.AutoSize = true;
            lbl_addcmds.ForeColor = System.Drawing.Color.White;
            lbl_addcmds.Location = new System.Drawing.Point(4, 286);
            lbl_addcmds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_addcmds.Name = "lbl_addcmds";
            lbl_addcmds.Size = new System.Drawing.Size(237, 15);
            lbl_addcmds.TabIndex = 18;
            lbl_addcmds.Text = "Additional Commands (for advanced users)";
            // 
            // lbl_port
            // 
            lbl_port.AutoSize = true;
            lbl_port.ForeColor = System.Drawing.Color.White;
            lbl_port.Location = new System.Drawing.Point(162, 122);
            lbl_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_port.Name = "lbl_port";
            lbl_port.Size = new System.Drawing.Size(29, 15);
            lbl_port.TabIndex = 13;
            lbl_port.Text = "Port";
            // 
            // lbl_workshopid
            // 
            lbl_workshopid.AutoSize = true;
            lbl_workshopid.ForeColor = System.Drawing.Color.White;
            lbl_workshopid.Location = new System.Drawing.Point(0, 178);
            lbl_workshopid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_workshopid.Name = "lbl_workshopid";
            lbl_workshopid.Size = new System.Drawing.Size(72, 15);
            lbl_workshopid.TabIndex = 3;
            lbl_workshopid.Text = "WorkshopID";
            // 
            // lbl_maps
            // 
            lbl_maps.AutoSize = true;
            lbl_maps.ForeColor = System.Drawing.Color.White;
            lbl_maps.Location = new System.Drawing.Point(162, 236);
            lbl_maps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_maps.Name = "lbl_maps";
            lbl_maps.Size = new System.Drawing.Size(31, 15);
            lbl_maps.TabIndex = 10;
            lbl_maps.Text = "Map";
            // 
            // nud_workshopid
            // 
            nud_workshopid.BackColor = System.Drawing.Color.Silver;
            nud_workshopid.Location = new System.Drawing.Point(4, 196);
            nud_workshopid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nud_workshopid.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            nud_workshopid.Name = "nud_workshopid";
            nud_workshopid.Size = new System.Drawing.Size(150, 23);
            nud_workshopid.TabIndex = 7;
            nud_workshopid.ValueChanged += Nud_workshopid_ValueChanged;
            // 
            // btn_workshopid
            // 
            btn_workshopid.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_workshopid.ForeColor = System.Drawing.Color.White;
            btn_workshopid.Location = new System.Drawing.Point(162, 196);
            btn_workshopid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_workshopid.Name = "btn_workshopid";
            btn_workshopid.Size = new System.Drawing.Size(150, 27);
            btn_workshopid.TabIndex = 14;
            btn_workshopid.Text = "Open Collection";
            btn_workshopid.UseVisualStyleBackColor = false;
            btn_workshopid.Click += Btn_workshopid_Click;
            // 
            // lbl_gamemodes
            // 
            lbl_gamemodes.AutoSize = true;
            lbl_gamemodes.ForeColor = System.Drawing.Color.White;
            lbl_gamemodes.Location = new System.Drawing.Point(0, 235);
            lbl_gamemodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_gamemodes.Name = "lbl_gamemodes";
            lbl_gamemodes.Size = new System.Drawing.Size(69, 15);
            lbl_gamemodes.TabIndex = 2;
            lbl_gamemodes.Text = "Gamemode";
            // 
            // tab_game
            // 
            tab_game.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            tab_game.Controls.Add(p_game);
            tab_game.Location = new System.Drawing.Point(4, 24);
            tab_game.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_game.Name = "tab_game";
            tab_game.Size = new System.Drawing.Size(670, 492);
            tab_game.TabIndex = 3;
            tab_game.Text = "tab_game";
            // 
            // p_game
            // 
            p_game.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            p_game.Controls.Add(label2);
            p_game.Controls.Add(gb_login);
            p_game.Controls.Add(lbl_dspath);
            p_game.Controls.Add(rtxt_dspath);
            p_game.Controls.Add(btn_dspath);
            p_game.Controls.Add(btn_dsinstall);
            p_game.Controls.Add(btn_open_dspath);
            p_game.Controls.Add(cb_game);
            p_game.Controls.Add(lbl_appid);
            p_game.Location = new System.Drawing.Point(13, 14);
            p_game.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            p_game.Name = "p_game";
            p_game.Size = new System.Drawing.Size(644, 777);
            p_game.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(4, 130);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(529, 15);
            label2.TabIndex = 12;
            label2.Text = "This is the Dedicated Server, when the game has an update, you may also need to update the server";
            // 
            // gb_login
            // 
            gb_login.Controls.Add(lbl_loginname);
            gb_login.Controls.Add(rtxt_loginpassword);
            gb_login.Controls.Add(lbl_loginpassword);
            gb_login.Controls.Add(rtxt_loginname);
            gb_login.ForeColor = System.Drawing.Color.White;
            gb_login.Location = new System.Drawing.Point(4, 172);
            gb_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gb_login.Name = "gb_login";
            gb_login.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gb_login.Size = new System.Drawing.Size(488, 67);
            gb_login.TabIndex = 11;
            gb_login.TabStop = false;
            gb_login.Text = "Login";
            // 
            // lbl_loginname
            // 
            lbl_loginname.AutoSize = true;
            lbl_loginname.Location = new System.Drawing.Point(4, 18);
            lbl_loginname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_loginname.Name = "lbl_loginname";
            lbl_loginname.Size = new System.Drawing.Size(76, 15);
            lbl_loginname.TabIndex = 9;
            lbl_loginname.Text = "LOGINNAME";
            // 
            // rtxt_loginpassword
            // 
            rtxt_loginpassword.BackColor = System.Drawing.Color.Silver;
            rtxt_loginpassword.Location = new System.Drawing.Point(247, 37);
            rtxt_loginpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_loginpassword.Name = "rtxt_loginpassword";
            rtxt_loginpassword.Size = new System.Drawing.Size(233, 21);
            rtxt_loginpassword.TabIndex = 8;
            rtxt_loginpassword.Text = "";
            // 
            // lbl_loginpassword
            // 
            lbl_loginpassword.AutoSize = true;
            lbl_loginpassword.Location = new System.Drawing.Point(244, 18);
            lbl_loginpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_loginpassword.Name = "lbl_loginpassword";
            lbl_loginpassword.Size = new System.Drawing.Size(103, 15);
            lbl_loginpassword.TabIndex = 10;
            lbl_loginpassword.Text = "LOGINPASSWORD";
            // 
            // rtxt_loginname
            // 
            rtxt_loginname.BackColor = System.Drawing.Color.Silver;
            rtxt_loginname.Location = new System.Drawing.Point(7, 37);
            rtxt_loginname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_loginname.Name = "rtxt_loginname";
            rtxt_loginname.Size = new System.Drawing.Size(233, 21);
            rtxt_loginname.TabIndex = 7;
            rtxt_loginname.Text = "Anonymous";
            // 
            // lbl_dspath
            // 
            lbl_dspath.AutoSize = true;
            lbl_dspath.ForeColor = System.Drawing.Color.White;
            lbl_dspath.Location = new System.Drawing.Point(0, 0);
            lbl_dspath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_dspath.Name = "lbl_dspath";
            lbl_dspath.Size = new System.Drawing.Size(221, 15);
            lbl_dspath.TabIndex = 0;
            lbl_dspath.Text = "Choose a Folder - Dedicated Server Path:";
            // 
            // rtxt_dspath
            // 
            rtxt_dspath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtxt_dspath.BackColor = System.Drawing.Color.Silver;
            rtxt_dspath.Location = new System.Drawing.Point(4, 50);
            rtxt_dspath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_dspath.Multiline = false;
            rtxt_dspath.Name = "rtxt_dspath";
            rtxt_dspath.Size = new System.Drawing.Size(465, 26);
            rtxt_dspath.TabIndex = 1;
            rtxt_dspath.Text = "";
            rtxt_dspath.TextChanged += Rtxt_dspath_TextChanged;
            // 
            // btn_dspath
            // 
            btn_dspath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_dspath.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_dspath.ForeColor = System.Drawing.Color.White;
            btn_dspath.Location = new System.Drawing.Point(477, 50);
            btn_dspath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_dspath.Name = "btn_dspath";
            btn_dspath.Size = new System.Drawing.Size(163, 27);
            btn_dspath.TabIndex = 2;
            btn_dspath.Text = "Change";
            btn_dspath.UseVisualStyleBackColor = false;
            btn_dspath.Click += Btn_dspath_Click;
            // 
            // btn_dsinstall
            // 
            btn_dsinstall.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_dsinstall.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_dsinstall.ForeColor = System.Drawing.Color.White;
            btn_dsinstall.Location = new System.Drawing.Point(477, 83);
            btn_dsinstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_dsinstall.Name = "btn_dsinstall";
            btn_dsinstall.Size = new System.Drawing.Size(163, 27);
            btn_dsinstall.TabIndex = 3;
            btn_dsinstall.Text = "Install";
            btn_dsinstall.UseVisualStyleBackColor = false;
            btn_dsinstall.Click += Btn_dsinstall_Click;
            // 
            // btn_open_dspath
            // 
            btn_open_dspath.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_open_dspath.ForeColor = System.Drawing.Color.White;
            btn_open_dspath.Location = new System.Drawing.Point(4, 83);
            btn_open_dspath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_open_dspath.Name = "btn_open_dspath";
            btn_open_dspath.Size = new System.Drawing.Size(163, 27);
            btn_open_dspath.TabIndex = 4;
            btn_open_dspath.Text = "Open Folder";
            btn_open_dspath.UseVisualStyleBackColor = false;
            btn_open_dspath.Click += Btn_open_dspath_Click;
            // 
            // cb_game
            // 
            cb_game.BackColor = System.Drawing.Color.Silver;
            cb_game.FormattingEnabled = true;
            cb_game.Location = new System.Drawing.Point(4, 18);
            cb_game.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_game.Name = "cb_game";
            cb_game.Size = new System.Drawing.Size(349, 23);
            cb_game.TabIndex = 5;
            cb_game.SelectedIndexChanged += Cb_game_SelectedIndexChanged;
            // 
            // lbl_appid
            // 
            lbl_appid.AutoSize = true;
            lbl_appid.ForeColor = System.Drawing.Color.White;
            lbl_appid.Location = new System.Drawing.Point(360, 22);
            lbl_appid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_appid.Name = "lbl_appid";
            lbl_appid.Size = new System.Drawing.Size(40, 15);
            lbl_appid.TabIndex = 6;
            lbl_appid.Text = "APPID";
            // 
            // tab_steam
            // 
            tab_steam.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            tab_steam.Controls.Add(p_steam);
            tab_steam.Location = new System.Drawing.Point(4, 24);
            tab_steam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_steam.Name = "tab_steam";
            tab_steam.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_steam.Size = new System.Drawing.Size(670, 492);
            tab_steam.TabIndex = 4;
            tab_steam.Text = "SteamCMD";
            // 
            // p_steam
            // 
            p_steam.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            p_steam.Controls.Add(label1);
            p_steam.Controls.Add(btn_steamcmdinstall);
            p_steam.Controls.Add(btn_open_steamcmdpath);
            p_steam.Controls.Add(rtxt_steamcmdpath);
            p_steam.Controls.Add(btn_steamcmdpath);
            p_steam.Controls.Add(lbl_steamcmdpath);
            p_steam.Location = new System.Drawing.Point(14, 14);
            p_steam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            p_steam.Name = "p_steam";
            p_steam.Size = new System.Drawing.Size(643, 777);
            p_steam.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(4, 99);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(468, 15);
            label1.TabIndex = 7;
            label1.Text = "This is Steam as a Console (SteamCMD), it is required to download the Dedicated Server";
            // 
            // btn_steamcmdinstall
            // 
            btn_steamcmdinstall.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_steamcmdinstall.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_steamcmdinstall.ForeColor = System.Drawing.Color.White;
            btn_steamcmdinstall.Location = new System.Drawing.Point(476, 53);
            btn_steamcmdinstall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_steamcmdinstall.Name = "btn_steamcmdinstall";
            btn_steamcmdinstall.Size = new System.Drawing.Size(163, 27);
            btn_steamcmdinstall.TabIndex = 5;
            btn_steamcmdinstall.Text = "Install";
            btn_steamcmdinstall.UseVisualStyleBackColor = false;
            btn_steamcmdinstall.Click += Btn_steamcmdinstall_Click;
            // 
            // btn_open_steamcmdpath
            // 
            btn_open_steamcmdpath.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_open_steamcmdpath.ForeColor = System.Drawing.Color.White;
            btn_open_steamcmdpath.Location = new System.Drawing.Point(4, 53);
            btn_open_steamcmdpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_open_steamcmdpath.Name = "btn_open_steamcmdpath";
            btn_open_steamcmdpath.Size = new System.Drawing.Size(163, 27);
            btn_open_steamcmdpath.TabIndex = 6;
            btn_open_steamcmdpath.Text = "Open Folder";
            btn_open_steamcmdpath.UseVisualStyleBackColor = false;
            btn_open_steamcmdpath.Click += Btn_open_steamcmdpath_Click;
            // 
            // rtxt_steamcmdpath
            // 
            rtxt_steamcmdpath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtxt_steamcmdpath.BackColor = System.Drawing.Color.Silver;
            rtxt_steamcmdpath.Location = new System.Drawing.Point(4, 18);
            rtxt_steamcmdpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rtxt_steamcmdpath.Multiline = false;
            rtxt_steamcmdpath.Name = "rtxt_steamcmdpath";
            rtxt_steamcmdpath.ReadOnly = true;
            rtxt_steamcmdpath.Size = new System.Drawing.Size(464, 27);
            rtxt_steamcmdpath.TabIndex = 4;
            rtxt_steamcmdpath.Text = "";
            rtxt_steamcmdpath.TextChanged += Rtxt_steamcmdpath_TextChanged;
            // 
            // btn_steamcmdpath
            // 
            btn_steamcmdpath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_steamcmdpath.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_steamcmdpath.ForeColor = System.Drawing.Color.White;
            btn_steamcmdpath.Location = new System.Drawing.Point(476, 18);
            btn_steamcmdpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_steamcmdpath.Name = "btn_steamcmdpath";
            btn_steamcmdpath.Size = new System.Drawing.Size(163, 28);
            btn_steamcmdpath.TabIndex = 1;
            btn_steamcmdpath.Text = "Change";
            btn_steamcmdpath.UseVisualStyleBackColor = false;
            btn_steamcmdpath.Click += Btn_steamcmdpath_Click;
            // 
            // lbl_steamcmdpath
            // 
            lbl_steamcmdpath.AutoSize = true;
            lbl_steamcmdpath.ForeColor = System.Drawing.Color.White;
            lbl_steamcmdpath.Location = new System.Drawing.Point(0, 0);
            lbl_steamcmdpath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_steamcmdpath.Name = "lbl_steamcmdpath";
            lbl_steamcmdpath.Size = new System.Drawing.Size(193, 15);
            lbl_steamcmdpath.TabIndex = 3;
            lbl_steamcmdpath.Text = "Choose a Folder - SteamCMD Path:";
            // 
            // tab_about
            // 
            tab_about.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            tab_about.Controls.Add(lbl_allservers);
            tab_about.Controls.Add(btn_closeall);
            tab_about.Controls.Add(cb_alwaysontop);
            tab_about.Controls.Add(btn_donation);
            tab_about.Controls.Add(lbl_version2);
            tab_about.Controls.Add(lbl_lang);
            tab_about.Controls.Add(cb_lang);
            tab_about.Controls.Add(btn_tutorial);
            tab_about.Controls.Add(btn_discord);
            tab_about.Controls.Add(btn_website);
            tab_about.ForeColor = System.Drawing.Color.Transparent;
            tab_about.Location = new System.Drawing.Point(4, 24);
            tab_about.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_about.Name = "tab_about";
            tab_about.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tab_about.Size = new System.Drawing.Size(670, 492);
            tab_about.TabIndex = 2;
            tab_about.Text = "tab_about";
            // 
            // lbl_allservers
            // 
            lbl_allservers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lbl_allservers.AutoSize = true;
            lbl_allservers.Location = new System.Drawing.Point(13, 440);
            lbl_allservers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_allservers.Name = "lbl_allservers";
            lbl_allservers.Size = new System.Drawing.Size(70, 15);
            lbl_allservers.TabIndex = 11;
            lbl_allservers.Text = "LID_xservers";
            // 
            // btn_closeall
            // 
            btn_closeall.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_closeall.BackColor = System.Drawing.Color.Red;
            btn_closeall.ForeColor = System.Drawing.Color.White;
            btn_closeall.Location = new System.Drawing.Point(8, 458);
            btn_closeall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_closeall.Name = "btn_closeall";
            btn_closeall.Size = new System.Drawing.Size(187, 28);
            btn_closeall.TabIndex = 10;
            btn_closeall.Text = "LID_closeallservers";
            btn_closeall.UseVisualStyleBackColor = false;
            btn_closeall.Click += Btn_closeall_Click;
            // 
            // cb_alwaysontop
            // 
            cb_alwaysontop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_alwaysontop.Location = new System.Drawing.Point(468, 66);
            cb_alwaysontop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_alwaysontop.Name = "cb_alwaysontop";
            cb_alwaysontop.Size = new System.Drawing.Size(187, 20);
            cb_alwaysontop.TabIndex = 9;
            cb_alwaysontop.Text = "LID_alwaysontop";
            cb_alwaysontop.UseVisualStyleBackColor = true;
            cb_alwaysontop.CheckedChanged += Cb_alwaysontop_CheckedChanged;
            // 
            // btn_donation
            // 
            btn_donation.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_donation.Location = new System.Drawing.Point(161, 17);
            btn_donation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_donation.Name = "btn_donation";
            btn_donation.Size = new System.Drawing.Size(140, 29);
            btn_donation.TabIndex = 8;
            btn_donation.Text = "Donation";
            btn_donation.UseVisualStyleBackColor = false;
            btn_donation.Click += Btn_donation_Click;
            // 
            // lbl_version2
            // 
            lbl_version2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_version2.Location = new System.Drawing.Point(312, 458);
            lbl_version2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_version2.Name = "lbl_version2";
            lbl_version2.Size = new System.Drawing.Size(350, 27);
            lbl_version2.TabIndex = 7;
            lbl_version2.Text = "VERSION";
            lbl_version2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_lang
            // 
            lbl_lang.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbl_lang.Location = new System.Drawing.Point(468, 17);
            lbl_lang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_lang.Name = "lbl_lang";
            lbl_lang.Size = new System.Drawing.Size(141, 17);
            lbl_lang.TabIndex = 6;
            lbl_lang.Text = "LANGUAGE";
            // 
            // cb_lang
            // 
            cb_lang.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cb_lang.FormattingEnabled = true;
            cb_lang.Location = new System.Drawing.Point(468, 37);
            cb_lang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_lang.Name = "cb_lang";
            cb_lang.Size = new System.Drawing.Size(186, 23);
            cb_lang.TabIndex = 5;
            cb_lang.SelectedIndexChanged += Cb_lang_SelectedIndexChanged;
            // 
            // btn_tutorial
            // 
            btn_tutorial.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_tutorial.ForeColor = System.Drawing.Color.White;
            btn_tutorial.Location = new System.Drawing.Point(14, 53);
            btn_tutorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_tutorial.Name = "btn_tutorial";
            btn_tutorial.Size = new System.Drawing.Size(140, 29);
            btn_tutorial.TabIndex = 4;
            btn_tutorial.Text = "Tutorial";
            btn_tutorial.UseVisualStyleBackColor = false;
            btn_tutorial.Click += Btn_tutorial_Click;
            // 
            // btn_discord
            // 
            btn_discord.AutoSize = true;
            btn_discord.BackgroundImage = Properties.Resources.Discord_Logo_Color_70;
            btn_discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn_discord.FlatAppearance.BorderSize = 0;
            btn_discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_discord.Location = new System.Drawing.Point(14, 89);
            btn_discord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_discord.Name = "btn_discord";
            btn_discord.Size = new System.Drawing.Size(93, 92);
            btn_discord.TabIndex = 1;
            btn_discord.UseVisualStyleBackColor = true;
            btn_discord.Click += Btn_discord_Click_1;
            // 
            // btn_website
            // 
            btn_website.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_website.Location = new System.Drawing.Point(14, 17);
            btn_website.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_website.Name = "btn_website";
            btn_website.Size = new System.Drawing.Size(140, 29);
            btn_website.TabIndex = 0;
            btn_website.Text = "Website";
            btn_website.UseVisualStyleBackColor = false;
            btn_website.Click += Btn_website_Click;
            // 
            // lbl_version
            // 
            lbl_version.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_version.ForeColor = System.Drawing.Color.White;
            lbl_version.Location = new System.Drawing.Point(306, 10);
            lbl_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_version.Name = "lbl_version";
            lbl_version.Size = new System.Drawing.Size(350, 21);
            lbl_version.TabIndex = 0;
            lbl_version.Text = "LOADING VERSION";
            lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_version
            // 
            p_version.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            p_version.Controls.Add(btn_download);
            p_version.Controls.Add(lbl_version);
            p_version.Dock = System.Windows.Forms.DockStyle.Bottom;
            p_version.Location = new System.Drawing.Point(0, 519);
            p_version.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            p_version.Name = "p_version";
            p_version.Size = new System.Drawing.Size(670, 42);
            p_version.TabIndex = 1;
            // 
            // btn_download
            // 
            btn_download.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            btn_download.ForeColor = System.Drawing.Color.White;
            btn_download.Location = new System.Drawing.Point(7, 6);
            btn_download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_download.Name = "btn_download";
            btn_download.Size = new System.Drawing.Size(140, 29);
            btn_download.TabIndex = 5;
            btn_download.Text = "Download";
            btn_download.UseVisualStyleBackColor = false;
            btn_download.Click += Btn_download_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tt_ip
            // 
            tt_ip.Tag = "ip";
            tt_ip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            tt_ip.ToolTipTitle = "Clipboard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(670, 561);
            Controls.Add(p_version);
            Controls.Add(tabs);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(686, 140);
            Name = "Form1";
            Text = "[GDSM] GMod Dedicated Server Manager";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            tabs.ResumeLayout(false);
            tab_server.ResumeLayout(false);
            tab_properties.ResumeLayout(false);
            pProperties.ResumeLayout(false);
            pProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_maxplayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_port).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_workshopid).EndInit();
            tab_game.ResumeLayout(false);
            p_game.ResumeLayout(false);
            p_game.PerformLayout();
            gb_login.ResumeLayout(false);
            gb_login.PerformLayout();
            tab_steam.ResumeLayout(false);
            p_steam.ResumeLayout(false);
            p_steam.PerformLayout();
            tab_about.ResumeLayout(false);
            tab_about.PerformLayout();
            p_version.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_server;
        private System.Windows.Forms.TabPage tab_properties;
        private System.Windows.Forms.TabPage tab_about;
        private System.Windows.Forms.Button btn_steamcmdpath;
        private System.Windows.Forms.RichTextBox rtxt_steamcmdpath;
        private System.Windows.Forms.Label lbl_steamcmdpath;
        private System.Windows.Forms.Button btn_steamcmdinstall;
        private System.Windows.Forms.Button btn_dspath;
        private System.Windows.Forms.RichTextBox rtxt_dspath;
        private System.Windows.Forms.Label lbl_dspath;
        private System.Windows.Forms.Button btn_dsinstall;
        private System.Windows.Forms.Label lbl_maxplayers;
        private System.Windows.Forms.NumericUpDown nud_maxplayers;
        private System.Windows.Forms.NumericUpDown nud_workshopid;
        private System.Windows.Forms.RichTextBox rtxt_hostname;
        private System.Windows.Forms.Label lbl_workshopid;
        private System.Windows.Forms.Label lbl_gamemodes;
        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Label lbl_maps;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.Button btn_website;
        private System.Windows.Forms.Button btn_workshopid;
        private System.Windows.Forms.Button btn_discord;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_open_dspath;
        private System.Windows.Forms.Button btn_open_steamcmdpath;
        private System.Windows.Forms.Button btn_cmds;
        private System.Windows.Forms.Label lbl_addcmds;
        private System.Windows.Forms.RichTextBox rtxt_othercmds;
        private System.Windows.Forms.RichTextBox rtxt_servercfg;
        private System.Windows.Forms.Button btn_configs;
        private System.Windows.Forms.Label lbl_servercfg;
        private System.Windows.Forms.Panel pProperties;
        private System.Windows.Forms.Label lbl_porttext;
        private System.Windows.Forms.LinkLabel linklbl_tutorials;
        private System.Windows.Forms.Button btn_tutorial;
        private System.Windows.Forms.ComboBox cb_maps;
        private System.Windows.Forms.ComboBox cb_gamemodes;
        private System.Windows.Forms.RichTextBox rtxt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.RichTextBox rtxt_rconpassword;
        private System.Windows.Forms.Label lbl_rconpassword;
        private System.Windows.Forms.Label lbl_missingcontent;
        private System.Windows.Forms.ComboBox cb_game;
        private System.Windows.Forms.Label lbl_appid;
        private System.Windows.Forms.Button btn_safestart;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.TabPage tab_game;
        private System.Windows.Forms.TabPage tab_steam;
        private System.Windows.Forms.Panel p_game;
        private System.Windows.Forms.Panel p_steam;
        private System.Windows.Forms.Panel p_version;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lbl_lang;
        private System.Windows.Forms.ComboBox cb_lang;
        private System.Windows.Forms.LinkLabel linklbl_portcheck;
        private System.Windows.Forms.Label lbl_version2;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_loginname;
        private System.Windows.Forms.RichTextBox rtxt_loginpassword;
        private System.Windows.Forms.Label lbl_loginpassword;
        private System.Windows.Forms.RichTextBox rtxt_loginname;
        private System.Windows.Forms.Button btn_donation;
        private System.Windows.Forms.LinkLabel llbl_ip;
        private System.Windows.Forms.CheckBox cb_fixedconsolesize;
        private System.Windows.Forms.CheckBox cb_alwaysontop;
        private System.Windows.Forms.Label lbl_restartcode;
        private System.Windows.Forms.RichTextBox rtb_restartcode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_closeall;
        private System.Windows.Forms.Label lbl_allservers;
        private System.Windows.Forms.Button btn_deletegmas;
        private System.Windows.Forms.Button btn_gmas;
        private System.Windows.Forms.Label lbl_gmasize;
        private System.Windows.Forms.Label lbl_cachesize;
        private System.Windows.Forms.Button btn_deletecache;
        private System.Windows.Forms.ToolTip tt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

