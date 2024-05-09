using Microsoft.AspNetCore.Mvc;
using TicketSystemBusinessLayer.BusinessLogic.RequestTicket;
using TicketSystemEntities.Database;

namespace TicketApp.Controllers.V2
{
    [Route("api/v2/[controller]")]
    public class TicketController : Controller
    {
        #region Fields

        private readonly IRequestTicketLogic _requestTicketLogic;

        #endregion

        #region Constructor

        public TicketController(
            IRequestTicketLogic requestTicketLogic)
        {
            _requestTicketLogic = requestTicketLogic;
        }

        #endregion

        #region Standard Route Actions

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateTicketAsync([FromBody] Ticket ticket)
        {
            await _requestTicketLogic.CreateTicketAsync(ticket);
            return Ok();
        }

        [HttpDelete("{id:int?}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteTicketAsync([FromRoute] int? id)
        {
            await _requestTicketLogic.DeleteTicketAsync(id);
            return Ok();
        }

        [HttpGet("{id:int?}")]
        [ProducesResponseType(typeof(Ticket), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTicketAsync([FromRoute] int? id)
        {
            var result = await _requestTicketLogic.GetTicketAsync(id);
            return Ok(result);
        }

        [HttpGet("{id:int?}")]
        [ProducesResponseType(typeof(IEnumerable<Ticket>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTicketsAsync()
        {
            var result = _requestTicketLogic.GetTickets();
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateTicketAsync([FromBody] Ticket ticket)
        {
            await _requestTicketLogic.UpdateTicketAsync(ticket);
            return Ok();
        }
        #endregion
    }
}
