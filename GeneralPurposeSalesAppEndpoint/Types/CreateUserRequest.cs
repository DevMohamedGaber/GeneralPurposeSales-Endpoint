namespace GeneralPurposeSalesAppEndpoint.Types
{
    public class CreateUserRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
