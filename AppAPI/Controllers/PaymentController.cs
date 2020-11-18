using App.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AppAPI.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {

        readonly IPaymentSevice _paymentSevice;
        public PaymentController(IPaymentSevice paymentSevice)
        {
            this._paymentSevice = paymentSevice;
        }


        [Route("{userId}")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> AddPayment([FromRoute]Guid userId, [FromBody]ViewModelPaymentData request)
        {
            _paymentSevice.PaymentCreated(request);
            return Created(string.Empty, null);
        }
    }
}
