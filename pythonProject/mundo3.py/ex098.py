def lin():
    print('-='*40)

def contador(com,term,pas):
    
    if term > 0:
        print(f'Contagem de {com} ate {term} de {pas} em {pas}')
        for valor in range (com,term +1,pas):
            print(f'{valor} ', end='')
    else:
        print(f'Contagem de {com} ate {term} de {pas*-1} em {pas*-1}')
        for valor in range (com,term -1,pas):
            print(f'{valor} ', end='')
    print('FIM!')

n1 = 1
n2 = 10
n3 = 1

lin()
contador(com= n1, term= n2, pas= n3)
lin()

n1 = 10
n2 = 0
n3 = -2

contador(com= n1, term= n2, pas= n3)
lin()

print('Agora é sua vez de personalizar a contagem!')

n1 = int(input('Início: '))
n2 = int(input('Fim: '))
n3 = int(input('Passo: '))

lin()
contador(com= n1, term= n2, pas= n3)