using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void BasvuruYap(ICrediManager crediManager,List<ILoggerService> loggerService)
        {

            crediManager.Hesapla();

            foreach(var log in loggerService)
            {
                log.Log();
            }
            
        }

        public void MakeCreditPreliminaryInformation(ICrediManager credits, ILoggerService loggerService)
        {
            credits.Hesapla();
            loggerService.Log(); 
        }
    }
}
