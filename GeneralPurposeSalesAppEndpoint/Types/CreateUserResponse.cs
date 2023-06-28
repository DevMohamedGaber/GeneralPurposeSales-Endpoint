namespace GeneralPurposeSalesAppEndpoint.Types
{
    public class CreateUserResponse
    {
        public bool isSuccess { get; set; }
        public IEnumerable<string> errors { get; set; }
    }
}
