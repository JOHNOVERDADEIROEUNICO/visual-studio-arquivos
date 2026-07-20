from abc import ABC, abstractmethod
import math

class Poligono (ABC):
    def __init__(self, Lados):
        self.lados = Lados

    @abstractmethod
    def perimetro(self) -> float:
        pass

    @abstractmethod
    def area(self) -> float:
        pass

class Quadrado(Poligono):
    def __init__(self, LadoComprimento = 1):
        super().__init__(4)
        self.lados = LadoComprimento

    def perimetro(self):
        return self.lados * 4
    
    def area(self):
        return self.lados ** 2
    
class Circulo(Poligono):
    def __init__(self, Raio = 1):
        super().__init__(0)
        self.raio = Raio

    def perimetro(self):
        return 2 * math.pi * self.raio

    def area(self):
        return math.pi * (self.raio ** 2)