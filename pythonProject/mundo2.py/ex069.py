acumuladorf = acumuladorm = acumuladori = 0

while True:
    print('-'*40)
    print('CADASTRE UMA PESSOA')
    print('-'*40)
    i = int(input('Idade: '))
    s = ' '
    while s not in 'mf':
        s = str(input('Sexo [m/f]: ')).strip().lower()[0]
    print('-'*40)

    if i >= 18:
        acumuladori += 1
    
    if s == 'm':
        acumuladorm += 1
    
    if s == 'f' and i < 20:
        acumuladorf += 1

    resp = ' '
    while resp not in 'sn':
        resp = str(input('Quer continuar [s/n]? ')).strip().lower()[0]
    if resp == 'n':
        break
    
print(f'Total de pessoas com mais de 18 anos: {acumuladori}')
print(f'Total de Homens cadastrados: {acumuladorm}')
print(f'Total de Mulheres com menos de 20 anos: {acumuladorf}')