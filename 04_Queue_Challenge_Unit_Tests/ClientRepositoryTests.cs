using System;
using _04_Queue_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Queue_Challenge_Unit_Tests
{
    [TestClass]
    public class ClientRepositoryTests
    {
        private ClientRepository _clientRepo;
        private Client _client1;
        private Client _client2;

        [TestInitialize]
        public void Arrange()
        {
            _clientRepo = new ClientRepository();

            _client1 = new Client("Joshua Tucker", "It's broken");
            _client2 = new Client("Ransford Walker", "It's super broken");

            _clientRepo.AddClientToQueue(_client1);
            _clientRepo.AddClientToQueue(_client2);
        }

        [TestMethod]
        public void ClientRepository_AddClientToQueue_ReturnCorrectCount()
        {
            _clientRepo.AddClientToQueue(new Client("Lawrence Wagner", "Fix it please"));

            var expected = 3;
            var actual = _clientRepo.GetClientQueue().Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClientRepository_ProcessClaim_ReturnCorrectClient()
        {
            var expectedClient = _client1;
            var actualClient = _clientRepo.ProcessClaim();

            var expectedCount = 1;
            var actualCount = _clientRepo.GetClientQueue().Count;

            Assert.AreEqual(expectedClient, actualClient);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void ClientRepository_PeekNextClient_ReturnCorrectClient()
        {
            var expected = _client1;
            var actual = _clientRepo.PeekNextClient();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClientRepository_PeekNullClient_ReturnCorrectClient()
        {
            _clientRepo = new ClientRepository();

            Client expected = null;
            var actual = _clientRepo.PeekNextClient();

            Assert.AreEqual(expected, actual);
        }
    }
}
