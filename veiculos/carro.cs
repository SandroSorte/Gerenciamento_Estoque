namespace Veiculos
{
    class Carro : Veiculo
    {
        public Carro(int CodId, string Marca, string Modelo, decimal Preco) : base(CodId, Marca, Modelo, Preco)
        {

        }

        public static Carro carro1 = new(101, "Toyota", "Corolla", 148990);
        public static Carro carro2 = new(102, "Toyota", "Yaris Sedan", 97990);
        public static Carro carro3 = new(103, "Toyota", "Yaris Hatch", 97990);

    }
}