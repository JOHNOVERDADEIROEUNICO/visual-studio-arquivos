from datetime import date

ano = int(input('Digite um ano para saber se ele é bissexto ou não ou então digite 0 para pegar o ano atual: '))

if ano == 0:

    ano = date.today().year
    
elif ano % 4 == 0 and ano % 100 !=0:

    print('{} é bissexto.'.format(ano))

elif ano % 400 == 0 and ano % 100 == 0:

    print('{} é bissexto.'.format(ano))

else:

    print('{} não é um ano bissexto.'.format(ano))
