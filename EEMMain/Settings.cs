using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EEMMain
{
    public class EEMSettings
    {
        // Declare the event using EventHandler<T>
        public event EventHandler<SettingsEventArg> SettingsChangedEvent;


        private string _baseFolder;
        public string BaseFolder
        {
            get { return _baseFolder; }
            set
            {
                if (value != _baseFolder)
                {
                    _baseFolder = value;
                    this.IsDirty = true;
                    OnSettingsChangedEvent(new SettingsEventArg("BaseFolder"));
                }
            }
        }
        private string _capturesFolder;
        public string CapturesFolder
        {
            get { return _capturesFolder; }
            set
            {
                if (value != _capturesFolder)
                {
                    _capturesFolder = value;
                    this.IsDirty = true;
                    OnSettingsChangedEvent(new SettingsEventArg("CapturesFolder"));
                }
            }
        }
        private String _descriptionFile;
        public String DescriptionFile
        {
            get { return _descriptionFile; }
            set
            {
                if (value != _descriptionFile)
                {
                    _descriptionFile = value;
                    this.IsDirty = true;
                    OnSettingsChangedEvent(new SettingsEventArg("DescriptionFile"));
                }
            }
        }
        public string FFMpegPath { get; set; }

        private string _MainFormLocX = "0";        
        public string MainFormLocX
        {
            get { return _MainFormLocX; }
            set
            {
                _MainFormLocX = value;
                this.IsDirty = true;
                OnSettingsChangedEvent(new SettingsEventArg("MainFormLocX"));
            }
        }

        private string _MainFormLocY = "0";
        public string MainFormLocY
        {
            get { return _MainFormLocY; }
            set
            {
                _MainFormLocY = value;
                this.IsDirty = true;
                OnSettingsChangedEvent(new SettingsEventArg("MainFormLocY"));
            }
        }

        private string _MainFormWidth;
        public string MainFormWidth
        {
            get { return _MainFormWidth; }
            set
            {
                _MainFormWidth = value;
                this.IsDirty = true;
                OnSettingsChangedEvent(new SettingsEventArg("MainFormWidth"));
            }
        }


        private string _MainFormHeight;
        public string MainFormHeight
        {
            get { return _MainFormHeight; }
            set
            {
                _MainFormHeight = value;
                this.IsDirty = true;
                OnSettingsChangedEvent(new SettingsEventArg("MainFormHeight"));
            }
        }

        private string _LastEpisode;
        public string LastEpisode
        {
            get { return _LastEpisode; }
            set
            {
                _LastEpisode = value;
                this.IsDirty = true;
                OnSettingsChangedEvent(new SettingsEventArg("LastEpisode"));
            }
        }


        public bool IsDirty { get; set; }

        public void EEMMain()
        {
            LoadSettings();
        }


        public void LoadSettings()
        {
            this._baseFolder = ReadSetting("BaseFolder");
            this._capturesFolder = ReadSetting("CapturesFolder");
            this._descriptionFile = ReadSetting("DescriptionFile");
            this.FFMpegPath = ReadSetting("FFMpegPath");
            this._MainFormLocX = ReadSetting("MainFormLocX");
            this._MainFormLocY = ReadSetting("MainFormLocY");
            this._MainFormWidth = ReadSetting("MainFormWidth");
            this._MainFormHeight = ReadSetting("MainFormHeight");
            this._LastEpisode = ReadSetting("LastEpisode");


            this.IsDirty = false;
        }
        private string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                throw;
            }
        }
        public void AddUpdateSettings(string key, string value)
        {
            try
            {
                
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
                throw;
            }
        }
        public void UpdateSettings()
        {
            AddUpdateSettings("BaseFolder", this.BaseFolder);
            AddUpdateSettings("CapturesFolder", this.CapturesFolder);
            AddUpdateSettings("DescriptionFile", this.DescriptionFile);
            AddUpdateSettings("FFMpegPath", this.FFMpegPath);
            AddUpdateSettings("MainFormLocX", this._MainFormLocX);
            AddUpdateSettings("MainFormLocY", this._MainFormLocY);
            AddUpdateSettings("MainFormWidth", this._MainFormWidth);
            AddUpdateSettings("MainFormHeight", this._MainFormHeight);
            AddUpdateSettings("LastEpisode", this._LastEpisode);
            this.IsDirty = false;
        }


        // Wrap event invocations inside a protected virtual method
        // to allow derived classes to override the event invocation behavior
        protected virtual void OnSettingsChangedEvent(SettingsEventArg e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            SettingsChangedEvent?.Invoke(this, e);
        }
    }
}
