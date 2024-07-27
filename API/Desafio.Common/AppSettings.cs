using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Common
{
    public class AppSettings
    {
        public string ConnectionString { get; set; } = "Server=localhost;DataBase=bibliotecaDesafio;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False";
    }
}
