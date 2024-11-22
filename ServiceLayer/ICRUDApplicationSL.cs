using CRUD_App_With_MYSQL_VCoder.CommonLayer.Model;
using Org.BouncyCastle.Asn1.Ocsp;
using static CRUD_App_With_MYSQL_VCoder.CommonLayer.Model.UpdateInformation;

namespace CRUD_App_With_MYSQL_VCoder.ServiceLayer
{
    public interface ICRUDApplicationSL
    {
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
        public Task<ReadInformationResponse> ReadAllInformation();

        public Task<UpdateAllInformationByIdResponse> UpdateAllInformationById(UpdateAllInformationByIdRequest request);

        public Task<DeleteInformationByIDResponse> DeleteInformationById(DeleteInformationByIDRequest request);

    }
}
