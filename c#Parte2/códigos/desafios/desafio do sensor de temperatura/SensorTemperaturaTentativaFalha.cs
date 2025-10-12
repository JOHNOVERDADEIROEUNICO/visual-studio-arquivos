using System;

public delegate void AlertaDeTemp1();

class SensorTemperatura1
{
    public event AlertaDeTemp1 Alerta1;
    private double TempAtual;

    public double AtualizarTemp(double novaTemp)
    {
        TempAtual = novaTemp;
        Console.WriteLine($"Temperatura atualizada para: {TempAtual}°C");
        return TempAtual;
    }

    public void AlertaDeTemperatura()
    {
        //A FALAHA SE ENCONTRA AQUI, USAR UM OBJETO PARA FAZER O DELEGADO RECEBER O MÉTODO FARÁ COM QUE ELE CONSIDERE OS DADOS DAQUELE OBJETO, ASSIM IGNORANDO OS DADOS DO OBJETO DO PROGAMA PRINCIPAL, OU SEJA O DELEGADO PRECISA SER USADO NO PROGAMA PRINCIPAL.
        SensorTemperatura1 sen = new SensorTemperatura1();
        Alerta4 aler = new Alerta4();

        if(TempAtual > 40.0 || TempAtual < 5.0)
        {
            sen.Alerta1 += aler.TemperaturaCritica;
            Console.WriteLine(sen.Alerta1);// ISSO AQUI SÓ VAI EXIBIR O NOME DO DELEGADO, TAMBÉM NÃO É FUNCIONAL.
            
        }
    }
}

class Alerta4 : SensorTemperatura1
{
    string DataDeAgora = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");

    public void TemperaturaCritica()
    {
        Console.WriteLine($"ALERTA: Temperatura crítica detectada: {TempAtual}°C às {DataDeAgora}");
    }
}