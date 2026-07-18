from abc import ABC, abstractmethod

class Poligono (ABC):
    def __init__(self, Lados):
        self.lados = Lados

    @abstractmethod
    def perimetro(self):
        pass

    @abstractmethod
    def area(self):
        pass

class Quadrado(Poligono):
    def __init__(self, LadoComprimento = 1):
        super().__init__(4)
        self.lados = LadoComprimento

    def perimetro(self):
        return self.lados * 4
    
    def area(self):
        return self.lados ** 2