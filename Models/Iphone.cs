namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp == "telegram")
            {
                try
                    {   
                        Console.WriteLine($"Instalando aplicativo nome errado {nomeApp}");
                    } 
                catch (Exception ex)
                    {
                        Console.WriteLine($"Problemas na instalação{ex.Message}");
                    }
            }
                
            else
            {
                throw new Exception("Erro na instalação");
            }
        }
    }
}