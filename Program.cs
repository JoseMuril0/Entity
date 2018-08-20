using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraPraticandoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdcionarCliente();
            BuscaDadosCliente();
            DeletarCliente(); 
            BuscaDadosCliente();

            Console.ReadLine();
        }

        private static void DeletarCliente()
        {
            using(var repor = new LojaContext())
            {
                IList<Cliente> clientes = repor.Clientes.ToList();
                foreach(var item in clientes)
                {
                    repor.Remove(item);
                }
                repor.SaveChanges();
                Console.WriteLine("Deletado com sucesso!");

            }
        }

        private static void BuscaDadosCliente()
        {
            using (var repor = new LojaContext())
            {
                IList<Cliente> clientes = repor.Clientes.ToList();
                Console.WriteLine("Quantidade de clientes achando no BD {0}", clientes.Count);
                foreach (var item in clientes)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void AdcionarCliente()
        {
            
            Cliente cliente2 = new Cliente();
            cliente2.Nome = "icaro";
            cliente2.Saldo = 10309.30;

            Cliente cliente3 = new Cliente();
            cliente3.Nome = "Marcelo";
            cliente3.Saldo = 20309.30;
            using (var repor = new LojaContext())
            {
                repor.Clientes.AddRange(cliente2, cliente3);
                repor.SaveChanges();
                Console.WriteLine("Adcionado com sucesso!");
            }
        }
    }
}
