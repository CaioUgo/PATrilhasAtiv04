using System;
namespace PrimeiraAtividade
{
	class Program
	{
		public static void Main()
		{	

			Console.Write("Digite um número: ");
			float numero = Convert.ToSingle (Console.ReadLine());
		 	
		 	if (numero > 10 || numero < 0){
				Console.WriteLine("\n\rNúmero inválido!");
			}
		
			Console.WriteLine("\n\rAperte alguma tecla para fechar...");
			Console.ReadKey(true);
		}
	}
}
