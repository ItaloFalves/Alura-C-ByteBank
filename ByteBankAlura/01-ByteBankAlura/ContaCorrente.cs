//using _01_ByteBankAlura; // Usando o comando using que é uma palavra reservada do compilador, não precisa ficar usando o namespace toda hora que chamar a classe. vejamos na linha 10.

namespace _01_ByteBankAlura // Sempre colocar o namespace nas classes se não tiver.
{

    public class ContaCorrente

    {
        // public _01_ByteBankAlura.Cliente titular; colocar o namespace para chamar a classe da classe, que no caso é _01_ByteBankAlura
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor) // Double dentro do parenteses, pois o valor do saldo é double // bool para saber se o saque foi feito com sucesso ou não.
        {
            if (this.saldo < valor)  //this é uma palavra reservada do C# para poder acessar a informação desta instacia 
            {
                return false; //É outra palavra reservada que indica que estamos devolvendo um valor para quem chamou essa função.
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor) //void ( Para ação que não tem retorno) ou seja, essa funçao não tem retorno.
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else  // Nao precisa da instrução "else". Pois ao cair no return, ele já para o restante do codigo.
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}