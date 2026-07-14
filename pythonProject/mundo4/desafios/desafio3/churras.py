class Churras:
    """Crie uma classe que calcula o preço médio de um churrascos considerando número de pessoas e preço da carne
    """

    def __init__(self, Pessoas = 1, Preco = 82.50, Consumo = 0.4):
        self.nPessoas = Pessoas
        self.preco = Preco
        self.consumo = Consumo

    def analisar(self):
        self.totalConsumo = self.nPessoas * self.consumo
        
        self.precoTotal = (self.preco * self.consumo) * self.nPessoas
            
        return print(f"Um churrasco para {self.nPessoas}, considerando um consumo médio de {self.consumo} por pessoa e um preço médio por kg de {self.preco:.2f}...\nSerá necessário {self.totalConsumo}kg de carne;\nE o total a pagar será de {self.precoTotal:.2f}.")
        

    

c1 = Churras(15, 82.40, 0.4)

c1.analisar()