using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Daniel";
            command.LastName = "Nagami";
            command.Document = "9999999999";
            command.Email = "daniel@balta.io2";
            command.BarCode = "123456789";
            command.BoletoNumber = "123456798";
            command.PaymentNumber = "123456789";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Danzinho LTDA.";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "daniel@nagami.com";
            command.Street = "Av Paulista";
            command.Number = "1234";
            command.Neighborhood = "Jardins";
            command.City = "São Paulo";
            command.State = "SP";
            command.Country = "Brasil";
            command.ZipCode = "12345678";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}