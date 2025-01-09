#variaveis
resp = 's'
acumulator = somador = 0
#enquanto/while
while resp in 'Ss':
    n1 = int(input('Digite um número: '))
    acumulator += 1
    
    if acumulator == 1:
        menor = n1
        maior = n1
    elif n1 < menor:
        menor = n1
    elif n1 > maior:
        maior = n1

    somador += n1
    resp = str(input('Quer continuar [s/n]? ')).upper().strip()[0]
#resposta
media = somador / acumulator
print(f'Você digitou {acumulator} números e a média foi {media}\nO maior valor digitado foi {maior} e o menor foi {menor}')
#ACABOU.
