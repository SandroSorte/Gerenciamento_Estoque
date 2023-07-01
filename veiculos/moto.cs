using System;
namespace Veiculos
{
    class Moto : Veiculo
    {
        public Moto(int CodId, string Marca, string Modelo, decimal Preco) : base(CodId, Marca, Modelo, Preco)
        {

        }
        public static Moto moto1 = new(100, "Hyunday", "CG 160 Start", 13280);
        public static Moto moto2 = new(101,"Hyunday", "CG 160 fan", 14570 );
        public static Moto moto3 = new(102, "Honda", "Pop 1101", 9010 );
    }
}