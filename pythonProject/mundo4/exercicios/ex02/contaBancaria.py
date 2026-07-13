class ContaBancaria:
    """Criando uma contabancaria que permite saques e depositos
    """

    def __init__(self, ID, Titular, Saldo = 0):
        self.id = ID 
        self.titular = Titular 
        self.saldo = Saldo 

    def __str__(self):
        return f"O senhor(a) {self.titular}, id: {self.id} possuí: R${self.saldo:.2f}."
    
    def deposito(self, valor):
        self.saldo += valor

    def saque(self, valor):
        if(valor <= self.saldo):
            self.saldo -= valor
            f"Sacando: {valor}, tenha um bom dia."
        else:
            f"Saldo insuficiente."



c1 = ContaBancaria(112, "John", 1000)

print(c1)
c1.deposito(500)
print(c1)
c1.saque(1000)
print(c1)