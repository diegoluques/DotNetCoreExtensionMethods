namespace DotNetCoreExtensionMethods
{
    public class ProcessaPagamento
    {
        public static void Processar()
        {
            var sair = true;
            
            while (sair)
            {
                Menu();
                
                var opcaoSelecionada = Console.ReadKey();

                if (opcaoSelecionada.KeyChar == '4')
                {
                    sair = false;
                    Console.WriteLine("");
                    Console.WriteLine("Saindo do programa...");
                    Environment.Exit(0);
                }
                
                var pagamento = DadosPagamento();
                var retorno = string.Empty;
               
                switch (opcaoSelecionada.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Realizando pagamento com Crédito");
                        Console.WriteLine("...");
                        retorno = $"Banco: {pagamento.PagarCredito().Banco} | Valor: {pagamento.PagarCredito().Valor}";
                        break;

                    case '2':
                        Console.WriteLine("Realizando pagamento com Crédito");
                        Console.WriteLine("...");
                        retorno = $"Banco: {pagamento.PagarDebito().Banco} | Valor: {pagamento.PagarDebito().Valor}";
                        break;

                    case '3':
                        Console.WriteLine("Realizando pagamento com Crédito");
                        Console.WriteLine("...");
                        retorno = $"Banco: {pagamento.PagarPix().Banco} | Valor: {pagamento.PagarPix().Valor}";
                        break;
                    
                    default:
                        break;
                }
                
                RetornoPagamento(retorno);
            }
        }

        private static void RetornoPagamento(string retorno)
        {
            Console.WriteLine($"Pagamento realizado com sucesso: {retorno}");
            Console.WriteLine("");
            Console.WriteLine(".................................");
        }

        private static RealizaPagamento DadosPagamento()
        {
            Console.WriteLine("");
            Console.WriteLine(".................................");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome do banco:");
            var nomeBanco = Console.ReadLine();
            Console.WriteLine("Digite o valor a pagar:");
            var valorPagar = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            
            var realizaPagamento = new RealizaPagamento
            {
                Banco = nomeBanco,
                Valor = valorPagar
            };

            return realizaPagamento;
        }

        private static void Menu()
        {
            Console.WriteLine("Efetuar Pagamento");
            Console.WriteLine("Escolhe um meio de pagamento:");
            Console.WriteLine("");
            Console.WriteLine("1 - Pagamento com Crédito;");
            Console.WriteLine("2 - Pagamento com Débito;");
            Console.WriteLine("3 - Pagamento com Pix;");
            Console.WriteLine("4 - Sair;");
        }
    }
}
