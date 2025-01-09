teste = list()
teste.append('Gustavo')
teste.append(40)
galera = list()
galera.append(teste)
print(galera)
print('='*40)
#se quiser modificar sem alterar as duas ja sabe cria uma copia.

galera1 = [['João',19],['Ana',33],['Joaquim',13],['Maria',45]]
print(galera1)
print(galera1[0])
print(galera1[0][0])
print('='*40)
for p in galera1:
    print(f'{p[0]} tem {p[1]} anos de idade')
print('='*40)

galera2 = list()
dado = list()
totmai = totmen = 0
for c in range(0,3):
    dado.append(str(input('Nome: ')))
    dado.append(int(input('Idade: ')))
    galera2.append(dado[:])
    dado.clear()
print(galera2)

for p in galera2:
    if p[1] >= 18:
        print(f'{p[0]} é maior de idade.')
        totmai += 1
    else:
        print(f'{p[0]} é menor de idade.')
        totmen += 1 
print(f'Temos {totmai} maiores e {totmen} menores de idade.')


