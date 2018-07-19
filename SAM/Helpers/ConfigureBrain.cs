using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SAM.Helpers
{
    public class ConfigureBrain
    {
        public string BrainModules;

        public void Think()
        {

        }

        public ConfigureBrain Store()
        {
            if (Directory.Exists("Brain"))
                Directory.CreateDirectory("Brain");
            if (File.Exists("Brain/Module.brain"))
                File.WriteAllText("Brain/Module.brain", BrainModules);
            return this;
        }

        public ConfigureBrain Init()
        {
            BrainModules = string.Empty;

            if (Directory.Exists("Brain"))
                Directory.CreateDirectory("Brain");
            if(File.Exists("Brain/Module.brain"))
                BrainModules = File.ReadAllText("Brain/Module.brain");

            return this;
        }
    }
}
