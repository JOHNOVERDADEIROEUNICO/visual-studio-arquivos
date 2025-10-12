using System;

public delegate void AlertaDeTemp();

class SensorTemperatura
{
    public event AlertaDeTemp Alerta1;
    public double TempAtual;

    //JÁ NESSA VERSÃO PERCEBA QUE USAMOS O INVOKE QUE INVOCA O MÉTODO ADICIONADO NO DELEGADO, PORÉM SÓ IREMOS ADICIONAR O MÉTODO NO PROGAMA PRINCIPAL, POÍS O OBJETO SE ENCONTRA JUSTAMENTE NO PROGAMA PRINCIPAL.
    public double AtualizarTemp(double novaTemp)
    {
        TempAtual = novaTemp;
        Console.WriteLine($"Temperatura atualizada para: {TempAtual}°C");

        AlertaDeTemperatura();

        return TempAtual;
    }

    private void AlertaDeTemperatura()
    {
        if(TempAtual > 40.0 || TempAtual < 5.0)
        {
            Alerta1?.Invoke();
            Console.WriteLine($"Temperatura detectada: {TempAtual}°C");
        }
    }
}

class Alerta
{
    string DataDeAgora = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");

    public void TemperaturaCritica()
    {
        Console.WriteLine($"ALERTA: Temperatura crítica detectada no dia {DataDeAgora}");
    }
}