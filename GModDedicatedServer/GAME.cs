//Copyright(C) 2019 Arno Zura(https://www.gnu.org/licenses/gpl.txt)

namespace GModDedicatedServer
{
    internal class GAME
    {
        public int app_id = -1;
        public string name = "unbenannt";
        public string path_name = "";
        public string example = "";
        public bool requirelogin = false;

        public GAME(int app_id, string name, string path_name, string example, bool requirelogin)
        {
            this.app_id = app_id;
            this.name = name;
            this.path_name = path_name;
            this.example = example;
            this.requirelogin = requirelogin;
        }

    }
}