using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {            //interface onu implemate eden classon referansını tutatbilir
            ICrediManager needCrediManager = new NeedCrediManager();
            ICrediManager housingLoancCredi=new HousingLoanCredi();
            ICrediManager vehicleLoan = new VehicleLoan();
            ICrediManager esnafKredis=new EsnafKredisi();

            ILoggerService smsLogger=new SmsLogger();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLogger();
            

            List<ILoggerService> loggerList = new List<ILoggerService>() {databaseLoggerService,fileLoggerService,smsLogger};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(esnafKredis,loggerList);

            Console.WriteLine("**************************");

            ApplicationManager applicationManager2 = new ApplicationManager();
            applicationManager2.MakeCreditPreliminaryInformation(needCrediManager,smsLogger);



        }
    }
}
