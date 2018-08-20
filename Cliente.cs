namespace AluraPraticandoBD
{
    public class Cliente
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }


        public override string ToString()
        {
            return "Nome do usuario da conta: " + Nome; 
        }
    }
}