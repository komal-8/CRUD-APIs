using System.ComponentModel.DataAnnotations;

namespace CRUD_App_With_MYSQL_VCoder.CommonLayer.Model
{
    public class DeleteInformationByIDResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    public class DeleteInformationByIDRequest
    {

        [Required]
        public int Id { get; set; }

    }
}
