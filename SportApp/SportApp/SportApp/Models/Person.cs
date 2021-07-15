using System;
using System.Xml.Serialization;

namespace SportApp.Models
{
    /// <summary>
    /// Класс описывает антропометрию
    /// </summary>
    [XmlRoot("Person")]
    public class Person
    {
        /// <summary>
        /// Запястья
        /// </summary>
        [XmlElement("Wrist")]
        public string Wrist { get; set; }

        /// <summary>
        /// Предплечья
        /// </summary>
        [XmlElement("Forearm")]
        public string Forearm { get; set; }

        /// <summary>
        /// Бицепсы
        /// </summary>
        [XmlElement("Biceps")]
        public string Biceps { get; set; }

        /// <summary>
        /// Шея
        /// </summary>
        [XmlElement("Neck")]
        public string Neck{ get; set; }

        /// <summary>
        /// Плечевой пояс
        /// </summary>
        [XmlElement("ShoulderGirdle")]
        public string ShoulderGirdle { get; set; }

        /// <summary>
        /// Грудь
        /// </summary>
        [XmlElement("Chest")]
        public string Chest { get; set; }

        /// <summary>
        /// Живот
        /// </summary>
        [XmlElement("Abdomen")]
        public string Abdomen { get; set; }

        /// <summary>
        /// Таз
        /// </summary>
        [XmlElement("Pelvis")]
        public string Pelvis { get; set; }

        /// <summary>
        /// Бедро
        /// </summary>
        [XmlElement("Hips")]
        public string Hips { get; set; }

        /// <summary>
        /// Лодыжки
        /// </summary>
        [XmlElement("Ankles")]
        public string Ankles { get; set; }
    }
}
