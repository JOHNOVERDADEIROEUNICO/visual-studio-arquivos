#importacoes
from time import sleep
import random
#inicio
print('Sou seu computador...')
num = random.randint(0,10)
#utilizando o import sleep
sleep(3)
#metade/variaveis e prints
print('Acabei de pensar em número de 0 a 10')
print('Consegue adivinhar qual foi? ')
pal = int(input('Qual o seu palpite? '))
tent = 1
#while/enquanto
while pal != num:
    #condicoes
    if pal < num:
        print('Mais... Tente mais uma vez.')
    else:
        print('Menos... Tente mais uma vez')
    #variaveis dentro do while
    pal = int(input('Qual o seu palpite? '))
    tent += +1
#condicoes/resposta
if tent == 1:
    print('Parabéns! Acertou De Primeira!')
else:
    print('Acertou Com {} Tentativas. Parabéns!'.format(tent))