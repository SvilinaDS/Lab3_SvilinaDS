using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IExternalDependency
    {
        void SendEmail(string email);
    }

    public class ExternalDependencySim : IExternalDependency
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Success; Sending an email {email}");
        }
    }
}
