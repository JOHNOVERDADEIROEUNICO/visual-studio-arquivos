from time import sleep

n1 = ('zero','um','dois','três','quatro','cinco','seis','sete','oito',
      'nove','dez','onze','doze','treze','quatorze','quinze','dezesseis','dezessete','dezoito','dezenove','vinte')

while True:
    n2 = int(input('Digite um número entre 0 e 20: '))
    if 0 <= n2 <= 20:
        break
    print('Tente novamente. ', end='')
print(f'Você digitou o número {n1[n2]}')
