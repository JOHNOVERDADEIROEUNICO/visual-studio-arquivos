#Declaração de classes
class Gafanhoto:
    def __init__(self): #método construtor
        self.nome = ""
        self.idade = 0
        
#métodos

    def anversario(self):
        self.idade = self.idade + 1

    def mensagem(self):
        return f"{self.nome} é gafanhoto(a) e tem {self.idade} anos de idade."
    
#declaraçao de objetos
g1 = Gafanhoto()

g1.nome = "John"
g1.idade = 21

print(g1.mensagem())
g1.anversario()
print(g1.mensagem())