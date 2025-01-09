#importacoes
from time import sleep
#inicio
print('===========================')
print('    10 TERMOS DE UMA PA    ')
print('===========================')
#variaveis/inputs
termo = 10
total = termo
c = 0
t1 = int(input('Primeiro Termo: '))
r = int(input('Razão: '))
resp = 's'
#while/enquanto/resposta
while resp != 'n':
    while c < termo:
        print(end=f'{t1} -> ')
        t1 += r
        c += 1
    print('PAUSA')
    resp = str(input('Quer continuar [s/n]? '))
    if resp == 's':
        termo = int(input('Mais quantos termos deseja mostrar? '))
        c = 0
        total += termo
        print('CONTINUANDO...')
        sleep(3)
#encerrando
print('ENCERRANDO...')
sleep(3)
print(f'O total de termos foi {total}')
#ACABOU.