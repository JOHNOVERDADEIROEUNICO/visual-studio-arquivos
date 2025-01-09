
n: str
s: str
i: float
mi =0
acumulador = 0
acumuladorf = 0

for i in range (1,5):
    print('----- {}º PESSOA -----'.format(i))
    n = str(input('Nome: '))
    i = int(input('Idade: '))
    s = str(input('Sexo [m/f]: '))
    acumulador += i
    if i > mi and s == 'm':
        mi = i
        mn = n
    if s == 'f' and i < 20:
        acumuladorf += 1
    
m = acumulador/4

print('A média de idade do grupo é de {:.1f} anos.'.format(m))
print('O homem mais velho tem {} anos e se chama {}.'.format(mi,mn))
print('Ao todo são {} mulhere(s) com menos de 20 anos.'.format(acumuladorf))
