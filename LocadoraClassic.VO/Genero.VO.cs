using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LocadoraClassic.VO
{
    public class Genero

    {
        // Crie as Propriedades automaticas
        // Crie tres construtores

        public int    ID   { get; set; }
        public string Nome { get; set; }
        
        public string Tipo { get; set; }
       
        public Genero() 
        
        { 
        
        }
        public Genero( int id,string nome, string tipo)
        {
            ID = id;
            Nome = nome;
            Tipo = tipo;

        }

        public Genero(string nome)

        {
            Nome = nome;
        
        }


    }
}
