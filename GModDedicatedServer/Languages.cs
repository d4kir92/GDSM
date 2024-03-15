using GModDedicatedServer.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GModDedicatedServer
{
    class Languages
    {
        public string pclang = "EN-EN";
        public Dictionary<string, string> LANGUAGES = new Dictionary<string, string>();
        public Dictionary<string, string> LANG = new Dictionary<string, string>();

        public Languages()
        {
            LANGUAGES["AUTO"] = "Auto";
            LANGUAGES["EN-EN"] = "English";
            LANGUAGES["DE-DE"] = "German / Deutsch";
            LANGUAGES["RU-RU"] = "Russian / Русский";
            LANGUAGES["TR-TR"] = "Turkish / Türkçe";
        }

        public void InitLanguage(string ls = "EN-EN")
        {
            ls = ls.ToUpper();
            Init_EN_EN();
            if (ls == "AUTO")
            {
                InitLanguage(System.Globalization.CultureInfo.CurrentCulture.ToString().ToUpper());
                return;
            }
            else if (ls == "DE-DE")
            {
                Init_DE_DE();
            }
            else if (ls == "RU-RU")
            {
                Init_RU_RU();
            }
            else if (ls == "TR-TR")
            {
                Init_TR_TR();
            }
            else
            {
                Init_EN_EN();
            }
            pclang = ls;
            Settings.Default["language"] = pclang;
            Settings.Default.Save();
        }

        public void Init_EN_EN()
        {
            LANG["LID_startserver"] = "Start Server";
            LANG["LID_stopserver"] = "Stop Server";
            LANG["LID_restartserver"] = "Restart Server";
            LANG["LID_fixedconsolesize"] = "Fixed Console Size";

            LANG["LID_server"] = "Server";
            LANG["LID_properties"] = "Properties";
            LANG["LID_dedicatedserver"] = "Dedicated Server";
            LANG["LID_steam"] = "Steam";
            LANG["LID_about"] = "About";

            LANG["LID_steamcmdpath"] = "SteamCMD Path";
            LANG["LID_dedicatedserverpath"] = "Dedicated Server Path";

            LANG["LID_change"] = "Change";
            LANG["LID_openfolder"] = "Open folder";
            LANG["LID_install"] = "Install";
            LANG["LID_update"] = "Update";
            LANG["LID_download"] = "Download";

            LANG["LID_hostname"] = "Servername";
            LANG["LID_password"] = "Password";
            LANG["LID_adminpassword"] = "Admin Password";
            LANG["LID_maxplayers"] = "Max Players";
            LANG["LID_port"] = "Port";
            LANG["LID_workshopid"] = "WorkshopID";
            LANG["LID_gamemode"] = "Gamemode";
            LANG["LID_map"] = "Map";
            LANG["LID_additionalcmds"] = "Additional Commands";
            LANG["LID_configfile"] = "Config file, for more settings";
            LANG["LID_opencollection"] = "Open Collection";
            LANG["LID_commands"] = "Commands";
            LANG["LID_configs"] = "Configs";
            LANG["LID_open"] = "Open";
            LANG["LID_loadingurl"] = "Loading url";
            LANG["LID_deletegmas"] = "Delete GMAs";
            LANG["LID_deletecache"] = "Delete Cache";

            LANG["LID_missingcontent"] = "Missing Content?";

            LANG["LID_pathdoesnotexists"] = "Path does not exists";

            LANG["LID_name"] = "Name";
            LANG["LID_login"] = "Login";

            LANG["LID_alwaysontop"] = "Always on top";
            LANG["LID_closeallservers"] = "Close All Servers";
        }

        public void Init_DE_DE()
        {
            LANG["LID_startserver"] = "Server starten";
            LANG["LID_stopserver"] = "Server stoppen";
            LANG["LID_restartserver"] = "Server neustarten";
            LANG["LID_fixedconsolesize"] = "Feste Konsolen Größe";

            LANG["LID_server"] = "Server";
            LANG["LID_properties"] = "Eigenschaften";
            LANG["LID_dedicatedserver"] = "Dedizierter Server";
            LANG["LID_steam"] = "Steam";
            LANG["LID_about"] = "Über";

            LANG["LID_steamcmdpath"] = "SteamCMD Pfad";
            LANG["LID_dedicatedserverpath"] = "Dedicated Server Pfad";

            LANG["LID_change"] = "Ändern";
            LANG["LID_openfolder"] = "Ordner öffnen";
            LANG["LID_install"] = "Installieren";
            LANG["LID_update"] = "Updaten";
            LANG["LID_download"] = "Downloaden";

            LANG["LID_hostname"] = "Servername";
            LANG["LID_password"] = "Passwort";
            LANG["LID_adminpassword"] = "Admin Passwort";
            LANG["LID_maxplayers"] = "Maximale Spieleranzahl";
            LANG["LID_port"] = "Port";
            LANG["LID_workshopid"] = "WorkshopID";
            LANG["LID_gamemode"] = "Spielmodus";
            LANG["LID_map"] = "Karte";
            LANG["LID_additionalcmds"] = "Zusätzliche Befehle";
            LANG["LID_configfile"] = "Konfigurationsdatei, für weitere Einstellungen";
            LANG["LID_opencollection"] = "Kollektion öffnen";
            LANG["LID_commands"] = "Befehle";
            LANG["LID_configs"] = "Configs";
            LANG["LID_open"] = "Öffnen";
            LANG["LID_loadingurl"] = "Ladebildschirm url";
            LANG["LID_deletegmas"] = "GMAs löschen";
            LANG["LID_deletecache"] = "Cache löschen";

            LANG["LID_missingcontent"] = "Fehlender Inhalt?";

            LANG["LID_pathdoesnotexists"] = "Pfad existiert nicht";

            LANG["LID_name"] = "Name";
            LANG["LID_login"] = "Anmeldung";

            LANG["LID_alwaysontop"] = "Immer im Vordergrund";
            LANG["LID_closeallservers"] = "Alle Server schließen";
        }

        public void Init_RU_RU()
        {
            LANG["LID_startserver"] = "Заупстить Сервер";
            LANG["LID_stopserver"] = "Выключить Сервер";
            LANG["LID_restartserver"] = "Перезапустить Сервер";
            LANG["LID_fixedconsolesize"] = "Приемный Размер Консоли";

            LANG["LID_server"] = "Сервер";
            LANG["LID_properties"] = "Свойства";
            LANG["LID_dedicatedserver"] = "Выделенный Сервер";
            LANG["LID_steam"] = "Стим";
            LANG["LID_about"] = "О Нас";

            LANG["LID_steamcmdpath"] = "SteamCMD Деректория";
            LANG["LID_dedicatedserverpath"] = "Деректория Выделеного Сервера";

            LANG["LID_change"] = "Изменить";
            LANG["LID_openfolder"] = "Открыть Папку";
            LANG["LID_install"] = "Установить";
            LANG["LID_update"] = "Обновить";
            LANG["LID_download"] = "Скачать";

            LANG["LID_hostname"] = "Имя Сервера";
            LANG["LID_password"] = "Пароль";
            LANG["LID_adminpassword"] = "Админ Пароль";
            LANG["LID_maxplayers"] = "Максимум Игроков";
            LANG["LID_port"] = "Порт";
            LANG["LID_workshopid"] = "WorkshopID";
            LANG["LID_gamemode"] = "Режим";
            LANG["LID_map"] = "Карта";
            LANG["LID_additionalcmds"] = "Дополнительные Команды";
            LANG["LID_configfile"] = "Файл Конфига, для множиства настроек";
            LANG["LID_opencollection"] = "Окрыть Колекцию";
            LANG["LID_commands"] = "Команды";
            LANG["LID_configs"] = "Конфиги";
            LANG["LID_open"] = "Открыть";
            LANG["LID_loadingurl"] = "Загрузочная Ссылка";
            LANG["LID_deletegmas"] = "Удалить ГМА";

            LANG["LID_missingcontent"] = "Отсуствует Контент?";

            LANG["LID_pathdoesnotexists"] = "Патча не существует";

            LANG["LID_name"] = "Имя";
            LANG["LID_login"] = "Логин";

            LANG["LID_alwaysontop"] = "Всегда Сверху";
            LANG["LID_closeallservers"] = "закрыть все серверы";
        }

        public void Init_TR_TR()
        {
            LANG["LID_startserver"] = "Sunucuyu Başlat";
            LANG["LID_stopserver"] = "Sunucuyu Durdur";
            LANG["LID_restartserver"] = "Sunucuyu Yeniden Başlat";
            LANG["LID_fixedconsolesize"] = "Konsol Penceresini Kilitle";

            LANG["LID_server"] = "Sunucu";
            LANG["LID_properties"] = "Özellikler";
            LANG["LID_dedicatedserver"] = "Dedicated Sunucu";
            LANG["LID_steam"] = "Steam";
            LANG["LID_about"] = "Hakkında";

            LANG["LID_steamcmdpath"] = "SteamCMD Dosya yolu";
            LANG["LID_dedicatedserverpath"] = "Sunucu dosya yolu";

            LANG["LID_change"] = "Değiştir";
            LANG["LID_openfolder"] = "Dosyayı aç";
            LANG["LID_install"] = "Yükle";
            LANG["LID_update"] = "Güncelle";
            LANG["LID_download"] = "İndir";

            LANG["LID_hostname"] = "SunucuAdı";
            LANG["LID_password"] = "Şifre";
            LANG["LID_adminpassword"] = "Admin Şifresi";
            LANG["LID_maxplayers"] = "Slot Sayısı";
            LANG["LID_port"] = "Port";
            LANG["LID_workshopid"] = "Koleksiyon ID";
            LANG["LID_gamemode"] = "Oyun Modu";
            LANG["LID_map"] = "Harita";
            LANG["LID_additionalcmds"] = "Ekstra Komutlar";
            LANG["LID_configfile"] = "Daha gelişmiş ayarlar için config dosyası";
            LANG["LID_opencollection"] = "Koleksiyonu Aç";
            LANG["LID_commands"] = "Komutlar";
            LANG["LID_configs"] = "Configler";
            LANG["LID_open"] = "Aç";
            LANG["LID_loadingurl"] = "Yükleme Ekranı URL";
            LANG["LID_deletegmas"] = "GMA dosyalarını sil";
            LANG["LID_deletecache"] = "Önbelleği Temizle";

            LANG["LID_missingcontent"] = "Eksik content?";

            LANG["LID_pathdoesnotexists"] = "Dosya yolu bulunamadı";

            LANG["LID_name"] = "İsim";
            LANG["LID_login"] = "Giriş";

            LANG["LID_alwaysontop"] = "Her zaman yukarıda";
            LANG["LID_closeallservers"] = "Tüm sunucuları kapat";
        }

        public string Phrase(string LID)
        {
            return LANG[LID];
        }
    }
}
