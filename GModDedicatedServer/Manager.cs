//Copyright(C) 2019-2021 Arno Zura(https://www.gnu.org/licenses/gpl.txt)

using GModDedicatedServer.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Activities;
using Timer = System.Windows.Forms.Timer;

namespace GModDedicatedServer
{
    public partial class Form1 : Form
    {
        private string status = "stopped";

        private string status_steamcmd = "notinstalled";
        private int app_id = 4020;
        private bool beta = false;

        private bool Loaded { get; set; } = false;

        private GAME game;
        private List<GAME> GAMES { get; set; } = [];

        /* Languages */
        Languages L { get; set; } = new Languages();

        /* VERSION */
        VERSION Version { get; set; } = new VERSION();
        public string ver = "4,0";

        public void InitLanguage(string ls = "EN-EN")
        {
            L.InitLanguage(ls);

            // Server Page
            btn_start.Text = L.Phrase("LID_startserver");
            btn_safestart.Text = L.Phrase("LID_update") + " + " + L.Phrase("LID_startserver");
            btn_restart.Text = L.Phrase("LID_restartserver");
            cb_fixedconsolesize.Text = L.Phrase("LID_fixedconsolesize");

            // TABS
            tab_server.Text = L.Phrase("LID_server");
            tab_properties.Text = L.Phrase("LID_properties");
            tab_game.Text = L.Phrase("LID_dedicatedserver");
            tab_steam.Text = "SteamCMD"; //l.Phrase("LID_steam");
            tab_about.Text = L.Phrase("LID_about") + " + Language";

            lbl_steamcmdpath.Text = L.Phrase("LID_steamcmdpath") + ":";
            lbl_dspath.Text = L.Phrase("LID_dedicatedserverpath") + ":";

            btn_dspath.Text = L.Phrase("LID_change");
            btn_steamcmdpath.Text = L.Phrase("LID_change");

            btn_open_dspath.Text = L.Phrase("LID_openfolder");
            btn_open_steamcmdpath.Text = L.Phrase("LID_openfolder");

            btn_download.Text = L.Phrase("LID_download");

            // Properties Page
            lbl_hostname.Text = L.Phrase("LID_hostname");
            lbl_password.Text = L.Phrase("LID_password");
            lbl_rconpassword.Text = L.Phrase("LID_adminpassword") + " (RCON)";
            lbl_maxplayers.Text = L.Phrase("LID_maxplayers");
            lbl_port.Text = L.Phrase("LID_port");
            lbl_workshopid.Text = L.Phrase("LID_workshopid");
            lbl_gamemodes.Text = L.Phrase("LID_gamemode");
            lbl_maps.Text = L.Phrase("LID_map");
            lbl_addcmds.Text = L.Phrase("LID_additionalcmds");
            lbl_servercfg.Text = "server.cfg (" + L.Phrase("LID_configfile") + ")";
            btn_workshopid.Text = L.Phrase("LID_opencollection");
            btn_cmds.Text = L.Phrase("LID_commands");
            btn_configs.Text = L.Phrase("LID_configs");
            lbl_missingcontent.Text = L.Phrase("LID_missingcontent") + " => " + L.Phrase("LID_restartserver");
            btn_deletegmas.Text = L.Phrase("LID_deletegmas");
            btn_deletecache.Text = L.Phrase("LID_deletecache");

            // Dedicated Server Page
            lbl_loginname.Text = L.Phrase("LID_name");
            lbl_loginpassword.Text = L.Phrase("LID_password");
            gb_login.Text = L.Phrase("LID_login");

            // About Page
            cb_alwaysontop.Text = L.Phrase("LID_alwaysontop");
            btn_closeall.Text = L.Phrase("LID_closeallservers");
        }

        private void CheckGame()
        {
            string s_id = cb_game.Text;
            if (s_id.Contains("beta", StringComparison.CurrentCultureIgnoreCase))
            {
                beta = true;
            }
            else
            {
                beta = false;
            }
            s_id = s_id[(s_id.IndexOf('[') + 1)..];
            s_id = s_id[..s_id.IndexOf(']')];
            app_id = System.Convert.ToInt32(s_id);

            foreach (var g in GAMES)
            {
                if (g.app_id == app_id)
                {
                    game = g;
                    lbl_appid.Text = app_id.ToString();
                }
            }
        }

        private delegate void SafeCallDelegate();

        public void CheckStatus()
        {
            if (btn_start.InvokeRequired)
            {
                var d = new SafeCallDelegate(CheckStatus);
                _ = Invoke(d, []);
            }
            else
            {
                CheckGame();

                try
                {
                    if (game.app_id == 4020)
                    {
                        lbl_gamemodes.Visible = true;
                        cb_gamemodes.Visible = true;
                    }
                    else
                    {
                        lbl_gamemodes.Visible = false;
                        cb_gamemodes.Visible = false;
                    }

                    /*if (game.path_name != "")
                    {
                        btn_start.Visible = true;
                        btn_start.Enabled = true;
                        btn_safestart.Visible = true;
                        btn_safestart.Enabled = true;
                    }
                    else
                    {
                        btn_start.Visible = false;
                        btn_start.Enabled = false;
                        btn_safestart.Visible = false;
                        btn_safestart.Enabled = false;
                    }*/

                    if (game.requirelogin)
                    {
                        gb_login.Visible = true;
                    }
                    else
                    {
                        gb_login.Visible = false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                rtxt_steamcmdpath.Text = Settings.Default["steamcmdpath"].ToString();
                if (File.Exists(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.exe"))
                {
                    status_steamcmd = "installed";
                    btn_steamcmdinstall.Text = L.Phrase("LID_update");
                    if (!tabs.TabPages.Contains(tab_game))
                    {
                        tabs.TabPages.Insert(0, tab_game);
                    }
                }
                else
                {
                    status_steamcmd = "notinstalled";
                    btn_steamcmdinstall.Text = L.Phrase("LID_install");
                    tabs.TabPages.Remove(tab_game);
                }

                rtxt_dspath.Text = Settings.Default["dspath"].ToString();
                if (File.Exists(rtxt_dspath.Text + Path.DirectorySeparatorChar + "srcds.exe"))
                {
                    btn_dsinstall.Text = L.Phrase("LID_update");
                    if (game.path_name != "")
                    {
                        if (!tabs.TabPages.Contains(tab_properties))
                        {
                            tabs.TabPages.Insert(0, tab_properties);
                        }

                        if (game.app_id == 4020)
                        {
                            lbl_hostname.Visible = true;
                            rtxt_hostname.Visible = true;

                            lbl_password.Visible = true;
                            rtxt_password.Visible = true;
                            lbl_rconpassword.Visible = true;
                            rtxt_rconpassword.Visible = true;

                            lbl_maxplayers.Visible = true;
                            nud_maxplayers.Visible = true;

                            lbl_port.Visible = true;
                            nud_port.Visible = true;
                            lbl_porttext.Visible = true;
                            linklbl_tutorials.Visible = true;
                            linklbl_portcheck.Visible = true;

                            lbl_workshopid.Visible = true;
                            nud_workshopid.Visible = true;
                            btn_workshopid.Visible = true;

                            lbl_gamemodes.Visible = true;
                            cb_gamemodes.Visible = true;

                            lbl_maps.Visible = true;
                            cb_maps.Visible = true;

                            lbl_missingcontent.Visible = true;
                        }
                        else
                        {
                            lbl_hostname.Visible = false;
                            rtxt_hostname.Visible = false;

                            lbl_password.Visible = false;
                            rtxt_password.Visible = false;
                            lbl_rconpassword.Visible = false;
                            rtxt_rconpassword.Visible = false;

                            lbl_maxplayers.Visible = false;
                            nud_maxplayers.Visible = false;

                            lbl_port.Visible = false;
                            nud_port.Visible = false;
                            lbl_porttext.Visible = false;
                            linklbl_tutorials.Visible = false;
                            linklbl_portcheck.Visible = false;

                            lbl_workshopid.Visible = false;
                            nud_workshopid.Visible = false;
                            btn_workshopid.Visible = false;

                            lbl_gamemodes.Visible = false;
                            cb_gamemodes.Visible = false;

                            lbl_maps.Visible = false;
                            cb_maps.Visible = false;

                            lbl_missingcontent.Visible = false;
                        }
                    }
                    else
                    {
                        tabs.TabPages.Remove(tab_properties);
                    }
                    if (!tabs.TabPages.Contains(tab_server))
                    {
                        tabs.TabPages.Insert(0, tab_server);
                    }

                }
                else
                {
                    btn_dsinstall.Text = L.Phrase("LID_install");
                    tabs.TabPages.Remove(tab_properties);
                    tabs.TabPages.Remove(tab_server);
                }
            }

            CalculateGMASize();
            CalculateCacheSize();
        }

        public void UpdateServerCfg()
        {
            try
            {
                string dsc = Path.DirectorySeparatorChar.ToString();
                string file = rtxt_dspath.Text + dsc + game.path_name + dsc + "cfg" + dsc + "server.cfg";
                if (File.Exists(file))
                {
                    string[] servercfg = File.ReadAllLines(file, Encoding.UTF8);
                    for (int i = 0; i < servercfg.Length; i++)
                    {
                        rtxt_servercfg.AppendText(servercfg[i] + "\n");
                    }
                }
            }
            catch
            {

            }
        }

        private void SetVersionText(string versiontext, Color versioncolor)
        {
            lbl_version.Text = versiontext;
            lbl_version.ForeColor = versioncolor;

            lbl_version2.Text = versiontext;
            lbl_version2.ForeColor = versioncolor;
        }

        public async void CheckVersion()
        {
            await Version.CheckVersion();

            if (Version.IsOutdated())
            {
                tabs.Height = this.Height - 35 - 36;
                p_version.Height = 36;
                Color txtColor = Color.FromArgb(255, 0, 0);
                SetVersionText("Current Version: " + Version.GetLocalVersion() + " (Newest Version: " + Version.GetOnlineVersion() + ")", txtColor);
            }
            else
            {
                tabs.Height = this.Height - 35;
                p_version.Height = 0;
                Color txtColor = Color.FromArgb(0, 255, 0);
                SetVersionText("Version: " + Version.GetLocalVersion(), txtColor);
            }

            CalculateGMASize();
            CalculateCacheSize();
        }

        public Form1()
        {
            InitializeComponent();

            L.pclang = Settings.Default.language;

            cb_lang.DataSource = new BindingSource(L.LANGUAGES, null);
            cb_lang.DisplayMember = "Value";
            cb_lang.ValueMember = "Key";
            cb_lang.SelectedValue = L.pclang;

            InitLanguage(L.pclang);

            // A
            GAMES.Add(new GAME(376030, "ARK: Survival Evolved", "", "start ShooterGameServer.exe \"TheIsland ? listen ? ServerCrosshair = True ? AllowThirdPersonPlayer = True ? MapPlayerLocation = True ? TheMaxStructuresInRange = 100\" -UseBattlEye", false));

            // C
            GAMES.Add(new GAME(740, "Counter-Strike Global Offensive", "csgo", "srcds -game csgo -console -usercon +game_type 0 +game_mode 0 +mapgroup mg_active +map de_dust2", false));

            // D
            GAMES.Add(new GAME(2145, "Dark Messiah of Might & Magic", "", "+maxplayers 32", true));
            GAMES.Add(new GAME(90, "Day of Defeat", "dod", "-console -game dod -secure +map dod_anzio -autoupdate +log on +maxplayers 32 -port 27015", false));
            GAMES.Add(new GAME(232290, "Day of Defeat: Source", "dods", "-console -game dods -secure +map dod_anzio -autoupdate +log on +maxplayers 32 -port 27015", false));
            GAMES.Add(new GAME(223350, "DayZ", "", "", true));

            // G
            GAMES.Add(new GAME(4020, "Garry's Mod", "garrysmod", "", false));
            GAMES.Add(new GAME(4020, "Garry's Mod BETA PRERELEASE", "garrysmod", "", false));

            // L
            GAMES.Add(new GAME(222860, "Left 4 Dead 2", "left4dead2", "", false));
            GAMES.Add(new GAME(222840, "Left 4 Dead", "left4dead", "", false));

            // R
            GAMES.Add(new GAME(258550, "Rust", "", "", false));

            // S
            GAMES.Add(new GAME(403240, "Squad", "", "", false));

            // T
            GAMES.Add(new GAME(232250, "Team Fortress 2", "tf2", "", false));
            GAMES.Add(new GAME(556450, "The Forest", "", "", false));

            // U
            GAMES.Add(new GAME(304930, "Unturned", "", "", true));

            llbl_ip.Text = "LOADING";

            rtxt_hostname.Text = Settings.Default.hostname;
            cb_gamemodes.Text = Settings.Default.gamemode;
            nud_workshopid.Value = Settings.Default.workshopid;
            nud_maxplayers.Value = Settings.Default.maxplayers;
            cb_maps.Text = Settings.Default.map;
            nud_port.Value = Settings.Default.port;
            rtxt_othercmds.Text = Settings.Default.othercmds;
            rtxt_password.Text = Settings.Default.password;
            rtxt_rconpassword.Text = Settings.Default.rconpassword;
            rtb_restartcode.Text = Settings.Default.restartcode;

            cb_fixedconsolesize.Checked = Settings.Default.fixedconsolesize;
            cb_alwaysontop.Checked = Settings.Default.alwaysontop;

            SetMaxMinSize();
            SetAlwaysOnTop();

            foreach (var game in GAMES)
            {
                cb_game.Items.Add(game.name + " [" + game.app_id + "]");
            }
            cb_game.Text = Settings.Default.game;

            CheckStatus();

            UpdateServerCfg();

            Version.SetVersion(ver);
            CheckVersion();

            Loaded = true;
        }

        Timer Timer { get; set; } = new();
        bool restart = false;

        async void Timer_TickAsync(object sender, EventArgs e)
        {
            string file = rtxt_dspath.Text + Path.DirectorySeparatorChar + "garrysmod" + Path.DirectorySeparatorChar + "data" + Path.DirectorySeparatorChar + "drs" + Path.DirectorySeparatorChar + "restart.txt";
            if (File.Exists(file) && !restart && Loaded && status == "started")
            {
                string text = File.ReadAllText(file);
                if (text == rtb_restartcode.Text)
                {
                    restart = true;
                    File.Delete(file);
                    await ClickStart(e, true, false, true, true);
                    restart = false;
                }
                else
                {
                    MessageBox.Show("Wrong restartcode");
                }
            }

            int srcdscount = 0;
            foreach (Process Proc in Process.GetProcesses())
            {
                if (Proc.ProcessName.Equals("srcds"))
                {
                    srcdscount++;
                }
            }
            lbl_allservers.Text = srcdscount + " Servers are running.";
        }

        private async Task UpdateIPAsync()
        {
            var ip = await IP.GetPublicIP();
            llbl_ip.Text = ip + ":" + nud_port.Value;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            Timer.Tick += new EventHandler(Timer_TickAsync); // Everytime timer ticks, timer_Tick will be called
            Timer.Interval = (1000) * (1);              // Timer will tick evert second
            Timer.Enabled = true;                       // Enable the timer
            Timer.Start();

            await UpdateIPAsync();

            tt_ip.SetToolTip(llbl_ip, "Click to copy to Clipboard!");
            tt_ip.ShowAlways = true;
        }

        private Process pDocked;
        private IntPtr hWndOriginalParent;
        private IntPtr hWndDocked;

        private async void Btn_start_Click(object sender, EventArgs e)
        {
            await ClickStart(e, true, false, false, false);
        }

        private delegate void SafeStopServer();
        private void StopServer()
        {
            if (btn_start.InvokeRequired)
            {
                if (status == "started")
                {
                    var d = new SafeStopServer(StopServer);
                    _ = Invoke(d, []);
                }
            }
            else
            {
                if (status == "started")
                {
                    try
                    {
                        status = "stoping";
                        btn_start.Visible = false;
                        btn_safestart.Visible = false;
                        btn_restart.Visible = false;

                        if (pDocked != null)
                        {
                            try
                            {
                                UnDockIt();
                                pDocked.Kill();
                            }
                            catch
                            {
                                //
                            }
                            finally
                            {
                                pDocked = null;
                                hWndOriginalParent = IntPtr.Zero;
                                hWndDocked = IntPtr.Zero;
                            }
                        }

                        btn_start.Text = L.Phrase("LID_startserver");
                        btn_safestart.Text = "Update + Start Server";
                        btn_start.Visible = true;
                        btn_safestart.Visible = true;
                        btn_restart.Visible = false;
                        btn_start.BackColor = Color.FromArgb(0, 255, 0);
                        btn_safestart.BackColor = Color.FromArgb(0, 255, 0);

                        status = "stopped";

                        CheckVersion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("[StopServer] Exit process failed: " + ex.Message.ToString());
                    }
                }
            }
        }

        private async Task ClickStart(System.EventArgs e, bool parameters, bool updateServer, bool restartServer, bool drs)
        {
            bool IsMouse = (e is System.Windows.Forms.MouseEventArgs);

            if (!IsMouse)
            {
                if (!drs)
                {
                    return;
                }
            }
            if (pDocked == null)
            {
                try
                {
                    status = "starting";

                    btn_start.Visible = false;
                    btn_safestart.Visible = false;
                    btn_restart.Visible = false;

                    if (updateServer)
                    {
                        await UpdateDSAsync();
                    }

                    CheckVersion();

                    if (nud_workshopid.Value > 0)
                    {
                        string cid_txt = rtxt_dspath.Text + Path.DirectorySeparatorChar + "collectionid.txt";
                        File.Delete(cid_txt);
                        StreamWriter tw = new(cid_txt, true);
                        tw.Write("+host_workshop_collection " + nud_workshopid.Value + " ");
                        tw.Close();
                    }
                    else
                    {
                        MessageBox.Show("No CollectionID found!");
                    }
                    DockIt(parameters);
                    btn_start.Text = L.Phrase("LID_stopserver");
                    btn_safestart.Text = L.Phrase("LID_stopserver");
                    btn_start.Visible = true;
                    btn_safestart.Visible = false;
                    btn_restart.Visible = true;
                    btn_start.BackColor = Color.FromArgb(255, 0, 0);
                    btn_safestart.BackColor = Color.FromArgb(255, 0, 0);

                    status = "started";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[ClickStart:1] Starting process failed: " + ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    StopServer();

                    if (restartServer)
                    {
                        await ClickStart(e, parameters, updateServer, false, drs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[ClickStart:2] Starting process failed: " + ex.Message.ToString());
                }
            }
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            if (pDocked != null)
            {
                try
                {
                    UnDockIt();
                    pDocked.Kill();
                    pDocked = null;
                    hWndOriginalParent = IntPtr.Zero;
                    hWndDocked = IntPtr.Zero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[OnProcessExit] Exit process failed: " + ex.Message.ToString());
                }
            }
        }

        [LibraryImport("user32.dll")]
        private static partial IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [LibraryImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);

        private void DockIt(bool parameters)
        {
            try
            {
                if (hWndDocked != IntPtr.Zero) //don't do anything if there's already a window docked.
                    return;

                string startcmd = "";
                if (rtxt_hostname.Text != "")
                {
                    startcmd += "+hostname \"" + rtxt_hostname.Text + "\" ";
                }
                if (nud_maxplayers.Value != 0)
                {
                    startcmd += "+maxplayers " + nud_maxplayers.Value + " ";
                }
                if (game.app_id == 4020)
                {
                    if (nud_workshopid.Value != 0)
                    {
                        startcmd += "+host_workshop_collection " + nud_workshopid.Value + " ";
                    }
                }
                if (cb_gamemodes.Text != "")
                {
                    if (game.app_id == 4020)
                    {
                        startcmd += "+gamemode \"" + cb_gamemodes.Text + "\" ";
                    }
                }
                if (cb_maps.Text != "")
                {
                    startcmd += "+map \"" + cb_maps.Text + "\" ";
                }
                if (nud_port.Value != 0)
                {
                    startcmd += "-port " + nud_port.Value + " ";
                }
                if (rtxt_othercmds.Text != "")
                {
                    startcmd += rtxt_othercmds.Text + " ";
                }
                if (rtxt_password.Text != "")
                {
                    startcmd += "+sv_password \"" + rtxt_password.Text + "\" ";
                }
                if (rtxt_rconpassword.Text != "")
                {
                    startcmd += "+rcon_password \"" + rtxt_rconpassword.Text + "\" ";
                }

                startcmd += "-autoupdate -console";

                if (!parameters)
                {
                    startcmd = "+map " + cb_maps.Text + " " + "-autoupdate -console";
                }

                if (game.app_id == 740)
                {
                    startcmd = rtxt_othercmds.Text + " ";
                }

                //MessageBox.Show(startcmd);

                pDocked = Process.Start(rtxt_dspath.Text + Path.DirectorySeparatorChar + "srcds", startcmd.ToString());
                while (hWndDocked == IntPtr.Zero)
                {
                    pDocked.WaitForInputIdle(0); //wait for the window to be ready for input;
                    pDocked.Refresh();              //update process info
                    if (pDocked.HasExited)
                    {
                        return; //abort if the process finished before we got a handle.
                    }
                    hWndDocked = pDocked.MainWindowHandle;  //cache the window handle

                    pDocked.EnableRaisingEvents = true;
                    pDocked.Exited += (sender, e) =>
                    {
                        StopServer();
                    };
                }
                //Windows API call to change the parent of the target window.
                //It returns the hWnd of the window's parent prior to this call.
                hWndOriginalParent = SetParent(hWndDocked, panel1.Handle);

                //Wire up the event to keep the window sized to match the control
                panel1.SizeChanged += new EventHandler(Panel1_Resize);
                //Perform an initial call to set the size.
                Panel1_Resize(new Object(), new EventArgs());

                Panel1_Resize(new Object(), new EventArgs());
            }
            catch (Exception e)
            {
                if (e.HResult.GetHashCode() == -2147467259)
                {
                    MessageBox.Show("[DockIt] Server not installed or not found!");
                }
                else
                {
                    MessageBox.Show("[DockIt] " + e.Message.ToString());
                }
            }
        }

        private void UnDockIt()
        {
            //Restores the application to it's original parent.
            SetParent(hWndDocked, hWndOriginalParent);
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            //Change the docked windows size to match its parent's size. 
            MoveWindow(hWndDocked, -8, -31, panel1.Width + 16, panel1.Height + 39, true);
        }

        private void Btn_steamcmdpath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new()
                {
                    RootFolder = Environment.SpecialFolder.Desktop
                };
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Settings.Default["steamcmdpath"] = fbd.SelectedPath;
                    Settings.Default.Save();
                    rtxt_steamcmdpath.Text = fbd.SelectedPath;

                    fbd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CheckStatus();
        }

        private async Task DownloadSteamCMD()
        {
            try
            {
                using (HttpClient client = new())
                {
                    using HttpResponseMessage response = await client.GetAsync("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip");
                    using var stream = await response.Content.ReadAsStreamAsync();
                    using Stream zip = File.OpenWrite(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.zip");
                    stream.CopyTo(zip);
                }

                try
                {
                    ZipFile.ExtractToDirectory(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.zip", rtxt_steamcmdpath.Text);
                    try
                    {
                        File.Delete(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.zip");
                    }
                    catch
                    {
                        MessageBox.Show("Starting SteamCMD failed");
                    }
                    finally
                    {
                        UpdateSteamCMD();
                    }
                }
                catch
                {
                    MessageBox.Show("FAILED Extract");
                }
                finally
                {
                    CheckStatus();
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        private void Btn_steamcmdinstall_Click(object sender, EventArgs e)
        {
            if (status_steamcmd == "installed")
            {
                UpdateSteamCMD();
            }
            else
            {
                try
                {
                    if (rtxt_steamcmdpath.Text != "")
                    {
                        if (Directory.Exists(rtxt_steamcmdpath.Text))
                        {
                            //wc_steamcmd.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                            //Uri zipurl = new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip");
                            //wc_steamcmd.DownloadFileAsync(zipurl, rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.zip");

                            _ = DownloadSteamCMD();
                        }
                        else
                        {
                            MessageBox.Show(L.Phrase("LID_pathdoesnotexists") + "! (" + rtxt_steamcmdpath.Text + ")");
                        }
                    }
                    else
                    {
                        MessageBox.Show("First choose a path!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void UpdateSteamCMD()
        {
            try
            {
                Process scmd = Process.Start(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd", "+quit");
                scmd.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateSteamCMD failed: " + ex.Message.ToString());
            }
            finally
            {
                CheckStatus();
            }
        }

        private async Task<int> UpdateDSAsync()
        {

            try
            {

                if (rtxt_steamcmdpath.Text != "")
                {
                    string fileName = rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd";
                    string args = "steamcmd.exe +force_install_dir \"" + rtxt_dspath.Text + "\" +login Anonymous +app_update " + app_id + " validate +quit";
                    if (game.requirelogin)
                    {
                        if (beta)
                        {
                            args = "steamcmd.exe +force_install_dir \"" + rtxt_dspath.Text + "\" +login " + rtxt_loginname.Text + " " + rtxt_loginpassword.Text + " +app_update " + app_id + " -beta prerelease validate";
                        }
                        else
                        {
                            args = "steamcmd.exe +force_install_dir \"" + rtxt_dspath.Text + "\" +login " + rtxt_loginname.Text + " " + rtxt_loginpassword.Text + " +app_update " + app_id + " validate";
                        }
                    }
                    using var process = new Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = false;

                    process.Start();

                    await process.WaitForExitAsync();

                    return process.ExitCode;
                }
                else
                {
                    MessageBox.Show("First choose a path!");
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.GetHashCode() == -2147467259)
                {
                    MessageBox.Show("SteamCMD not installed or not found!");
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            finally
            {
                CheckStatus();
            }
            return 0;
        }

        private async void Btn_dsinstall_Click(object sender, EventArgs e)
        {
            await UpdateDSAsync();
        }

        private void Btn_dspath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new()
                {
                    RootFolder = Environment.SpecialFolder.Desktop
                };
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Settings.Default["dspath"] = fbd.SelectedPath;
                    Settings.Default.Save();
                    rtxt_dspath.Text = fbd.SelectedPath;

                    fbd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CheckStatus();
        }

        private void Rtxt_hostname_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["hostname"] = rtxt_hostname.Text;
            Settings.Default.Save();
        }

        private void Nud_workshopid_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["workshopid"] = Convert.ToUInt32(nud_workshopid.Value);
            Settings.Default.Save();
        }

        private void Nud_maxplayers_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["maxplayers"] = Convert.ToUInt32(nud_maxplayers.Value);
            Settings.Default.Save();
        }

        private async void Nud_port_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["port"] = Convert.ToUInt32(nud_port.Value);
            Settings.Default.Save();

            await UpdateIPAsync();
        }

        private void Btn_website_Click(object sender, EventArgs e)
        {
            try
            {
                var ps = new ProcessStartInfo("https://sites.google.com/view/gdsm/home")
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_workshopid_Click(object sender, EventArgs e)
        {
            try
            {
                var ps = new ProcessStartInfo("https://steamcommunity.com/sharedfiles/filedetails/?id=" + Convert.ToString(nud_workshopid.Value))
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_discord_Click_1(object sender, EventArgs e)
        {
            try
            {
                var ps = new ProcessStartInfo("https://discord.gg/a6M2ZGC")
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rtxt_dspath_TextChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void Rtxt_steamcmdpath_TextChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void Btn_open_dspath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(rtxt_dspath.Text))
            {
                Process.Start("explorer.exe", rtxt_dspath.Text);
            }
            else
            {
                MessageBox.Show(L.Phrase("LID_pathdoesnotexists") + "! (" + rtxt_dspath.Text + ")");
            }
        }

        private void Btn_open_steamcmdpath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(rtxt_steamcmdpath.Text))
            {
                Process.Start("explorer.exe", rtxt_steamcmdpath.Text);
            }
            else
            {
                MessageBox.Show(L.Phrase("LID_pathdoesnotexists") + "! (" + rtxt_steamcmdpath.Text + ")");
            }
        }

        private void Btn_cmds_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://developer.valvesoftware.com/wiki/Command_Line_Options")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void Rtxt_othercmds_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["othercmds"] = rtxt_othercmds.Text;
            Settings.Default.Save();
        }

        private void Rtxt_servercfg_TextChanged(object sender, EventArgs e)
        {
            string dsc = Path.DirectorySeparatorChar.ToString();
            string file = rtxt_dspath.Text + dsc + game.path_name + dsc + "cfg" + dsc + "server.cfg";
            File.WriteAllText(file, rtxt_servercfg.Text);
        }

        private void Btn_start_Enter(object sender, EventArgs e)
        {
            // Nothing
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.youtube.com/results?search_query=port+forwarding+tutorial")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void Btn_tutorial_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://sites.google.com/view/gdsm/tutorials")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void Btn_configs_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", rtxt_dspath.Text + Path.DirectorySeparatorChar + game.path_name + Path.DirectorySeparatorChar + "cfg");
        }

        private static char DSC()
        {
            return Path.DirectorySeparatorChar;
        }

        private void Cb_gamemodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default["gamemode"] = cb_gamemodes.Text;
            Settings.Default.Save();
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default["map"] = cb_maps.Text;
            Settings.Default.Save();
        }

        private void Cb_maps_Enter(object sender, EventArgs e)
        {
            try
            {
                cb_maps.Items.Clear();
                String mapsfolder = rtxt_dspath.Text + DSC() + game.path_name + DSC() + "maps";
                var files = Directory.GetFiles(mapsfolder);
                foreach (var file in files)
                {
                    if (Path.GetExtension(file) == ".bsp")
                    {
                        String map = file[(file.LastIndexOf(DSC()) + 1)..];
                        map = map[..map.IndexOf(".bsp")];

                        if (!cb_maps.Items.Contains(map))
                        {
                            cb_maps.Items.Add(map);
                        }
                    }
                }

                String addonmapsfolder = rtxt_dspath.Text + DSC() + game.path_name + DSC() + "downloadlists";
                files = Directory.GetFiles(addonmapsfolder);
                foreach (var file in files)
                {
                    if (Path.GetExtension(file) == ".lst")
                    {
                        if (new FileInfo(file).Length > 0)
                        {
                            var textfile = File.ReadAllText(file);
                            String map = textfile[(textfile.LastIndexOf("maps/") + 7)..];
                            map = map[..map.IndexOf(".bsp")];

                            if (!cb_maps.Items.Contains(map))
                            {
                                cb_maps.Items.Add(map);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_gamemodes_Enter(object sender, EventArgs e)
        {
            try
            {
                cb_gamemodes.Items.Clear();
                if (!cb_gamemodes.Items.Contains("yourrp"))
                {
                    cb_gamemodes.Items.Add("yourrp");
                }

                String gmsfolder = rtxt_dspath.Text + DSC() + game.path_name + DSC() + "gamemodes";
                var folders = Directory.GetDirectories(gmsfolder);
                foreach (var folder in folders)
                {
                    String gm = folder[(folder.LastIndexOf(DSC()) + 1)..];

                    if (!cb_gamemodes.Items.Contains(gm))
                    {
                        cb_gamemodes.Items.Add(gm);
                    }
                }

                String gmafolder = rtxt_dspath.Text + DSC() + game.path_name + DSC() + "cache" + DSC() + "srcds";
                var files = Directory.GetFiles(gmafolder);
                foreach (var file in files)
                {
                    string filename = Path.GetFileName(file);
                    if (filename.StartsWith("1477562256"))
                    {
                        var gms = new List<string>
                        {
                            "1942rp",
                            "alienrp",
                            "bmrp",
                            "cityrp",
                            "darkrp",
                            "doomrp",
                            "falloutrp",
                            "gothamrp",
                            "halorp",
                            "hl2rp",
                            "hogwartsrp",
                            "kingdomrp",
                            "mangarp",
                            "medievalrp",
                            "mexicanborderrp",
                            "metrorp",
                            "militaryrp",
                            "pokemonrp",
                            "prisonrp",
                            "omerp",
                            "santosrp",
                            "schoolrp",
                            "scprp",
                            "spacerp",
                            "stargaterp",
                            "starwarsrp",
                            "warcraftrp",
                            "zombierp"
                        };
                        foreach (var gm in gms)
                        {
                            if (!cb_gamemodes.Items.Contains(gm))
                            {
                                cb_gamemodes.Items.Add(gm);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rtxt_password_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["password"] = rtxt_password.Text;
            Settings.Default.Save();
        }

        private void Rtxt_rconpassword_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["rconpassword"] = rtxt_rconpassword.Text;
            Settings.Default.Save();
        }

        private void Cb_game_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default["game"] = cb_game.Text;
            Settings.Default.Save();
            CheckStatus();
        }

        private void Btn_startwp_Enter(object sender, EventArgs e)
        {
            // nothing
        }

        private async Task Btn_startwp_ClickAsync(object sender, EventArgs e)
        {
            await ClickStart(e, false, false, false, false);
        }

        private async void Btn_safestart_Click(object sender, EventArgs e)
        {
            await ClickStart(e, true, true, false, false);
        }

        private async void Btn_restart_Click(object sender, EventArgs e)
        {
            await ClickStart(e, true, false, true, false);
        }

        private void Btn_download_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://sites.google.com/view/gdsm/downloads")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void Cb_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                try
                {
                    string key = ((KeyValuePair<string, string>)cb_lang.SelectedItem).Key;
                    InitLanguage(key);
                }
                catch
                {

                }
            }
        }

        private void Btn_donation_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.paypal.me/D4KiR")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private static String RemoveString(String inS, String seS)
        {
            String result = inS;
            if (result.Contains(seS, StringComparison.CurrentCulture))
            {
                result = result.Replace(seS, string.Empty);
            }
            else
            {
                return result;
            }
            return RemoveString(result, seS);
        }

        private void Btn_start_Paint(object sender, PaintEventArgs e)
        {
            Size s = TextRenderer.MeasureText(btn_start.Text, btn_start.Font);
            btn_start.Width = s.Width + 12;

            Size s2 = TextRenderer.MeasureText(btn_safestart.Text, btn_safestart.Font);
            btn_safestart.Width = s2.Width + 12;

            Size s3 = TextRenderer.MeasureText(btn_restart.Text, btn_restart.Font);
            btn_restart.Width = s3.Width + 12;

            btn_safestart.Location = new Point(btn_start.Location.X + btn_start.Width + 6, btn_start.Location.Y);

            btn_restart.Location = new Point(btn_start.Location.X + btn_start.Width + 6, btn_start.Location.Y);

            SetMaxMinSize();
        }

        private void Llbl_ip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(llbl_ip.Text);
        }

        private void SetMaxMinSize()
        {
            if (cb_fixedconsolesize.Checked)
            {
                this.MaximumSize = new Size(696, int.MaxValue);
                this.MinimumSize = new Size(696, 200);
            }
            else
            {
                this.MaximumSize = new Size(0, 0);
                this.MinimumSize = new Size(696, 200);
            }
        }

        private void Cb_fixedconsolesize_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["fixedconsolesize"] = cb_fixedconsolesize.Checked;
            Settings.Default.Save();
            SetMaxMinSize();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            SetMaxMinSize();
        }

        private void SetAlwaysOnTop()
        {
            TopMost = cb_alwaysontop.Checked;
        }

        private void Cb_alwaysontop_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["alwaysontop"] = cb_alwaysontop.Checked;
            Settings.Default.Save();
            SetAlwaysOnTop();
        }

        private void Cb_gamemodes_TextUpdate(object sender, EventArgs e)
        {
            Settings.Default["gamemode"] = cb_gamemodes.Text;
            Settings.Default.Save();
        }

        private void Cb_maps_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["map"] = cb_maps.Text;
            Settings.Default.Save();
        }

        private void Rtb_restartcode_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["restartcode"] = rtb_restartcode.Text;
            Settings.Default.Save();
        }

        private void Btn_closeall_Click(object sender, EventArgs e)
        {
            foreach (Process Proc in Process.GetProcesses())
            {
                if (Proc.ProcessName.Equals("srcds"))
                {
                    Proc.Kill();
                }
            }
        }

        private void Btn_gmas_Click(object sender, EventArgs e)
        {
            string gmafolder = rtxt_dspath.Text + DSC() + "garrysmod" + DSC() + "cache" + DSC() + "srcds";
            if (Directory.Exists(gmafolder))
            {
                Process.Start("explorer.exe", gmafolder);
            }
            else
            {
                MessageBox.Show(L.Phrase("LID_pathdoesnotexists") + "! (" + gmafolder + ")");
            }
        }

        private void Btn_deletegmas_Click(object sender, EventArgs e)
        {
            try
            {
                string gmafolder = rtxt_dspath.Text + DSC() + "garrysmod" + DSC() + "cache" + DSC() + "srcds";
                if (Directory.Exists(gmafolder))
                {
                    var files = Directory.GetFiles(gmafolder);
                    foreach (var file in files)
                    {
                        File.Delete(file);
                    }
                }
                else
                {
                    MessageBox.Show(L.Phrase("LID_pathdoesnotexists") + "! (" + gmafolder + ")");
                }
                CalculateGMASize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("[DeleteGMAs] Exit process failed: " + ex.Message.ToString());
            }
        }

        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }

        private void CalculateGMASize()
        {
            try
            {
                string gmafolder = rtxt_dspath.Text + DSC() + "garrysmod" + DSC() + "cache" + DSC() + "srcds";
                float folderSize = 0.0f;
                if (Directory.Exists(gmafolder))
                {
                    var files = Directory.GetFiles(gmafolder);
                    foreach (var file in files)
                    {
                        FileInfo finfo = new(file);
                        folderSize += finfo.Length;
                    }
                }

                folderSize /= 1000000000.0f;

                lbl_gmasize.Text = "" + Math.Round(folderSize, 2) + " GB";
            }
            catch
            {
                lbl_gmasize.Text = "" + 0.0 + " GB";
            }
        }

        private void Lbl_gmasize_Click(object sender, EventArgs e)
        {
            CalculateGMASize();
        }

        private void CalculateCacheSize()
        {
            try
            {
                string cachefolder = rtxt_dspath.Text + DSC() + "steam_cache";
                float folderSize = DirSize(new DirectoryInfo(cachefolder));

                folderSize /= 1000000000.0f;

                lbl_cachesize.Text = "" + Math.Round(folderSize, 2) + " GB";
            }
            catch
            {
                lbl_cachesize.Text = "" + 0.0 + " GB";
            }
        }

        private static void DeleteRecursiveFolder(string target)
        {
            var files = Directory.GetFiles(target);
            foreach (var file in files)
            {
                File.Delete(file);
            }
            var folders = Directory.GetDirectories(target);
            foreach (var folder in folders)
            {
                DeleteRecursiveFolder(folder);
            }
            Directory.Delete(target);
        }

        private void Btn_deletecache_Click(object sender, EventArgs e)
        {
            try
            {
                string cachefolder = rtxt_dspath.Text + DSC() + "steam_cache";

                if (Directory.Exists(cachefolder))
                {
                    DeleteRecursiveFolder(cachefolder);
                }
                else
                {
                    MessageBox.Show(L.Phrase("LID_pathdoesnotexists") + "! (" + cachefolder + ")");
                }
                CalculateCacheSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("[DeleteCache] Exit process failed: " + ex.Message.ToString());
            }
        }

        private void Lbl_sizecache_Click(object sender, EventArgs e)
        {
            CalculateCacheSize();
        }
    }
}


