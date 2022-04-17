using MAGNA_SERVER.Abstractions;

namespace MAGNA_SERVER.WebApi.Configurations
{
    public class TokenParamaters : ITokenParameters
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Id { get; set; }
    }
}
