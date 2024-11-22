using CRUD_App_With_MYSQL_VCoder.CommonLayer.Model;
using static CRUD_App_With_MYSQL_VCoder.CommonLayer.Model.UpdateInformation;

namespace CRUD_App_With_MYSQL_VCoder.RepositoryLayer
{
    public interface ICrudApplicationRL
    {
        //interface method
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
        public Task<ReadInformationResponse> ReadAllInformation();

        public Task<UpdateAllInformationByIdResponse> UpdateAllInformationById(UpdateAllInformationByIdRequest request);

        public Task<DeleteInformationByIDResponse> DeleteInformationById(DeleteInformationByIDRequest request);

    }
}
