using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Estacionamento
    {
        public List<string>? CarrosEstacionados = new List<string>();
        public decimal PrecoInicial { get; set; }
        public decimal PrecoHora { get; set; }

        public void CadastrarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string? placa = Console.ReadLine();
            this.CarrosEstacionados.Add(placa);
        }

        public void RemoverVeiculo()
        {
            if (!this.CarrosEstacionados.Any())
            {
                Console.WriteLine("🚫Nenhum carro foi adicionado ainda!🚫");
                return;
            }

            Console.Write("Digite a placa do veículo para remover: ");
            string? placa = Console.ReadLine();

            if (this.CarrosEstacionados.Contains(placa)) 
            {
                Console.Write("Digite o tempo (horas) que o veículo permaneceu estacionado: ");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {CalcularValorFinal(tempo)}");
                this.CarrosEstacionados.Remove(placa);
            }
            else {
                Console.WriteLine("🚫Digite uma placa válida!🚫");
            }
        }

        public void ListarVeiculos()
        {
            if (this.CarrosEstacionados.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string placa in this.CarrosEstacionados)
                {
                    Console.WriteLine(placa);
                }
            }
            else {
                Console.WriteLine("Não há nenhum carro estacionado...");
            }
        }

        /// <summary>
        /// Esse método calcula o valor final do pagamento pelo usuário
        /// </summary>
        /// <param name="tempo">Tempo que o usuário deixou o carro estacionado</param>
        /// <returns>Valor a ser pago pelo usuário</returns>
        private decimal CalcularValorFinal(int tempo)
        {
            return this.PrecoInicial + (this.PrecoHora * (tempo - 1));
        }
    }
}