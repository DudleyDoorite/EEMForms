using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EEMMain
{
    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string SaveGameFolder { get; set; }

        private string _path;
        [System.Xml.Serialization.XmlIgnore]
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }


        public void Save(string path)
        {
            //create a serilaizer
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(Episode));
            //create the stream
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
            ser.Serialize(sw,this);

            sw.Flush();
            sw.Close();
            
        }
        public void Load(string path)
        {
            //create a serilaizer
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(Episode));
            //create the stream
            System.IO.StreamReader sr = new System.IO.StreamReader(path);

            Episode tmpEpisode = (Episode)ser.Deserialize(sr);


            this.Title = tmpEpisode.Title;
            this.Description = tmpEpisode.Description;
            this.Tags = tmpEpisode.Tags;
            this.SaveGameFolder = tmpEpisode.SaveGameFolder;
            sr.Close();

        }


    }
}
