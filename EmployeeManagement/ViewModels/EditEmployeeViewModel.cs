namespace EmployeeManagement.ViewModels
{
    public class EditEmployeeViewModel:EmployeeCreateViewModel
    {
        public int Id { get; set; }

        public string ExistingPhotoPath { get; set; }
    }
}
