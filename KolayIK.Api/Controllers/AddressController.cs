using KolayIK.Core.DTO;
using KolayIK.Core.Modal;
using KolayIK.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KolayIK.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressInfoService _addressService;

        public AddressController(IAddressInfoService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("GetAddresByID/{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var address = await _addressService.GetAddressById(id);

            if (address == null)
                return NotFound();

            return Ok(address);
        }

        [HttpGet("GetAddressByUserID/{userId}")]
        public async Task<IActionResult> GetAddressByUserId(int userId)
        {
            var address = await _addressService.GetAddressByUserId(userId);

            if (address == null)
                return NotFound();

            return Ok(address);
        }

        [HttpGet("GetAllAddresses")]
        public async Task<IActionResult> GetAllAddressInfo()
        {
            var addresses = await _addressService.GetAllAddressInfo();
            return Ok(addresses);
        }

        [HttpPost("CreateAdress")]
        public async Task<IActionResult> CreateAddressInfo([FromBody] SaveAddressInfoDTO addressDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var address = await _addressService.CreateAddressInfo(addressDTO);
            return CreatedAtAction(nameof(GetAddressById), new { id = address.ID }, address);
        }

        [HttpPut("UpdateAddress/{id}")]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] SaveAddressInfoDTO newAddressData)
        {
            var address = await _addressService.GetAddressById(id);

            if (address == null)
                return NotFound();

            var addressToUpdate = new AddressInfo
            {
                UserID = newAddressData.UserID, 
                CountryID = newAddressData.CountryID,
                CityID = newAddressData.CityID,
                CountyID = newAddressData.CountyID,
                AddressDetail = newAddressData.AddressDetail
            };

            await _addressService.UpdateAddress(addressToUpdate, newAddressData);

            return NoContent();
        }


        [HttpDelete("DeleteAddress/{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var result = await _addressService.DeleteAddress(id);

            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
