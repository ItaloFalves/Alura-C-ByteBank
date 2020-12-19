using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBankAlura
{
    public class Cliente
    {
        // ToString, é um metodo para poder retornar todas as informações do cliente.
        public string ToString() 
        { 
            return nome + cpf + profissao;
        } 
        
        public string nome;
        public string cpf;
        public string profissao;
    }
}
