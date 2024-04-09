using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RestSharpTest.Steps
{
    [TestClass]
    public class Teste
    {
      
        private RestClient client;
        private IRestResponse response;

        [Given(@"o usuário tem acesso à API")]
        public void GivenOUsuarioTemAcessoAAPI()
        {
            // Configurar o cliente RestSharp para a API
            client = new RestClient("https://portal-qa.qarti.com.br/Api");
        }

        [When(@"o usuário envia uma requisição GET para obter o departamento com o ID (.*)")]
        public void WhenOUsuarioEnviaUmaRequisicaoGETParaObterODepartamentoComOID(int departamentoId)
        {
            // Fazer a requisição GET para obter o departamento com o ID especificado
            var request = new RestRequest($"/api/departamentos/{departamentoId}", Method.Get);
            response = client.Execute(request);
        }

        [Then(@"a API deve retornar código de status 200 OK")]
        public void ThenADeveRetornarCodigoDeStatusOK()
        {
            // Verificar se o código de status é 200 OK
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
