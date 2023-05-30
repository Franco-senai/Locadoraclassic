using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Categoria
    
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Diaria { get; set;}


        public Categoria() 

        { 
        
        }

        public Categoria(int id, string nome, double diaria)
        {
            Id = id;
            Nome = nome;
            Diaria = diaria;
        }

        public Categoria( string name)
        
        { 
        
        Nome = name;
        
        }
    }
}
