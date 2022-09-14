namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //Implementando a herança
    public class Nokia : Smartphone
    {
        private String app;
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
    
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)      
        {
            try
            {   
                Console.WriteLine($"Instalando aplicativo {nomeApp}");
            } 
            catch (Exception ex)
            {
                
                throw new Exception($"Erro na instalação{ex}");
            } 
            finally{
                Console.WriteLine($"Aplicativo Instalado {nomeApp}");
            }
        }
    }
}