using System.Xml.Serialization;

namespace DeserializeXML.Domain
{
    [XmlRoot(ElementName = "evtInfoEmpregador")]
    public class EvtInfoEmpregador
    {
        [XmlElement(ElementName = "ideEvento")]
        public IdeEvento IdeEvento { get; set; }

        [XmlElement(ElementName = "ideEmpregador")]
        public IdeEmpregador IdeEmpregador { get; set; }

        [XmlElement(ElementName = "infoEmpregador")]
        public InfoEmpregador InfoEmpregador { get; set; }
    }

    [XmlRoot(ElementName = "ideEvento")]
    public class IdeEvento
    {
        [XmlElement("tpAmb")]
        public string TpAmb { get; set; }

        [XmlElement("procEmi")]
        public string ProcEmi { get; set; }

        [XmlElement("verProc")]
        public string VerProc { get; set; }
    }

    [XmlRoot(ElementName = "ideEmpregador")]
    public class IdeEmpregador
    {
        [XmlElement("tpInsc")]
        public string TpInsc { get; set; }

        [XmlElement("nrInsc")]
        public string NrInsc { get; set; }
    }

    [XmlRoot(ElementName = "infoEmpregador")]
    public class InfoEmpregador
    {
        [XmlElement(ElementName = "inclusao")]
        public Inclusao Inclusao { get; set; }
    }

    [XmlRoot(ElementName = "inclusao")]
    public class Inclusao
    {
        [XmlElement(ElementName = "idePeriodo")]
        public IdePeriodo IdePeriodo { get; set; }

        [XmlElement(ElementName = "infoCadastro")]
        public InfoCadastro InfoCadastro { get; set; }
    }

    [XmlRoot(ElementName = "idePeriodo")]
    public class IdePeriodo
    {
        [XmlElement("iniValid")]
        public string IniValid { get; set; }
    }

    [XmlRoot(ElementName = "infoCadastro")]
    public class InfoCadastro
    {
        [XmlElement("classTrib")]
        public string ClassTrib { get; set; }

        [XmlElement("indDesFolha")]
        public string IndDesFolha { get; set; }

        [XmlElement("indOptRegEletron")]
        public string IndOptRegEletron { get; set; }

        [XmlElement("cnpjEFR")]
        public string CnpjEFR { get; set; }
    }
}
