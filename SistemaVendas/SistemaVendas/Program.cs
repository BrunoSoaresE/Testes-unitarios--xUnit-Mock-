using System;

namespace SistemaVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorMediaMensal2020 = new VendasNegocio(new VendasRepositorio()).CalcularMediaMensal(04, 2020);
            var valorMediaMensal2021 = new VendasNegocio(new VendasRepositorio()).CalcularMediaMensal(04, 2021);
            var valorMediaMensal2022 = new VendasNegocio(new VendasRepositorio()).CalcularMediaMensal(04, 2022);
            
            Console.WriteLine($"Valor Médio de Vendas no Mês 04, 2020: {valorMediaMensal2020}");
            Console.WriteLine($"Valor Médio de Vendas no Mês 04, 2021: {valorMediaMensal2021}");
            Console.WriteLine($"Valor Médio de Vendas no Mês 04, 2022: {valorMediaMensal2022}");
        }
    }
}
