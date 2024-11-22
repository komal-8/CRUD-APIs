using CRUD_App_With_MYSQL_VCoder.CommonLayer.Model;
using CRUD_App_With_MYSQL_VCoder.Controllers;
using CRUD_App_With_MYSQL_VCoder.RepositoryLayer;

namespace CRUD_App_With_MYSQL_VCoder.ServiceLayer
{
    public class CRUDApplicationSL:ICRUDApplicationSL
    {
        public readonly ICrudApplicationRL _crudApplicationRL;
        public readonly ILogger<CRUDApplicationSL> _logger;
        public CRUDApplicationSL (ICrudApplicationRL crudApplicationRL, ILogger<CRUDApplicationSL> logger)
        {
            _crudApplicationRL = crudApplicationRL; 
            _logger = logger;   
        }

        public async Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        {
            _logger.LogInformation("Add Information method is called in service layer");
            return await _crudApplicationRL.AddInformation(request);
        }

        public async Task<DeleteInformationByIDResponse> DeleteInformationById(DeleteInformationByIDRequest request)
        {
            return await _crudApplicationRL.DeleteInformationById(request);
        }

        public async Task<ReadInformationResponse> ReadAllInformation()
        {
            return await _crudApplicationRL.ReadAllInformation();
        }

        public async Task<UpdateInformation.UpdateAllInformationByIdResponse> UpdateAllInformationById(UpdateInformation.UpdateAllInformationByIdRequest request)
        {
            return await _crudApplicationRL.UpdateAllInformationById(request);
        }
    }
}
