using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace SharpView {
    namespace System.DirectoryServices.ActiveDirectory {
        class Program {
            static Domain GetDomain(String domainName = "") { //TODO accept user credentials
                if (!String.IsNullOrEmpty(domainName)) {
                    var domainContext = new DirectoryContext(DirectoryContextType.Domain, domainName);
                    return Domain.GetDomain(domainContext);
                }
                else {
                    return Domain.GetCurrentDomain();
                }
                

            }

            static void Main(string[] args) {

            }
        }
    }
}