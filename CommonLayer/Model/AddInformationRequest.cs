using System.ComponentModel.DataAnnotations;

namespace CRUD_App_With_MYSQL_VCoder.CommonLayer.Model
{
    //Request body
    public class AddInformationRequest
    {
        //insert information ki request body create krenge
        //and request bodies are created in common layer

        [Required(ErrorMessage = "UserName Is Mandetory Field")]
        public string UserName {  get; set; }

        [Required]
        [RegularExpression("^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,3})?$", ErrorMessage = "Email Id Not In Currect Format Example : VishalTechnology@gmail.com")]
        public string EmailID { get; set; }

        [Required]
        [RegularExpression("^([1-9]{1}[0-9]{9})$", ErrorMessage = "Mobile Number Not In Currect Formate")]
        public string MobileNumber { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a Salary Greater than 0")]
        public int Salary {  get; set; }

        [Required]
        [RegularExpression("^(?:m|male|f|female)$", ErrorMessage = "Not valid Gender eg : m, f, Male Or Female")]
        public string Gender { get; set; }

    }
    //Response body
    public class AddInformationResponse
    {
        public bool IsSuccess {  get; set; }
        public string Message { get; set; } 
    }
}
