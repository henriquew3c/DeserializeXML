using DeserializeXML.Common.Helpers;
using DeserializeXML.Domain;

namespace DeserializeXML.Services
{
    public class EvtInfoEmpregadorService
    {
        public EvtInfoEmpregador ObterEvtInfoEmpregadorPorXML(string xml)
        {
            var response = xml.XmlToObject<EvtInfoEmpregador>("evtInfoEmpregador");

            if (response is null)
                return response;

            return response;
        }
    }
}
