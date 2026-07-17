class Pessoa:
    def __init__(self, Nome = "None", Idade = 0):
        self.nome = Nome 
        self.idade =  Idade

    def fazerAniversario(self):
        self.idade += 1

    def CPF(self):
        return print(f"Nome: {self.nome}, idade: {self.idade}")

    
class Aluno(Pessoa): #herança!
    def __init__(self, Nome="None", Idade=0):
        super().__init__(Nome, Idade)
        self.passarDeAno = False
        self.cReprovado = 0
        self.passa = 1

    def CPF(self):
        super().CPF()
        if(self.idade == 3):
            print(f"{self.nome} está no seu primeiro ano de estudos!")
        elif(self.idade > 3):
            if(self.passarDeAno == True):
                print(f"O aluno {self.nome} passou para seu {self.passa}º Ano")
            else:
                print(f"O aluno {self.nome} reprovou e continua no {self.passa}º Ano")

    def passouAno(self):
        self.fazerAniversario()
        self.passarDeAno = True
        self.passa += 1
        return print(f"O aluno {self.nome} passou de ano? {self.passarDeAno}, e completou {self.idade} ano(s)")

    def reprobouAno(self):
        self.fazerAniversario()
        self.passarDeAno = False
        self.cReprovado += 1 
        return print(f"O aluno {self.nome} passou de ano? {self.passarDeAno}, e completou {self.idade} ano(s)")



