using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {

        public Cliente() 
        
        {
            
        }

        public int ID { get; set; }
        public string NomeCliente { get; set; }

        public string Endereco { get; set; }

        public long Telefone { get; set;}

        public string CPF { get; set; }

        public int RG { get; set; }


        public Cliente( int id,string nomeCliente, string cpf,string endereco, long telefone, int rg) 
        
        { 
        
        ID = id;
        NomeCliente = nomeCliente;
        Endereco = endereco;
        Telefone = telefone;
        CPF = cpf;
        RG = rg;
        
        }

        public Cliente(string nomeCliente, string cpf) 
        
        
        {
        
        NomeCliente=nomeCliente;
        CPF = cpf;
        
        }

        public Cliente(string nomeCliente, int rg) 
        
        {
        
            NomeCliente= nomeCliente;
            RG = rg;
        
        }
        






    }
}
