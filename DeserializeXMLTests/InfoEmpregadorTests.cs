using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using DeserializeXML.Services;
using DeserializeXML.Domain;

namespace DeserializeXMLTests
{
    [TestClass]
    public class InfoEmpregadorTests
    {

        private readonly EvtInfoEmpregadorService evtInfoEmpregadorService;

        public InfoEmpregadorTests()
        {
            this.evtInfoEmpregadorService = new EvtInfoEmpregadorService();
        }

        [TestMethod]
        public void SuccefulyDeserialized()
        {
            // Arrange 
            var xmlData = ReadEvtInfoEmpregadorXMLFile();

            // Act
            EvtInfoEmpregador evtInfoEmpregador = evtInfoEmpregadorService.ObterEvtInfoEmpregadorPorXML(xmlData);

            // Assert
            Assert.AreEqual("7", evtInfoEmpregador.IdeEvento.TpAmb);
            Assert.AreEqual("1", evtInfoEmpregador.IdeEmpregador.TpInsc);
            Assert.AreEqual("2020-11", evtInfoEmpregador.InfoEmpregador.Inclusao.IdePeriodo.IniValid);
            Assert.AreEqual("0", evtInfoEmpregador.InfoEmpregador.Inclusao.InfoCadastro.ClassTrib);
        }
        private string ReadEvtInfoEmpregadorXMLFile()
        {
            //*
            // Before use this, prepare to copy file into path solution/resouces to project bin folder.
            // Copy this command to properties/Bult Events/post-build event command line to automate this:
            // xcopy /Y /S "$(SolutionDir)\ManipulateXML\Resources\*" "$(TargetDir)"
            //*

            return File.ReadAllText(@"Resources\EvtInfoEmpregadorXMLData.xml");
        }
    }
}
