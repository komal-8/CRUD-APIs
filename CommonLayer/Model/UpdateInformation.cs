using System.ComponentModel.DataAnnotations;

namespace CRUD_App_With_MYSQL_VCoder.CommonLayer.Model
{
    public class UpdateInformation
    {
        public class UpdateAllInformationByIdRequest
        {
            [Required(ErrorMessage = "UserID Is Required")]
            public int UserId { get; set; }

            [Required(ErrorMessage = "UserName Is Required")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "EmailId Is Required")]
            public string EmailId { get; set; }

            [Required(ErrorMessage = "MobileNumber Is Required")]
            public string MobileNumber { get; set; }

            [Required(ErrorMessage = "Salary Is Required")]
            public int Salary { get; set; }

            [Required(ErrorMessage = "Gender Is Required")]
            public string Gender { get; set; }
        }

        public class UpdateAllInformationByIdResponse
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }

    }
}
