rece = dict()
guard = list()
guardm= list()
s = 0

while True:
    rece['nome'] = str(input('Nome: '))
    rece['idade'] = int(input('Idade: '))
    rece['sexo'] = str(input('Sexo: '))

    if rece['sexo'] != 'm' and rece['sexo'] != 'f':
        while True:
            print('Erro digite somente [m/f]')
            rece['sexo'] = str(input('sexo [m/f]? ')).lower()
            if rece['sexo'] == 'm':
                break
            elif rece['sexo'] == 'f':
                break
            
    if rece['sexo'] == 'f':
        guardm.append(rece.copy())

    guard.append(rece.copy())
    rece.clear()

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

for i,c in enumerate(guard):
    s += guard[i]['idade']

media = s/len(guard)

print('-='*40)

print(f'A) Ao todo temos {len(guard)} cadastradas.')
print(f'B) A média de idade é de {media} anos.')
print(f'C) As mulheres cadastradas foram ', end=' ')

for i,c in enumerate(guardm):
    print(guardm[i]['nome'], end=' ')

print(f'\nD) Lista das pessoas que estão acima da média: ')

for i,c in enumerate(guard):
    if guard[i]['idade'] > media:
        print(f'Nome = {guard[i]['nome']}; Sexo = {guard[i]['sexo']}; Idade = {guard[i]['idade']}')