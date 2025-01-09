D: int
km: int
td: int
tkm: float

D = int(input("Quantos dias o carro permaneceu alugado? "))
km = int(input("Quantos km foram rodados? "))
td = 60*D
tkm = 0.15*km
print("O total a se pagar é de R${:.2f}".format(td+tkm))