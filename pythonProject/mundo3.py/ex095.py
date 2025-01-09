jogador = dict()
time = list()
lista = list()
tot = 0

while True:
    jogador['nome'] = str(input('Nome do jogador: '))

    nfor = int(input(f'Quantas partidas {jogador['nome']} jogou? ')) 

    for c in range(0,nfor):
        gol = int(input(f'Quantos gols froam marcados na partida {c+1}: '))
        lista.append(gol)

    jogador['gols'] = lista[:]
    jogador['total'] = sum(lista)

    time.append(jogador.copy())
    lista.clear()
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

print('No. NOME','gols','total'.rjust(10))

print('-'*25)

pos = 0
while pos < len(time):
    print(f'{pos}',f'{time[pos]['nome']}'.rjust(6),f'{time[pos]['gols']}'.rjust(3),f'{time[pos]['total']}' .rjust(4))
    pos += 1

print('-'*30)

pos = 0
i = 0
while pos != 999:
    pos = int(input('Mostrar stats de qual jogador (999 interrompe)? '))

    if pos > len(time)-1 and pos != 999:
        while True:
            print(f'Não existe um jogador com o código {pos}')
            pos = int(input('Digite uma posição válida: '))
            if pos <= len(time)-1:
                break
    if pos != 999:
        print(f'  -- LEVANTAMENTO DO JOGADOR {time[pos]['nome']}')
        while i < len(time[pos]['gols']):
            print(f'No jogo {i+1} fez {time[pos]['gols'][i]} gol(s).')
            i += 1
        i = 0
print('-='*40)

print('FINALIZANDO...')