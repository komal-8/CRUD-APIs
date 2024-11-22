namespace CRUD_App_With_MYSQL_VCoder.Common_Utility
{
    public class SqlQueries
    {
        //using Iconfiguration we can import data files like json, xml
        public static IConfiguration _sqlQueryConfiguration = new ConfigurationBuilder()
            .AddXmlFile("SqlQueries.xml", true, true)
            .Build();

        public static string AddInformation { 
            get {
                return _sqlQueryConfiguration["AddInformation"];
            }
        }
        public static string ReadInformation {
            get 
            { 
                return _sqlQueryConfiguration["ReadInformation"];
            }
        }
        public static string UpdateAllInformationById
        {
            get
            {
                return _sqlQueryConfiguration["UpdateAllInformationById"];
            }
        }
        public static string DeleteInformationByID
        {
            get
            {
                return _sqlQueryConfiguration["DeleteInformationByID"];
            }
        }

    }
}
