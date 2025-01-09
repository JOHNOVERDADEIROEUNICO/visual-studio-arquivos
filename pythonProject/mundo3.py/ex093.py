jogador = dict()
lista = list()
tot = 0

jogador['nome'] = str(input('Nome do jogador: '))

nfor = int(input(f'Quantas partidas {jogador['nome']} jogou? ')) 

for c in range(0,nfor):
    gol = int(input(f'Quantos gols froam marcados na partida {c+1}: '))
    lista.append(gol)

jogador['gols'] = lista[:]
jogador['total'] = sum(lista)

print('-='*40)

print(jogador)

print('-='*40)

for k,v in jogador.items():
    print(f'O campo {k} tem o valor {v}')

print('-='*40)

print(f'O jogador {jogador['nome']} jogou {nfor} partidas')

for c in range(nfor):
    print(f'Na partida {c+1}, fez {jogador['gols'][c]} gols.')

print(f'Foi um total de {tot} gol(s).')