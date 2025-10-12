// classe original para mostrar como uma classe isolada funciona.
class Mamifero
{
        //atributos
        private string sexo;
        public string nome;
        public string cor;
        public float altura;
        public float peso;
        private bool monotremado = false;
        private bool marsupial = false;
        private bool placentario = false;

        //construtor e metodos
        public Mamifero(string sexoP, string nomeP, string corP, float alturaP, float pesoP)
        {
            sexo = sexoP;
            nome = nomeP;
            cor = corP;
            altura = alturaP;
            peso = pesoP;

            Console.WriteLine("Qual a classe do mamífero?");
            string classe = Console.ReadLine();

            if(classe == "monotremado")
            {
                monotremado = true;
            }
            else if(classe == "marsupial")
            {
                marsupial = true;
            }
            else if(classe == "placentario")
            {
                placentario = true;
            }
        }
        public string emitirSom()
        {
            return $"O(A) {nome} emitiu um som desconhecido";
        }
        public string moder()
        {
            return $"O(A) {nome} mordeu e arrancou pedaço!";
        }
        public string estaGravida()
        {
            if(sexo == "femea")
            {
                if(monotremado == true)
                {
                    return $"A {nome} botou um ovo";
                }
                else if(marsupial == true)
                {
                    return $"O filhote de {nome} nasceu e está na bolsa da mãe";
                }
                else if(placentario == true)
                {
                    return $"A {nome} está gravida de um filhotinho.";
                }
                else
                {
                    return $"A {nome} é fêmea, mas não foi possível determinar a forma de reprodução.";
                }
            }
            else{
                return "Macho não engravida";
            }
        }
        public string Sexo{
            get{
                return sexo;
            }
            set{
                sexo = value;
            }
        }
        public bool Monotremado{
            get{
                return monotremado;
            }
            set{
                monotremado = value;
            }
        }
        public bool Marsupial{
            get{
                return marsupial;
            }
            set{
                marsupial = value;
            }
        }
        public bool Placentario{
            get{
                return placentario;
            }
            set{
                placentario = value;
            }
        }
}