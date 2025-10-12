class Usuario
{
    public string Nome { get; set; }
}

class SistemaLogin
{
    // Lista estática: existe apenas uma cópia para todos os objetos
    public static List<Usuario> UsuariosCadastrados = new List<Usuario>(); // uma lista statica permanecerá a mesma mesmo que se tenha dois objetos difrentes da mesma classe acessando ela ou outra classe acessando ela.
}

class Cadastro
{
    public void AdicionarUsuario(string nome)
    {
        SistemaLogin.UsuariosCadastrados.Add(new Usuario { Nome = nome });
    }
}

class Consulta
{
    public void MostrarUsuarios()
    {
        foreach (var usuario in SistemaLogin.UsuariosCadastrados)
        {
            Console.WriteLine(usuario.Nome);
        }
    }
}

//VEJA AGORA UM EXEMPLO DELA NA VERSÃO PRIVADA DANDO MAIS SEGURANÇA AO CÓDIGO:
class Usuario
{
    public string Nome { get; set; }
}

class SistemaLogin
{
    // Lista privada, só acessada por métodos da própria classe
    private static List<Usuario> usuarios = new List<Usuario>();

    // Método para adicionar usuário
    public static void AdicionarUsuario(string nome)
    {
        if (!string.IsNullOrWhiteSpace(nome))
        {
            usuarios.Add(new Usuario { Nome = nome });
        }
    }

    // Método para listar os usuários
    public static List<Usuario> ListarUsuarios()
    {
        // Retorna uma cópia para proteger a lista original
        return new List<Usuario>(usuarios);
    }
}
//USO:
SistemaLogin.AdicionarUsuario("Maria");
SistemaLogin.AdicionarUsuario("João");

foreach (var u in SistemaLogin.ListarUsuarios())
{
    Console.WriteLine(u.Nome);
}

//USANDO O PADRÃO SINGLETON:
class Usuario
{
    public string Nome { get; set; }
}

class SistemaLogin
{
    // Instância única (singleton)
    private static readonly SistemaLogin _instancia = new SistemaLogin();

    // Lista privada
    private List<Usuario> usuarios = new List<Usuario>();

    // Construtor privado (impede criação externa)
    private SistemaLogin() {}

    // Propriedade de acesso à instância única
    public static SistemaLogin Instancia => _instancia;

    public void Adicionar(string nome)
    {
        usuarios.Add(new Usuario { Nome = nome });
    }

    public List<Usuario> Listar()
    {
        return new List<Usuario>(usuarios);
    }
}
//USO:
SistemaLogin.Instancia.Adicionar("Carlos");
SistemaLogin.Instancia.Adicionar("Ana");

foreach (var u in SistemaLogin.Instancia.Listar())
{
    Console.WriteLine(u.Nome);
}

