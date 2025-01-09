#variaveis iniciais
ano =  int(input('Em que ano voce nasceu? '))
atual = 2024
dife = atual - ano
#ifs, elses/resposta 
if dife == 18:
    print('Você tem {} e deve se alistar imediatamente.'.format(dife))
elif dife < 18:
    dife2 = 18 - dife
    print('Você tem {} e ainda falta {} anos para você se alistar.'.format(dife,dife2))
else:
    dife2 = dife - 18
    dife3 = atual - dife2
    print('Você tem {} anos'.format(dife))
    #condiçao dentro da condiçao
    if dife2 == 1:
        print('Você já deveria ter se alistado a {} ano'.format(dife2))
    else:
        print('Você já deveria ter se alistado a {} anos'.format(dife2))

    print('Seu alistamento foi em {} anos'.format(dife3))
#Acabou.
    