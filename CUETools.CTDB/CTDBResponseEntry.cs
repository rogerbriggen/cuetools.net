﻿using System;
using System.Xml.Serialization;

namespace CUETools.CTDB
{
    [Serializable]
    public class CTDBResponseEntry
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string crc32 { get; set; }
        [XmlAttribute]
        public int confidence { get; set; }
        [XmlAttribute]
        public int npar { get; set; }
        [XmlAttribute]
        public int stride { get; set; }
        [XmlAttribute]
        public string hasparity { get; set; }
        [XmlAttribute]
        public string parity { get; set; }
        [XmlAttribute]
        public string toc { get; set; }
    }
}
