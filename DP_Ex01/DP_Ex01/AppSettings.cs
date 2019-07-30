﻿using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace DP_Ex01
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1000, 500);
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            if (File.Exists(@"D:\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }
    }
}
