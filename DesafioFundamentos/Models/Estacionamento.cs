using System.ComponentModel;

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
            Console.Write("Digite a placa do veículo para estacionar: ");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                decimal valorTotal;
                int horas = int.Parse(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas; 

                veiculos.Remove(placa);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\tO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C")}");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.ResetColor();
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                for(int cont = 0; cont < veiculos.Count; cont++){
                    Console.WriteLine($"\tNa vaga: {cont + 1} - veiculo com placa: {veiculos[cont]}");
                }
            }
            else
            {
                Console.WriteLine("\tNão há veículos estacionados.");
            }
        }
    }
}
