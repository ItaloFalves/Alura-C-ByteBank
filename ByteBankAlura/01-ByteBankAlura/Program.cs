using System;

namespace _01_ByteBankAlura
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente ClienteItalo = new Cliente();

            ClienteItalo.nome = "Italo Alves";
            ClienteItalo.profissao = "Desenvolvedor";
            ClienteItalo.cpf = "666.666.666-66";

            ContaCorrente contaCorrenteItalo = new ContaCorrente();

            // Ou em vez de fazer todo o codigo acima, podemos fazer assim: contaCorrenteItalo.titular = new Cliente (); e depois ir atribuindo os valores, exp: contaCorrenteItalo.titular.nome = "Italo";
            contaCorrenteItalo.titular = ClienteItalo;
            contaCorrenteItalo.agencia = 893;
            contaCorrenteItalo.numero = 89342;
            contaCorrenteItalo.DefinirSaldo(200); // Estamos atribuindo um valor no campo de saldo privado atraves de um metodo. 
            //contaCorrenteItalo.saldo = 1000;  //mudamos o codigo, e colocanmos um metodo para mostrar o saldo. 

            Console.WriteLine("Titular: " + contaCorrenteItalo.titular.nome); // se não colocar o ponto "." e o caminho, estarei acessando apenas o objeto.
            Console.WriteLine("Titular: " + contaCorrenteItalo.titular.ToString()); //Com esse metodo estarei acessando todas as informações na classe do cliente. 
            Console.WriteLine("Agência: " + contaCorrenteItalo.agencia);
            Console.WriteLine("Numero da conta: " + contaCorrenteItalo.numero);
            //Console.WriteLine("Saldo disponivel: " + contaCorrenteItalo.saldo); Mudamos o jeito para visualizar o saldo, podendo ser visto qual é o saldo atraves de um metodo.
            Console.WriteLine("Saldo Disponivel R$ " + contaCorrenteItalo.ObterSaldo()); // colocamos esse metodo para mostrar o saldo. Lembrando que o saldo se tornou "private"

            //contaCorrenteItalo.Sacar(valor): Esse comando seria para sacar dinheiro. colocando o valor desejado dentro do "valor".
            //contaCorrenteItalo.Depositar(valor): Esse comando é para depositar, colocando o valor desejado dentro do "valor"; não tem como guardar dentro de uma variavel porque não retorna nada.
            //contaCorrenteItalo.Transferir(valor,contaDestino); Esta sendo passado dois parametros dentro do transferir, o visual studio já sinaliza para gente.

            Console.ReadKey();
        }
    }
}
