using System;

public class AppSettings
{
    public JwtSettings JwtSettings { get; set; }
    public RabbitMQSettings RabbitMQSettings { get; set; }
    public RedisSettings RedisSettings { get; set; }
    public string YodleeApiUrl { get; set; }
    public string YodleeApiKey { get; set; }
}
