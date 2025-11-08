using IndigoTestProject.API.Data;
using IndigoTestProject.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace IndigoTestProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IndigoTestDBContext _context;

        public ProductController(IndigoTestDBContext context)
        {
            _context = context;
        }
                
        [HttpGet("consultProduct")]
        public async Task<IActionResult> consultProduct()
        {
            try
            {
                var products = await _context.Products.ToListAsync();

                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                responseModel.Data = products;
                responseModel.Message = "OK";

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

        [HttpGet("consultProductByCode")]
        public async Task<IActionResult> consultProductByCode(string ProductCode)
        {
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductCode == ProductCode);
                ResponseModel responseModel = new ResponseModel();
                if (product == null)
                {
                    responseModel.Status = false;
                    responseModel.Message = "Producto no encontrado";
                    return Ok(responseModel);
                }
                responseModel.Status = true;
                responseModel.Data = product;
                responseModel.Message = "Producto";

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

        [HttpPut("saveProduct")]
        public async Task<IActionResult> saveProduct([FromBody] Products product)
        {
            try
            {
                var productTemp = await _context.Products.FindAsync(product.Id);
                if (productTemp != null) 
                {
                    productTemp.ProductName = product.ProductName;
                    productTemp.Quantity = product.Quantity;
                    productTemp.Price = product.Price;
                    _context.Products.Update(productTemp);
                }
                else
                {
                    _context.Products.Add(product);
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

        [HttpPost("buyProduct")]
        public async Task<IActionResult> buyProduct()
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                responseModel.Data = "true";
                responseModel.Message = "OK";

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

        [HttpDelete("deleteProduct")]
        public async Task<IActionResult> deleteProduct(int Id)
        {
            try
            {
                var product = await _context.Products.FindAsync(Id);
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                responseModel.Data = "true";
                responseModel.Message = "OK";

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
