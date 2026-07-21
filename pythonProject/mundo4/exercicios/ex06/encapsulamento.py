class ContaBancaria:
    """Criando uma contabancaria que permite saques e depositos
    """
    # Public: noome normal da variavel
    # Protected: _
    # Private: __
    
    def __init__(self, ID, Titular, Saldo = 0):
        self._id = ID 
        self._titular = Titular 
        self.__saldo = Saldo 
        print(f"Conta {self._id} de {self._titular} criada com sucesso. saldo atual de {self.__saldo:,.2f}")

    def __str__(self):
        return f"O senhor(a) {self._titular}, id: {self._id} possuí: R${self.__saldo:.2f}."
    
    def deposito(self, valor):
        if valor > 0:
            self.__saldo += valor
            return print(f"Deposito no valor de {valor} aprovado e depositado.")
        else:
            return print("Valor inválido.")

    def saque(self, valor):
        if valor <= self.__saldo and valor > 0:
            self.__saldo -= valor
            f"Sacando: {valor}, tenha um bom dia."
        else:
            f"Valor de saque inválido ou Saldo insuficiente."