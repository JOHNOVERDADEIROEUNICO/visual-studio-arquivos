jogador = dict()
time = list()
lista = list()
tot = 0

while True:
    jogador['nome'] = str(input('Nome do jogador: '))

    

    time.append(jogador.copy())
    jogador.clear()

    resp = str(input('Quer continuar [s/n]? ')).lower()
    if resp != 's' and resp != 'n':
        while True:
            print('Erro digite somente [s/n]')
            resp = str(input('Quer continuar [s/n]? ')).lower()
            if resp == 'n':
                break
            elif resp == 's':
                break
    if resp == 'n':
        break

print('-='*40)

for c in time:
    for k,v in jogador.items():
        print(f'O campo {k} tem o valor {v}')

print('-='*40)
print(jogador)