using IndigoTestProject.API.Data;
using IndigoTestProject.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndigoTestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyProductController : ControllerBase
    {
        private readonly IndigoTestDBContext _context;
        public BuyProductController(IndigoTestDBContext context)
        {
            _context = context;
        }
        [HttpPut("saveSale")]
        public async Task<IActionResult> saveProduct([FromBody] List<Sales> Sale)
        {
            try
            {               

                _context.Sales.AddRangeAsync(Sale);

                foreach (var sale in Sale)
                {
                    var product = await _context.Products.FindAsync(sale.ProductId);
                    if (product != null)
                    {
                        product.Quantity -= sale.Quantity;
                        _context.Products.Update(product);
                    }
                }

                await _context.SaveChangesAsync();
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                responseModel.Data = "true";
                responseModel.Message = "Guardado correctamente";

                return Ok(responseModel);
            }
            catch
            (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return StatusCode(500, responseModel);
            }

        }
    }
}
