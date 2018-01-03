using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace SharpView {
    class SharpView {
        public static Domain GetDomain(String domainName = "") { //TODO accept user credentials
            Domain domain = null;
            if (!String.IsNullOrEmpty(domainName)) {
                var domainContext = new DirectoryContext(DirectoryContextType.Domain, domainName);
                domain = Domain.GetDomain(domainContext);
            }            
            else {
                domain = Domain.GetCurrentDomain();
            }
            return domain;
        }
    }
}
class Program {
    static void Main(string[] args) {
        string command = args[0];
        string argument = args[1];
        Console.WriteLine("Executing command {0} with arguments {1}", command, argument);
        Domain domain = null;
        if (command.ToLower().Equals("getdomain")) {
            Console.WriteLine("entering function");
            domain = SharpView.SharpView.GetDomain(argument);
            Console.WriteLine(domain);
            Console.WriteLine(domain.DomainControllers[0]);
            Console.WriteLine(domain.DomainMode);
            Console.WriteLine(domain.Children[0]);
            Console.WriteLine(domain.Parent);
        }
    }
}
    

