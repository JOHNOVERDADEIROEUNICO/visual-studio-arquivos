public interface ICarro
{
    int velocidade{ get; set; }
    bool ligado{ get; set; }
    
    void velocimetro();
    bool ligar();
    bool desligar();
    int acelerar(int vAcrescentado);
    int frear(int vDecrementado);

}