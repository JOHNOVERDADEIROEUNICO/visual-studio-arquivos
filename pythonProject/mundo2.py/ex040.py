#variaveis
n1 = float(input('Primeira Nota: '))
n2 = float(input('Segunda nota: '))
#calculo
m = (n1+n2)/2
#print
print('O aluno tirou {:.1f} isso significa que: '.format(m))
#resposta/condicionais
if m < 6.0:
    print('O aluno está de recuperção')
elif m >= 6.0 and m < 7.5:
    print('O aluno ficou na média e está APROVADO!')
else:
    print('Aluno tirou uma excelente nota e está APROVADO!')
#ACABOU.