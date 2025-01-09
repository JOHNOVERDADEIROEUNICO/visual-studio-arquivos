#importacoes
from time import sleep
#variaveis
ad = c50 = c20 = c10 = c5 = c1 = 0
#pergunta
print('-=-'*15)
print(' CAIXA ELETRONICO'.center(40))
print('-=-'*15)
valor = int(input('Qual valor deseja sacar? '))
#while/enquanto
while True:
    #condicoes
    if valor > 50 and ad <= valor - 50:
        ad += 50
        c50 += 1
    elif valor > 20 and ad <= valor - 20:
        ad += 20
        c20 += 1
    elif valor > 10 and ad <= valor - 10:
        ad += 10
        c10 += 1
    elif valor > 5 and ad <= valor - 5:
        ad += 5
        c5 += 1
    elif valor > 1 and ad <= valor:
        ad += 1
        c1 += 1
    else:
        break

    if ad == valor:
        break
    #importacao sleep
    sleep(3)
#condicoes/resposta
if c50 > 0:
    print(f'Total de {c50} cédulas de R$50')
if c20 > 0:
    print(f'Total de {c20} cédulas de R$20')
if c10 > 0:
    print(f'Total de {c10} cédulas de R$10')
if c5 > 0:
    print(f'Total de {c5} cédulas de R$5')
if c1 > 0:
    print(f'Total de {c1} moedas de R$1')
if valor == 0:
    print('Você não digitou nenhum valor.')
#importacao sleep
sleep(3)
#fim
print('-=-'*15)
print('Volte sempre ao Banco CEV! TENHA UM BOM DIA!')
#ACABOU.