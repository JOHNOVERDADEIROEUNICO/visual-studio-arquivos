#import
import random
#inicio
print('{:=^42}'.format(' PEDRA PAPEL TESOURA '))
print('{:=^42}'.format(' HAHAHA TENTE ME VENCER! '))
print('Escolha:')
print('[0] Pedra')
print('[1] Papel')
print('[2] Tesoura')
j1 = int(input('Qual a sua jogada? '))
num = random.randint(0,2)
#condicionais/resposta
if j1 == 0 and num == 0:
    print('empatamos! eu joguei Pedra e você tambêm!')

elif j1 == 1 and num == 1:
    print('empatamos! eu joguei Papel e você tambêm!')

elif j1 == 2 and num == 2:
    print('empatamos! eu joguei Tesoura e você tambêm!')

elif j1 == 0 and num == 2:
    print('Parabéns você me venceu jogando Pedra na Tesoura!')

elif j1 == 2 and num == 0:
    print('Perdeu HAHAHA! joguei Pedra em sua Tesoura.')

elif j1 == 1 and num == 0:
    print('Parabéns você me venceu jogando Papel na Pedra!')

elif j1 == 0 and num == 1:
    print('Perdeu HAHAHA! joguei Papel em sua Pedra.')

elif j1 == 2 and num == 1:
    print('Parabéns você me venceu jogando Tesoura no Papel!')

else:
    print('Perdeu HAHAHA! joguei Tesoura no Papel!')
#ACABOU.