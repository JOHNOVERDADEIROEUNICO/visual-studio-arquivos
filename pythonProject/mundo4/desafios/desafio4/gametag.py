class Gametag:
    """Crie uma classe que apresente uma lista de jogos, nome e nickname de uma pessoa e uma gametag que a apresente.
    """

    def __init__(self, Nome = "Noob", Nickname = "Guest"):
        self.nome = Nome
        self.nickname = Nickname
        self.meusJogos = []
        
    def listaDeJogos(self):
        contador = 0
        while contador < 3:
            Jogo = ""
            if contador == 0:
                Jogo = input("Quais são os 3 melhores jogos da sua vida? ")
            else:
                Jogo = input("Informe novamente: ")

            self.meusJogos.append(Jogo)

            contador += 1
            
    def gametag(self):
        return print(f"Nome: {self.nome};\nUsuario: {self.nickname};\nMeus jogos: {self.meusJogos[0]}, {self.meusJogos[1]}, {self.meusJogos[2]};")
    

g1 = Gametag("John", "Manifoldabyss")

g1.listaDeJogos()
g1.gametag()