using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AppSettings
    {
        public JwtSettings JwtSettings { get; set; }
        public RabbitMQSettings RabbitMQSettings { get; set; }
        public RedisSettings RedisSettings { get; set; }
        public string YodleeApiUrl { get; set; }
        public string YodleeApiKey { get; set; }
    }
}
