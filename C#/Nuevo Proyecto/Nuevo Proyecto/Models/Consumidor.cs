using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_Proyecto.Models
{
    internal class Consumidor
    {

        private string _id = "Admin";
        private string _pw = "def.789";
    
       
        public bool VerificarConsumidor(string id, String pw)
        { 
            Consumidor Consumidores = new Consumidor(); 
            Assert.IsTrue(Consumidores.VerificarConsumidor(_id, pw));
        
            return id.Equals(_id) && pw.Equals(_pw); 
        }
    }
}
