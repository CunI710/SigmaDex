namespace BLL.Options;

public class JwtOptions
{
    public string SecretKey { get; set; } = string.Empty;
    public string ExpiresHours { get; set; } = string.Empty;
}