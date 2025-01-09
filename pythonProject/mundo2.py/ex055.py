
m = 0
n: str
l = 0
pem: str
p = 0
pel: str

def tela_inicial():
    print('--------------------------------------------')
    print(' Quem é o mais pesado? e quem é o mais leve? ')
    print('--------------------------------------------')

tela_inicial()

for i in range(0,5):
    n = str(input('Digite um nome: '))
    p = float(input('Digite o peso de {}: '.format(n)))
    if i == 0:
        m = p
        l = p
    else:
        if p > m:
            m = p
            pem = n
        if p < l:
            l = p
            pel = n
    tela_inicial()
print('O maior peso foi de {} com {}kg'.format(pem,m))
print('O menor peso foi de {} com {}kg'.format(pel,l))

