using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Simple_RPG.CharacterClasses
{
    internal class filemanagment
    {
        private static String SettingFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                folder = Path.Combine(folder, "RPGCharacter");
                folder = Path.Combine(folder, "character settings");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }
        private static String PlayerSettingFile
        {
            get
            {
                return Path.Combine(SettingFolder, "Player.xml");
            }
        }

        private static Player DefaultSettings
        {
            get
            {
                return new Player()
                {
                    Name = "",
                    Gender = CreatureGender.Unknown,
                    CharClass = CreatureClass.Unknown,
                    Dex = 0,
                    Stre = 0,
                    Wis = 0,
                    Health = 0,

                };
            }
        }
 
        public static Player LoadPlayer()
        {
            if (!File.Exists(PlayerSettingFile))
                return DefaultSettings;
            using (Stream stream = File.OpenRead(PlayerSettingFile))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Player));
                return (Player)ser.Deserialize(stream);
            }

        }
        public static void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(PlayerSettingFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }
    }
}
