using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Payment.Models;
using Payment.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Payment.Models.DTOs.Responses;

namespace Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class PaymentDetailController : ControllerBase
    {

        private readonly ApiDbContext _context;
        
        public PaymentDetailController(ApiDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetDetails()
        {
            var Details = await _context.tb_paymentdetail.ToListAsync();
            return Ok(Details);
        }


        [HttpPost]
        public async Task<IActionResult> CreateDetail(PaymentData data)
        {
            if (ModelState.IsValid)
            {
                await _context.tb_paymentdetail.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetDetail", new { data.paymentDetailId }, data );
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{paymentDetailId}")]
        public async Task<IActionResult> GetDetail(int paymentDetailId)
        {
            var Detail = await _context.tb_paymentdetail.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);
                
            if(Detail == null)
            {
                return NotFound(new DetailResponse()
                {
                    Message = new List<string>(){
                            "Data Not Found"
                        },
                    result = NotFound(),
                    Success = false
                }); ;
            }
            return Ok(Detail);
        }

        [HttpPut("{paymentDetailId}")]
        public async Task<IActionResult> UpdateDetail(int paymentDetailId, PaymentData data)
        {
            if (paymentDetailId != data.paymentDetailId)
            {
                return BadRequest();
            }

            var existData = await _context.tb_paymentdetail.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);

            if(existData == null)
            {
                return NotFound();
            }

            existData.paymentDetailId = data.paymentDetailId;
            existData.cardOwnerName = data.cardOwnerName;
            existData.cardNumber = data.cardNumber;
            existData.expirationDate = data.expirationDate;
            existData.securityCode = data.securityCode;

            await _context.SaveChangesAsync();

            return Ok(new DetailResponse()
            {
                Message = new List<string>(){
                            "Data has been updated"
                        },
                result = existData,
                Success = true
            });
        }

        [HttpDelete("{paymentDetailId}")]
        public async Task<IActionResult> DeleteDetail (int paymentDetailId)
        {
            var existData = await _context.tb_paymentdetail.FirstOrDefaultAsync(x => x.paymentDetailId == paymentDetailId);

            if(existData == null)
            {
                return NotFound();
            }

            _context.tb_paymentdetail.Remove(existData);
            await _context.SaveChangesAsync();

            return Ok(new DetailResponse()
            {
                Message = new List<string>(){
                            "Data has been deleted"
                },
                Success = true
                
            });
        }
    }
}
