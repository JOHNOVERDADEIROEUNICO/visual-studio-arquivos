class Cachorro : Mamifero2
{
    public Cachorro(string sexoP, string corP, float alturaP, float pesoP) : base(sexoP, "cachorro", corP, alturaP, pesoP){}

    public override string emitirSom()
    {
        return $"O(A) {base.nome} latiu!";
    }
    public override string moder()
    {
        return $"O(A) {base.nome} mordeu e rancou pedaço!";
    }
}