using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    [XmlRoot(Namespace = "Lab2")]
    [XmlType("Lector")]

    public class Lector
    {
        [XmlElement(ElementName = "department")]
        public string Department { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "surname")]
        public string Surname { get; set; }
        [XmlElement(ElementName = "patronymic")]
        public string Patronymic { get; set; }
        [XmlIgnore]
        public string Audience { get; set; }
        public Lector()
        {
            Name = "";
            this.Surname = "";
            this.Patronymic = "";
            this.Audience = "";
            this.Department = "";
        }
        public Lector(string surname, string name, string patronymic, string audience, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Audience = audience;
            this.Department = department;
        }
        public override string ToString()
        {
            return String.Format($"{Surname} {Name} {Patronymic}, {Audience} {Department}");
        }
    }
    [Serializable]
    //[XmlRoot(Namespace = "Lab2")]
    //[XmlType("discipline")]
    public class Discipline
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "semester")]
        public string Semester { get; set; }
        [XmlElement(ElementName = "course")]
        public int Course { get; set; }
        [XmlElement(ElementName = "spcialization")]
        public string Specialization { get; set; }
        [XmlElement(ElementName = "count-lections")]
        public int CountLections { get; set; }
        [XmlElement(ElementName = "count-labs")]
        public int CountLabs { get; set; }
        [XmlIgnore]
        public bool Exam { get; set; }
        [XmlElement(ElementName = "lector")]
        public Lector lector { get; set; }
        public Discipline()
        {
            Name = "";
            Semester = "";
            Course = 0;
            Specialization = "";
            CountLections = 0;
            CountLabs = 0;
            Exam = true;
            lector = new Lector("","","","","");
        }
        public Discipline(string name, string semester, int course, string specialization, int countLections, int countLabs, bool exam, Lector lector)
        {
            Name = name;
            Semester = semester;
            Course = course;
            Specialization = specialization;
            CountLections = countLections;
            CountLabs = countLabs;
            Exam = exam;
            this.lector = lector;
        }
    }
    public static class XmlSerializeWrapper
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T obj;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                obj = (T)formatter.Deserialize(fs);
            }
            return obj;
        }
    }

}
