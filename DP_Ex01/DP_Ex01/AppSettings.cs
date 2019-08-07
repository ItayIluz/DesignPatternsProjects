using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace DP_Ex01
{
    public sealed class AppSettings
    {
        private static readonly string sr_FilePath = "./appSettings.xml";
        private static readonly object sr_InstanceLock = new object();
        private static volatile AppSettings s_Instance;

        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        public AppSettings Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_InstanceLock)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new AppSettings();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1000, 500);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings GetInstance()
        {
            if (s_Instance == null)
            {
                s_Instance = new AppSettings();
            }

            return s_Instance;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = GetInstance();
            if (File.Exists(sr_FilePath))
            {
                using (Stream stream = new FileStream(sr_FilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(sr_FilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }      
    }
}
