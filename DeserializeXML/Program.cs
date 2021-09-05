using DeserializeXML.Domain;
using DeserializeXML.Services;
using System;
using System.IO;

namespace DeserializeXML
{
    static class Program
    {
        public static void Main(string[] args)
        {
           var _evtInfoEmpregadorService = new EvtInfoEmpregadorService();

            var xmlData = File.ReadAllText(@"Resources\EvtInfoEmpregadorXMLData.xml");
            EvtInfoEmpregador evtInfoEmpregador = _evtInfoEmpregadorService.ObterEvtInfoEmpregadorPorXML(xmlData);

            Console.WriteLine("Inscrição Empregador");
            Console.WriteLine(evtInfoEmpregador.IdeEmpregador.NrInsc);

        }
    }
}
