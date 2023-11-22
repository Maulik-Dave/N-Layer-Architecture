namespace DotNetCoreApi.ViewModel
{
    public class EmployeeMasterFormViewModel
    {
        public int EmployeeMasterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Mobile { get; set; }
        public string EmailAddress { get; set; }
        public bool IsFavourite { get; set; }
        public int DisplayOrder { get; set; }
        public string EmployeeMasterDeleted { get; set; }
        public string EmployeeMasterUserUpdated { get; set; }
        public DateTime? EmployeeMasterUpdatedDateTime { get; set; }
    }
}