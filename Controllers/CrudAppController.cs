using CRUD_App_With_MYSQL_VCoder.CommonLayer.Model;
using CRUD_App_With_MYSQL_VCoder.ServiceLayer;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static CRUD_App_With_MYSQL_VCoder.CommonLayer.Model.UpdateInformation;

namespace CRUD_App_With_MYSQL_VCoder.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CrudAppController : ControllerBase
    {
        public readonly ICRUDApplicationSL _crudApplicationSL;//instance has been created
        public readonly ILogger<CrudAppController> _logger;
        //controller has beeen joined to Sl using dependency injection
        public CrudAppController(ICRUDApplicationSL crudApplicationSL, ILogger<CrudAppController> logger)
        {
            _crudApplicationSL = crudApplicationSL;
            _logger = logger;   
        }

        //Insert ka skeleton
        [HttpPost]
        public async Task<IActionResult> AddInformation(AddInformationRequest request)// iske paranthesis m hum request body ko daalte h
        {
            AddInformationResponse response = new AddInformationResponse();
            _logger.LogInformation($"AddInformation API calling in controller..{JsonConvert.SerializeObject(request)}");
            try 
            {
                response = await _crudApplicationSL.AddInformation(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new {IsSuccess=response.IsSuccess,Message=response.Message});
                }
            }
            catch(Exception ex) {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"AddInformation API errorn has occured : Message {ex:Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
            }
            return Ok(response);
        }

        [HttpGet]
        //[Route("ReadInformation")]
        public async Task<IActionResult> ReadAllInformation()
        {
            ReadInformationResponse response = new ReadInformationResponse();
            try
            {

                response = await _crudApplicationSL.ReadAllInformation();
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.readInformation });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"ReadAllInformation Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message, Data = response.readInformation });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.readInformation });
        }


        [HttpPut]
        //[Route("UpdateAllInformationById")]
        public async Task<IActionResult> UpdateAllInformationById(UpdateAllInformationByIdRequest request)
        {
            UpdateAllInformationByIdResponse response = new UpdateAllInformationByIdResponse();
            _logger.LogInformation($"UpdateAllInformationById Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.UpdateAllInformationById(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"UpdateAllInformationById Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

        [HttpDelete]
        //[Route("DeleteInformationByID")]
        public async Task<IActionResult> DeleteInformationByID(DeleteInformationByIDRequest request)
        {
            DeleteInformationByIDResponse response = new DeleteInformationByIDResponse();
            _logger.LogInformation($"DeleteInformationByID Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.DeleteInformationById(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"DeleteInformationByID Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });

        }
    }
}
