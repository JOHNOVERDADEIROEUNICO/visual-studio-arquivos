//DESAFIO CRIAR UM SISTEMA DE MONITORAMENTO DE TEMPERATURA USANDO PROGAMAÇÃO ORIENTADA A EVENTOS:
//OBS: ESTA É APENAS UMA SIMULAÇÃO DE MONITORAMENTO, PODEMOS FAZER UM SISTEMA QUE SIMULA UM SENSOR POSTERIORMENTE E JUNTAR OS DOIS.
class Program
{
    static void Main()
    {
        //AGORA FINALMENTE O MÉTODO SERÁ ADICIONADO AO DELEGADO, PERCEBA QUE ISSO ACONTECE COMO O PARAMETRO DO TIPO DELEGADO QUE CRIAMOS.
        SensorTemperatura sensor = new SensorTemperatura();
        Alerta alerta = new Alerta();

        sensor.Alerta1 += alerta.TemperaturaCritica;

        sensor.AtualizarTemp(3.0);
        
    }
}