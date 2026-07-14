class Preco:
    """Crie uma classe que exiba o nome e o preço do produto, além da sua etiqueta de preço.
    """

    def __init__(self, Nome= "", Preco= 0):
        self. nome = Nome 
        self.preco = Preco

    def etiqueta(self):
        return f"Produto: {self.nome} | Preço: R${self.preco:.2f}"

    
p1 = Preco("Iphone 17", 15000)

print(p1.etiqueta())