using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Brinde> list = new List<Brinde>();

			Transportadora BoaDex = new Transportadora(10, 0.5, "BoaDex");
			Transportadora BoaLog = new Transportadora(4.30, 0.12, "BoaLog");
			Transportadora Transboa5 = new Transportadora(2.10, 1.10, "Transboa5");
			Transportadora Transboa5up = new Transportadora(10, 0.01, "Transboa5up");

			List<Transportadora> transportadoras = new List<Transportadora>();
			transportadoras.Add(BoaDex);
			transportadoras.Add(BoaLog);
			transportadoras.Add(Transboa5);
			transportadoras.Add(Transboa5up);

			Console.WriteLine("Digite 1 para calcular frete de brinde\nDigite 2 para sair do sistema: ");
			int menu = Int32.Parse(Console.ReadLine());

			switch (menu)
			{
                case 1:
					Console.WriteLine("Informe o nome do brinde: ");
					String nome = Console.ReadLine();
					Console.WriteLine("Informe o peso do brinde: ");
					int peso = Int32.Parse(Console.ReadLine());
					Console.WriteLine("Informe a distância para envio:");
					int distancia = Int32.Parse(Console.ReadLine());

					Brinde brinde = new Brinde(nome, peso, distancia);


					list.Add(brinde);

										
					foreach (Transportadora trans in transportadoras)
					{
						trans.calculaFrete(peso, distancia);
					}

					IEnumerable<Transportadora> query = transportadoras.OrderBy(trans => trans.calculaFrete);
					
					break;

				case 2:
					Console.WriteLine("\nSaindo do sistema.");

					break;
				default:
					Console.WriteLine("\nComando não encontrado, por favor tente novamente");
					break;

			}

	}
}
}
