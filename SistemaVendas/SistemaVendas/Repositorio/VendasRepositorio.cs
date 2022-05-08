using System;
using System.Collections.Generic;

namespace SistemaVendas
{
    public class VendasRepositorio : IVendasRepositorio
    {
        public IList<Vendas> BuscarVendas(short mes, short ano)
        {
            return new List<Vendas>
            {
                new Vendas
                {
                    Data = new DateTime(2020, 04, 02),
                    Valor = 300.00m
                },
                new Vendas
                {
                    Data = new DateTime(2021, 04, 02),
                    Valor = 400.00m
                },
                new Vendas
                {
                    Data = new DateTime(2022, 04, 02),
                    Valor = 500.00m
                },
                new Vendas
                {
                    Data = new DateTime(2020, 04, 02),
                    Valor = 500.00m
                },
                new Vendas
                {
                    Data = new DateTime(2021, 04, 02),
                    Valor = 600.00m
                },
                new Vendas
                {
                    Data = new DateTime(2022, 04, 02),
                    Valor = 700.00m
                }
            };
        }
    }
}