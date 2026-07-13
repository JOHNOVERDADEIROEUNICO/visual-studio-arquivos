#Declaração de classes
class Gafanhoto:
    """Teste
    
    teste de documentação

    veja que usando o nome da classe + .__doc__ temos a documentação da classe sendo exibida. se passar o mouse por cima do nome da classe a documentação também será exibida.
    """


    def __init__(self, n = "", i = 0): #método construtor
        self.nome = n
        self.idade = i
        
#métodos

    def anversario(self):
        self.idade = self.idade + 1

    def mensagem(self):
        return f"{self.nome} é gafanhoto(a) e tem {self.idade} anos de idade."
    
#declaraçao de objetos
g1 = Gafanhoto("John", 21)

print(g1.mensagem())
g1.anversario()
print(g1.mensagem())

print(Gafanhoto.__doc__) #dunder atribute 