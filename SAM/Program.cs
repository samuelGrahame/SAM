using SAM.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM
{
    class Program
    {
        [ThreadStatic]
        static ConfigureBrain ActiveBrain;
        static void Main(string[] args)
        {
            ActiveBrain = new ConfigureBrain().Init();

            // while alive
            try
            {
                var thread = new Thread(() =>
                {
                    ActiveBrain.Think();

                });
                thread.Start();    
                
                while(thread.IsAlive)
                {

                }

                // lived to old age
            }
            catch (Exception)
            {
                // got murdered!

            }

            ActiveBrain.Store();
        }
    }
}
