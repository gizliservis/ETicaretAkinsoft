using ETicaretAkinsoft.Business.Abstract;
using ETicaretAkinsoft.Entities.Concrate;
using ETicaretAkinsoft.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAkinsoft.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : Controller
    {
        IOrderDetailService _orderDetailService;
        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }


        [HttpPost("add")]
        public IActionResult Add(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Add(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Update(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
