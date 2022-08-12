using Autofac;
using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain.Request;
using GlobalWeb.Infra.Middleware;
using System;
using Xunit;

namespace GlobalWeb.Test
{
    public class ClientTest
    {
        private readonly IClientApplication _clientApplication;
        private ClientRequest _request;

        public ClientTest()
        {
            var conllections = new DI_Test().DICollections();
            _clientApplication = conllections.Resolve<IClientApplication>();

            _request = new ClientRequest()
            {
                FullName = "Teste",
                Document = "Teste",
                Address = "Teste",
                BirthDate = DateTime.Now
            };
        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void New_Client_FullName_Null_Or_Empty_Is_Invalid(string fullName)
        {

            ClientRequest client = new()
            {
                FullName = fullName,
                Document = _request.Document,
                Address = _request.Address,
                BirthDate = _request.BirthDate
            };

            var response = _clientApplication.Add(client);
            CustomException ex = (CustomException)response.Exception.InnerException;

            Assert.Equal(422, ex.HttpStatusCode);
            Assert.Contains(ex.Title, "Invalid Attribute");
            Assert.Contains(ex.Message, "Nome deve ser informado.");
            Assert.True(true);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void New_Client_Document_Null_Or_Empty_Is_Invalid(string document)
        {

            ClientRequest client = new()
            {
                FullName = _request.FullName,
                Document = document,
                Address = _request.Address,
                BirthDate = _request.BirthDate
            };

            var response = _clientApplication.Add(client);
            CustomException ex = (CustomException)response.Exception.InnerException;

            Assert.Equal(422, ex.HttpStatusCode);
            Assert.Contains(ex.Title, "Invalid Attribute");
            Assert.Contains(ex.Message, "Documento deve ser informado.");
            Assert.True(true);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void New_Client_Address_Null_Or_Empty_Is_Invalid(string address)
        {

            ClientRequest client = new()
            {
                FullName = _request.FullName,
                Document = _request.Document,
                Address = address,
                BirthDate = _request.BirthDate
            };

            var response = _clientApplication.Add(client);
            CustomException ex = (CustomException)response.Exception.InnerException;

            Assert.Equal(422, ex.HttpStatusCode);
            Assert.Contains(ex.Title, "Invalid Attribute");
            Assert.Contains(ex.Message, "Endereço deve ser informado.");
            Assert.True(true);
        }
    }
}
