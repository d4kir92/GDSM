//Copyright(C) 2019 Arno Zura(https://www.gnu.org/licenses/gpl.txt)

      using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using GModDedicatedServer.Properties;
using System.Collections;

namespace GModDedicatedServer
{
    public partial class Form1 : Form
    {
        public string _Version = "1.4";
        public string _onlineVersion = "";

        public bool serverrunning = false;
        string status_steamcmd = "notinstalled";
        string status_ds = "notinstalled";

        public string HttpGet(string URI)
        {
            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(URI);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }

        public void CheckStatus()
        {
            rtxt_dspath.Text = Settings.Default["dspath"].ToString();
            if (File.Exists(rtxt_dspath.Text + Path.DirectorySeparatorChar + "srcds.exe"))
            {
                status_ds = "installed";
                btn_dsinstall.Text = "Update";
                gb_dssettings.Visible = true;
            }
            else
            {
                status_ds = "notinstalled";
                gb_dssettings.Visible = false;
            }

            rtxt_steamcmdpath.Text = Settings.Default["steamcmdpath"].ToString();
            if (File.Exists(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.exe"))
            {
                status_steamcmd = "installed";
                btn_steamcmdinstall.Text = "Update";
                gb_ds.Visible = true;
            }
            else
            {
                status_steamcmd = "notinstalled";
                gb_ds.Visible = false;
            }
        }

        public void UpdateServerCfg()
        {
            string dsc = Path.DirectorySeparatorChar.ToString();
            string file = rtxt_dspath.Text + dsc + "garrysmod" + dsc + "cfg" + dsc + "server.cfg";
            if (File.Exists(file)){
                string[] servercfg = File.ReadAllLines(file, Encoding.UTF8);
                for (int i = 0; i < servercfg.Length; i++)
                {
                    rtxt_servercfg.AppendText(servercfg[i] + "\n");
                }
            }
        }

        public void CheckVersion()
        {
            _onlineVersion = HttpGet("https://docs.google.com/spreadsheets/d/1O7EiIGtnvBnpF1z0A_GuYaPA5BiwCDNBpN-i9Kctt30/edit?usp=sharing");

            int startIndex = _onlineVersion.IndexOf("*");
            int endIndex = _onlineVersion.IndexOf("#");
            _onlineVersion = _onlineVersion.Substring(startIndex + 1, endIndex - 1 - startIndex);

            if (_Version != _onlineVersion)
            {
                lbl_version.Text = "Current GDSM version: " + _Version + " (Newest GDSM Version: " + _onlineVersion + ")";
                lbl_version2.Text = lbl_version.Text;
                Color txtColor = new Color();
                txtColor = Color.FromArgb(255, 0, 0);
                lbl_version.ForeColor = txtColor;
                lbl_version2.ForeColor = txtColor;
            }
            else
            {
                lbl_version.Text = "GDSM Version: " + _Version;
                lbl_version2.Text = lbl_version.Text;
                Color txtColor = new Color();
                txtColor = Color.FromArgb(0, 255, 0);
                lbl_version.ForeColor = txtColor;
                lbl_version2.ForeColor = txtColor;
            }
        }

        public Form1()
        {
            InitializeComponent();

            CheckStatus();

            rtxt_hostname.Text = Settings.Default.hostname;
            rtxt_gamemode.Text = Settings.Default.gamemode;
            nud_workshopid.Value = Settings.Default.workshopid;
            nud_maxplayers.Value = Settings.Default.maxplayers;
            rtxt_map.Text = Settings.Default.map;
            nud_port.Value = Settings.Default.port;
            rtxt_othercmds.Text = Settings.Default.othercmds;

            UpdateServerCfg();

            CheckVersion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        private Process pDocked;
        private IntPtr hWndOriginalParent;
        private IntPtr hWndDocked;

        private void Btn_start_Click(object sender, EventArgs e)
        {
            bool IsMouse = (e is System.Windows.Forms.MouseEventArgs);
            
            if (!IsMouse)
            {
                return;
            }
            if (pDocked == null)
            {
                try
                {
                    CheckVersion();

                    if (nud_workshopid.Value > 0)
                    {
                        string cid_txt = rtxt_dspath.Text + Path.DirectorySeparatorChar + "collectionid.txt";
                        File.Delete(cid_txt);
                        TextWriter tw = new StreamWriter(cid_txt, true);
                        tw.Write("+host_workshop_collection " + nud_workshopid.Value + " ");
                        tw.Close();
                    }
                    else
                    {
                        MessageBox.Show("No CollectionID found!");
                    }
                    dockIt();
                    btn_start.Text = "Close Server";
                    btn_start.BackColor = Color.FromArgb(255, 0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Starting process failed: " + ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    CheckVersion();

                    undockIt();
                    pDocked.Kill();
                    pDocked = null;
                    hWndOriginalParent = IntPtr.Zero;
                    hWndDocked = IntPtr.Zero;
                    btn_start.Text = "Start Server";
                    btn_start.BackColor = Color.FromArgb(0, 255, 0);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Exit process failed: " + ex.Message.ToString());
                }
            }
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            if (pDocked != null)
            {
                try
                {
                    undockIt();
                    pDocked.Kill();
                    pDocked = null;
                    hWndOriginalParent = IntPtr.Zero;
                    hWndDocked = IntPtr.Zero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exit process failed: " + ex.Message.ToString());
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private void dockIt()
        {
            try
            {
                if (hWndDocked != IntPtr.Zero) //don't do anything if there's already a window docked.
                    return;

                string startcmd = "";
                if (rtxt_hostname.Text != "")
                {
                    startcmd = startcmd + "+hostname \"" + rtxt_hostname.Text + "\" ";
                }
                if (nud_maxplayers.Value != 0)
                {
                    startcmd = startcmd + "+maxplayers " + nud_maxplayers.Value + " ";
                }
                if (nud_workshopid.Value != 0)
                {
                    startcmd = startcmd + "+host_workshop_collection " + nud_workshopid.Value + " ";
                }
                if (rtxt_gamemode.Text != "")
                {
                    startcmd = startcmd + "+gamemode " + rtxt_gamemode.Text + " ";
                }
                if (rtxt_map.Text != "")
                {
                    startcmd = startcmd + "+map " + rtxt_map.Text + " ";
                }
                if (nud_port.Value != 0)
                {
                    startcmd = startcmd + "-port " + nud_port.Value + " ";
                }
                if (rtxt_othercmds.Text != "")
                {
                    startcmd = startcmd + rtxt_othercmds.Text + " ";
                }
                startcmd = startcmd + "-autoupdate -console";

                pDocked = Process.Start(rtxt_dspath.Text + Path.DirectorySeparatorChar + "srcds", startcmd);
                while (hWndDocked == IntPtr.Zero)
                {
                    pDocked.WaitForInputIdle(0); //wait for the window to be ready for input;
                    pDocked.Refresh();              //update process info
                    if (pDocked.HasExited)
                    {
                        return; //abort if the process finished before we got a handle.
                    }
                    hWndDocked = pDocked.MainWindowHandle;  //cache the window handle
                }
                //Windows API call to change the parent of the target window.
                //It returns the hWnd of the window's parent prior to this call.
                hWndOriginalParent = SetParent(hWndDocked, panel1.Handle);

                //Wire up the event to keep the window sized to match the control
                panel1.SizeChanged += new EventHandler(Panel1_Resize);
                //Perform an initial call to set the size.
                Panel1_Resize(new Object(), new EventArgs());
            }
            catch(Exception e)
            {
                if (e.HResult.GetHashCode() == -2147467259)
                {
                    MessageBox.Show("Server not installed or not found!");
                }
                else
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
        }

        private void undockIt()
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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings.Default["steamcmdpath"] = fbd.SelectedPath;
                Settings.Default.Save();
                rtxt_steamcmdpath.Text = fbd.SelectedPath;
            }
            CheckStatus();
        }

        WebClient wc_steamcmd = new WebClient();
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
                        wc_steamcmd.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                        Uri zipurl = new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip");
                        wc_steamcmd.DownloadFileAsync(zipurl, rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd.zip");
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

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
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

        private void Btn_dsinstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtxt_steamcmdpath.Text != "")
                {
                    Process ds = Process.Start(rtxt_steamcmdpath.Text + Path.DirectorySeparatorChar + "steamcmd", "steamcmd.exe +login anonymous +force_install_dir \"" + rtxt_dspath.Text + "\" +app_update 4020 validate +quit");
                    ds.WaitForExit();
                }
                else
                {
                    MessageBox.Show("First choose a path!");
                }
            }
            catch(Exception ex)
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
        }

        private void Btn_dspath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings.Default["dspath"] = fbd.SelectedPath;
                Settings.Default.Save();
                rtxt_dspath.Text = fbd.SelectedPath;
            }
            CheckStatus();
        }

        private void Rtxt_hostname_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["hostname"] = rtxt_hostname.Text;
            Settings.Default.Save();
        }

        private void Rtxt_gamemode_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["gamemode"] = rtxt_gamemode.Text;
            Settings.Default.Save();
        }

        private void Nud_workshopid_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["workshopid"] = Convert.ToInt32(nud_workshopid.Value);
            Settings.Default.Save();
        }

        private void Nud_maxplayers_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["maxplayers"] = Convert.ToInt32(nud_maxplayers.Value);
            Settings.Default.Save();
        }

        private void Rtxt_map_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["map"] = rtxt_map.Text;
            Settings.Default.Save();
        }

        private void Nud_port_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default["port"] = Convert.ToInt32(nud_port.Value);
            Settings.Default.Save();
        }

        private void Btn_website_Click(object sender, EventArgs e)
        {
            Process.Start("https://sites.google.com/view/gdsm/home");
        }

        private void Btn_workshopid_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/sharedfiles/filedetails/?id=" + nud_workshopid.Value);
        }

        private void Btn_discord_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/a6M2ZGC");
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
            Process.Start("explorer.exe", rtxt_dspath.Text);
        }

        private void Btn_open_steamcmdpath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", rtxt_steamcmdpath.Text);
        }

        private void Btn_mapsfolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", rtxt_dspath.Text + Path.DirectorySeparatorChar + "garrysmod" + Path.DirectorySeparatorChar + "maps");
        }

        private void Btn_gamemodesfolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", rtxt_dspath.Text + Path.DirectorySeparatorChar + "garrysmod" + Path.DirectorySeparatorChar + "gamemodes");
        }

        private void Btn_cmds_Click(object sender, EventArgs e)
        {
            Process.Start("https://developer.valvesoftware.com/wiki/Command_Line_Options");
        }

        private void Rtxt_othercmds_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["othercmds"] = rtxt_othercmds.Text;
            Settings.Default.Save();
        }

        private void Rtxt_servercfg_TextChanged(object sender, EventArgs e)
        {
            string dsc = Path.DirectorySeparatorChar.ToString();
            string file = rtxt_dspath.Text + dsc + "garrysmod" + dsc + "cfg" + dsc + "server.cfg";
            File.WriteAllText(file, rtxt_servercfg.Text);
        }

        private void Btn_start_Enter(object sender, EventArgs e)
        {
            // Nothing
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/results?search_query=port+forwarding+tutorial");
        }

        private void Btn_tutorial_Click(object sender, EventArgs e)
        {
            Process.Start("Linkhere");
        }

        private void Wb_discord_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Btn_configs_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", rtxt_dspath.Text + Path.DirectorySeparatorChar + "garrysmod" + Path.DirectorySeparatorChar + "cfg");
        }
    }
}


