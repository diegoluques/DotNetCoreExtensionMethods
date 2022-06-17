namespace DotNetCoreExtensionMethods
{ 
    public class RealizaPagamento
    {
        public Guid Id { get; set; }
        public string Banco { get; set; }
        public decimal Valor { get; set; }

        public Guid ObterId() => Id = new Guid();
    }
}