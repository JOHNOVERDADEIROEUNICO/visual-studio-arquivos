#variaveis iniciais
print('---- ANALISANDO IDADES PARA CATEGORIAS DE NATAÇÃO ----')
ano =  int(input('Em que ano voce nasceu? '))
atual = 2024
dife = atual - ano
#resposta/condicionais
if dife <= 8:
    print('Nascidos em {} pertecem a categoria pré mirim que vai até os 8 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))

elif dife >= 9 and dife <= 10:
    print('Nascidos em {} pertecem a categoria mirim que começa nos 9 vai até os 10 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))

elif dife >= 11 and dife <= 12:
    print('Nascidos em {} pertecem a categoria petiz que começa nos 11 vai até os 12 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))

elif dife >= 13 and dife <= 14:
    print('Nascidos em {} pertecem a categoria infantil que começa nos 13 vai até os 14 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))

elif dife >= 15 and dife <= 16:
    print('Nascidos em {} pertecem a categoria juvenil que começa nos 15 vai até os 16 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))

elif dife >= 17 and dife <= 19:
    print('Nascidos em {} pertecem a categoria júnior que começa nos 17 vai até os 19 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))

else:
    print('Nascidos em {} pertecem a categoria sénior que começa nos 20 anos de idade.\nO(a) atleta possui {} anos.'.format(ano,dife))
#ACABOU.