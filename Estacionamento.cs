namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = ("");
            placa = Console.ReadLine();
            veiculos.Add (placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Implementado!
            string placa = ("");
            placa = Console.ReadLine();                       
                        
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {                           
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");             
            // Implementado!
                int horas = 0;
                decimal valorTotal = 0; 
                horas = int.Parse(Console.ReadLine());
                valorTotal = (precoPorHora * horas) + precoInicial;           
            // Implementado!
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove (placa);                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");               
            }
        }

        public void ListarVeiculos()
        {           
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
            // Implementado!
                foreach(string veiculos in veiculos)
                {
                    Console.WriteLine(veiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}