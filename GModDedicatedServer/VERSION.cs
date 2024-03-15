using System.Threading.Tasks;

namespace GModDedicatedServer
{
    class VERSION
    {
        private string localVersion = "0.0";
        private string onlineVersion = "0.0";
        private bool outdated = false;

        public string GetOnlineVersion()
        {
            return this.onlineVersion;
        }

        public string GetLocalVersion()
        {
            return this.localVersion;
        }

        public void SetVersion(string ver)
        {
            this.localVersion = ver;
        }

        public bool IsOutdated()
        {
            return outdated;
        }

        public async Task CheckVersion()
        {
            string url = "https://docs.google.com/spreadsheets/d/14DffNs6nCskTohLTBi-yX01b3ADcEuuqDhugURHcIWQ";
            string ret = await HTTP.Get(url);

            ret = ret[(ret.IndexOf('*') + 1)..];
            ret = ret[..ret.IndexOf('#')];

            onlineVersion = ret;

            if (onlineVersion != localVersion)
            {
                outdated = true;
            }
            else if (onlineVersion == localVersion)
            {
                outdated = false;
            }
        }
    }
}
