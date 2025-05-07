using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        public string Path { get; set; }
        public static Logger? instance { get; set; } = null;
        //priva a classe de ser instanciada
        private Logger()
        {
            Path = Directory.GetCurrentDirectory() + @"\log.txt";
        }

        public static Logger Instance()
        {
            return instance = new Logger();
        }

        public void GravarLog(string mensagem)
        {
            File.WriteAllText(Path,mensagem);
        }
    }
}
