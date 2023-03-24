namespace Aula_05.Heranca
{
    public class Carro : Veiculo
    {
        public bool cintoSegurança;
        public bool arCondicionado;
        public string marcaRadio;
        public string fabricante;

        public string ExibirMarca()
        {
            return $"O fabricante deste veículo é: {fabricante}";
        }
    }
}