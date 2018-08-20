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
           // AdcionarCliente();

            //AtualizarCliente();

            BuscaDadosCliente();
            Console.ReadLine();
        }

        private static void SaveChangesEntity(LojaContext contexto)
        {
            using (contexto)
            {
                var clientes = contexto.Clientes.ToList();
                foreach (var item in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine($"{item.State} <--- Estado");
                }
            }
        }

        private static void DeletarCliente()
        {
            using(var repor = new LojaContext())
            {
                IList<Cliente> clientes = repor.Clientes.ToList();
                foreach(var item in clientes)
                {
                    Console.WriteLine($"{item.Nome} Deletado com sucesso =)");
                    repor.Remove(item);
                }
                repor.SaveChanges();

            }
        }

        private static void BuscaDadosCliente()
        {
            using (var repor = new LojaContext())
            {
                IList<Cliente> clientes = repor.Clientes.ToList();
                Console.WriteLine("Quantidade de clientes achando no Banco de Dados: {0}", clientes.Count);
                foreach (var item in clientes)
                {
                    Console.WriteLine("................................");
                    Console.WriteLine(item);
                    Console.WriteLine("................................");
                }
            }
        }

        private static void AdcionarCliente()
        {

            Cliente cliente1 = new Cliente() {
                Nome = "Gilberto",
                Saldo = -100.4
            };

            //Cliente cliente2 = new Cliente();
            //cliente2.Nome = "Antonio";
            //cliente2.Saldo = 1309.30;

            //Cliente cliente3 = new Cliente();
            //cliente3.Nome = "Roberta";
            //cliente3.Saldo = 2309.30;
            using (var repor = new LojaContext())
            {
                repor.Clientes.AddRange(cliente1);
                SaveChangesEntity(repor);
                repor.SaveChanges();
                Console.WriteLine("Depois das alterações da aplicação");
              //  SaveChangesEntity(repor);
            }
        }

        private static void AtualizarCliente()
        {
             using(var repor = new LojaContext())
            {
                Cliente primeiro = repor.Clientes.First();
                primeiro.Nome = "Lampeão SAD";
             
                SaveChangesEntity(repor);
                repor.SaveChanges();
            }
        } 
    }
}
