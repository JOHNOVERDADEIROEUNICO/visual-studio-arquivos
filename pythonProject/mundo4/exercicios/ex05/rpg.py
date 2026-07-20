from abc import ABC, abstractmethod
import random

class Personagem(ABC):
    def __init__(self, Nome, Vida):
        self.nome = Nome
        self.vida = Vida
        self.golpes = []

    def atacar(self, Alvo, Força = 500):
        if self.vida == 0 or Alvo.vida == 0:
            print(f"O golpe não pode acontecer.")
        else:
            golpe = self.golpes[random.randrange(0, len(self.golpes))]

            print(f"{self.nome} atacou {Alvo.nome} com {golpe} de {Força} de força!")
            Alvo.receberDano(Força)


    def receberDano(self, Dano):
        fator = random.randint(0, Dano)
        if self.vida <= fator:
            self.vida = 0
            print(f"{self.nome} Morreu.")
        else:
            self.vida -= fator

        print(f"{self.nome} recebeu {fator} de dano e agora está com {self.vida}hp.")

    @abstractmethod
    def curar(self):
        pass

class Guerreiro(Personagem):
    def __init__(self, Nome, Vida):
        super().__init__(Nome, Vida)
        self.golpes = ["Soco arcano", "Golpe com excalibur", "tiro de flecha"]

    def curar(self):
        fator = random.randint(0, 100)
        if self.vida > 0:
            self.vida += fator

            print(f"{self.nome} curou {fator} de hp e agora está com {self.vida}hp.")
        else:
            print(f"{self.nome} já está morto.")

class Mago(Personagem):
    def __init__(self, Nome, Vida):
        super().__init__(Nome, Vida)
        self.golpes = ["Disparo arcano", "Bola de fogo", "Tempestade de raios"]

    def curar(self):
        fator = random.randint(0, 300)
        if self.vida > 0:
            self.vida += fator

            print(f"{self.nome} curou {fator} de hp e agora está com {self.vida}hp.")
        else:
            print(f"{self.nome} já está morto.")