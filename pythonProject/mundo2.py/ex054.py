#impotacao
from datetime import date
#variaveis
aatual = date.today().year
cont1 = 0
cont2 = 0
#for/para
for i in range(1,8):
    ano = int(input('Em que ano a {}ª pessoa nasceu? '.format(i)))
    if aatual - ano >= 18:
        cont1 += 1
    else:
        cont2 += 1
#resposta
print('Ao todo tivemos {} pessoas maiores de idade.'.format(cont1))
print('E também tivemos {} pessoas menores de idade.'.format(cont2))
#ACABOU.