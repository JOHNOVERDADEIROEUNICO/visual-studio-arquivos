//copia da classe modificada para demonstar herança em c#
class Mamifero2
{
        //atributos
        private string sexo;
        public string nome;
        public string cor;
        public float altura;
        public float peso;
        //modificaçao no modificador de acesso, para poder usálas em classes filhas, lembrando que private bloqueia o acesso a qualquer modificação externa, o protected permite somente classes filhas modificar o atributo ou metodo e etc...
        protected bool monotremado = false;
        protected bool marsupial = false;
        protected bool placentario = false;

        //construtor e metodos
        public Mamifero2(string sexoP, string nomeP, string corP, float alturaP, float pesoP)
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
        public virtual string emitirSom()
        {
            return $"O(A) {nome} emitiu um som desconhecido";
        }
        public virtual string moder()
        {
            return $"O(A) {nome} mordeu e arrancou pedaço!";
        }
        public virtual string estaGravida()
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