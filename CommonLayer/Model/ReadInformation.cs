namespace CRUD_App_With_MYSQL_VCoder.CommonLayer.Model
{
    public class ReadInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<ReadInformation> readInformation { get; set; }
    }

    public class ReadInformation
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
    }
}
