namespace Aula_05.Heranca
{
    public class Bike : Veiculo
    {
        public int velocidadeMaximaEmKmH;
        public string fabricante;

        public string ExibirMarca()
        {
            return $"O fabricante deste veículo é: {fabricante}";
        }
    }
}