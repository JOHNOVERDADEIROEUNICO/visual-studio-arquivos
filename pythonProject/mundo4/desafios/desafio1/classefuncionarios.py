class Funcionario:
    """Objetivo: criar uma classe de funcionario que indique nome, setor e cargo e permita o funcionário se apresentar.
    """

    def __init__(self, Nome = "", Setor = "", Cargo=""):
        self.nome = Nome
        self.setor = Setor
        self.cargo = Cargo

    def apresentacao(self):
        print(f"Olá meu nome é {self.nome}, trablho no setor de {self.setor} e o meu cargo é {self.cargo}")

    
f1 = Funcionario("John", "Vendas", "Gerente")

f1.apresentacao()


