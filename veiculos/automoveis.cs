using static System.Console;
namespace Veiculos
{
    class Veiculo
    {
        public int codId { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public decimal preco { get; set; }

        public Veiculo()
        {

        }
        public Veiculo(int CodId, string Marca, string Modelo, decimal Preco)
        {
            if (Preco < 5000)
            {
                throw new Exception("Preço do produto não pode conter esse valor");
            }
            codId = CodId;
            marca = Marca;
            modelo = Modelo;
            preco = Preco;
        }
        public void ConsultarMoto()
        {
            List<Moto> motos = new List<Moto>
        {
            Moto.moto1, Moto.moto2, Moto.moto3
        };

            foreach (var moto in motos)
            {
                WriteLine("");
                WriteLine($"{moto.codId} - Marca: {moto.marca} | Modelo: {moto.modelo} | Valor: R$ {moto.preco}");
            }

        }
        public void ConsultarCarro()
        {
            List<Carro> carros = new List<Carro>
        {
            Carro.carro1, Carro.carro2, Carro.carro3
        };

            foreach (var carro in carros)
            {
                WriteLine("");
                WriteLine($"{carro.codId} - Marca: {carro.marca} | Modelo: {carro.modelo} | Valor: R$ {carro.preco}");
            }

        }

    }
}