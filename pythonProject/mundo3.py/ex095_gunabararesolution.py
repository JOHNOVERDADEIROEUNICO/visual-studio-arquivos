jogador = dict()
lista = list()
time = list()
tot = 0

while True:
    jogador.clear()
    jogador['nome'] = str(input('Nome do jogador: '))

    nfor = int(input(f'Quantas partidas {jogador['nome']} jogou? ')) 
    lista.clear()
    for c in range(0,nfor):
        gol = int(input(f'Quantos gols froam marcados na partida {c+1}: '))
        lista.append(gol)

    jogador['gols'] = lista[:]
    jogador['total'] = sum(lista)
    time.append(jogador.copy())

    resp = str(input('Quer continuar [s/n]? ')).lower()[0]
    if resp != 's' and resp != 'n':
        while True:
            print('Erro digite somente [s/n]')
            resp = str(input('Quer continuar [s/n]? ')).lower()[0]
            if resp == 'n':
                break
            elif resp == 's':
                break
    if resp == 'n':
        break

print('-='*40)

print('cod ', end='')
for i in jogador.keys():
    print(f'{i:<15}', end='')
print()

for k,v in enumerate(time):
    print(f'{k:>3}', end='')
    for d in v.values():
        print(f'{str(d):<15}', end='')
    print()

while True:
    busca = int(input('Mostrar dados de qual jogador (999 interrompe)? '))

    if busca == 999:
        break

    if 0 > busca >= len(time):
        print(f'Não existe jogador com código {busca}!')
    else:

        print(f'  -- levantamento do jogador {time[busca]['nome']}: ')

        for i, g in enumerate(time[busca]['gols']):
            print(f'    No jogo {i+1} fez {g} gols.')
            
    print('-'*40)
print('FINALIZANDO...')