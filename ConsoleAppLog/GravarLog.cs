using log4net;
using System;

namespace ConsoleAppLog
{
    public class GravarLog
    {
        private ILog Log;

        public void CriarLog()
        {
            Log = LogManager.GetLogger("ApplicationLog");
            log4net.Config.XmlConfigurator.Configure();

            Log.Info("----------------- INICIANDO SERVIÇO -----------------");
            Log.Info("Data do log: " + DateTime.Now);            

            for (int i = 0; i <= 10; i++)
            {
                Log.Info("Contador: " + i);
            }

            Log.Info("----------------- FINALIZANDO SERVIÇO -----------------");
        }
    }
}
