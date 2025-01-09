#variaveis
cadas = []
nomaipe = []
nomenpe = []
men = mai = cadastot = 0
#whiles/enquantos
while True:
    cadas.append(str(input('Nome: ')))
    cadas.append(float(input('Peso: ')))
    #condicoes/if/elif/else
    if cadas[1] >= mai:
        mai = cadas[1]

        if len(nomaipe) == 0:
            nomaipe.append(cadas[:])

        elif nomaipe[0][1] == mai:
            nomaipe.append(cadas[:])

        elif nomaipe[0][1] != mai:
            nomaipe.clear()
            
        if len(nomaipe) == 0:
            nomaipe.append(cadas[:])

    elif cadas[1] <= men:
        men = cadas[1]

        if len(nomenpe) == 0:
            nomenpe.append(cadas[:])

        elif nomenpe[0][1] == men:
            nomenpe.append(cadas[:])

        elif nomenpe[0][1] != men:
            nomenpe.clear()

        if len(nomenpe) == 0:
            nomenpe.append(cadas[:])

    if men == 0 or men == mai:
        men = cadas[1]
        nomenpe.append(cadas[:])

    cadastot += 1
    cadas.clear()
    resp = str(input('Quer continuar? '))
    if resp != 's':
        break

pos =0
while pos < len(nomaipe):
    del nomaipe[pos][1::2]
    pos+=1   
pos =0
while pos < len(nomenpe):
    del nomenpe[pos][1::2]
    pos+=1  

print('-='*40)
print(f'Ao todo você cadastrou {cadastot} pessoas.')
print(f'O maior peso foi de {mai}. Peso de {nomaipe}')
print(f'O menor peso foi de {men}. Peso de {nomenpe}')