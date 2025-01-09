def who(nome,gols):
    if nome == '' and gols == '':
        return f'O jogador <Desconhecido> fez 0 gol(s) no campeonato.'
    elif nome == '':
        return f'O jogador <Desconhecido> fez {gols} gol(S) no campeonato.'
    elif gols == '':
        return f'O jogador {nome} fez 0 gol(S) no campeonato.'
    else:
        return f'O jogador {nome} fez {gols} gol(S) no campeonato.'

goal = 0    
name = str(input('Nome do Jogador: '))
goal = str(input('Número de Gol(s): '))

print(who(name,goal))