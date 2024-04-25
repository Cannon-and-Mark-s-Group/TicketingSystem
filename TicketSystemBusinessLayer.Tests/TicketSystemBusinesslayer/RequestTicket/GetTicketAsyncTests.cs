using Moq;
using TicketSystemBusinessLayer.BusinessLogic.RequestTicket;
using TicketSystemBusinessLayer.Tests.SharedResources;
using TicketSystemEntities.ApplicationDbContext;
using TicketSystemEntities.Database;

namespace TicketSystemBusinessLayer.Tests.TicketSystemBusinesslayer.RequestTicket
{
    public class GetTicketAsyncTests : IDisposable
    {
        #region Fields 

        private IRequestTicketLogic _classUnderTest;

        #endregion

        #region IDisposable

        public void Dispose()
        {
            _classUnderTest = null;
        }

        #endregion

        #region Constructor

        public GetTicketAsyncTests()
        {
            SetupTest();
        }

        #endregion

        #region Positive tests

        [Fact]
        public async Task GetTicket_ValidateCall_ResultNotEmptyOrNullWithIdAsync()
        {
            int id = 1;

            var result = await CallMethodAsync(id);

            Assert.NotNull(result);
        }

        #endregion

        #region Negative tests

        [Fact]
        public async Task GetTicket_ValidateCall_ResultEmptyOrNullWithIdAsync()
        {
            int? id = null;

            var result = await CallMethodAsync(id);

            Assert.Null(result);
        }

        #endregion

        #region Helper Methods

        private void SetupTest()
        {
            var mockContext = MockedFactory.MockTicketAppContext();
            _classUnderTest = new RequestTicketLogic(mockContext.Object);
        }

        private async Task<Ticket?> CallMethodAsync(int? id)
            => await _classUnderTest.GetTicketAsync(id);

        #endregion
    }
}