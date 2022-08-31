using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLib.Models
{
    [Serializable]
    public class ServerInfo
    {
        [Key]
        public string Adress { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }

        public ServerInfo(string Adress, int Port, string Protocol)
        {
            this.Adress = Adress;
            this.Port = Port;
            this.Protocol = Protocol;
            
        }
        public ServerInfo()
        {
            Adress = "";
            Port = 0;
            Protocol = "";
        }
    }
}
