#variaveis
print('{:=^40}'.format(' LOJINHA '))
pro = float(input('Qual será o valor do produto? '))
resp = str(input('Deseja parcelar [s/n]? '))
#estrutura inicial
if resp == 'n':
    pro = pro - pro*0.10
    print(f'Você recebeu um desconto de 10% por pagar a vista e o produto ira custar {pro}R$')
else:
    print('==== LOJINHA ====')
    print('[1] parcela em 2x')
    print('[2] parcela em 3x')
    print('[3] parcela em 4x ou mais.')
    escolha = int(input('Escolha uma opção de parcela: '))
#match/resposta
    match escolha:

        case 1:
            print('O preço será {:.2f}R$'.format(pro/2))

        case 2:
            pro = pro + pro*0.10
            print('O preço receberá juros de 10% e será {:.2f}R$'.format(pro/3))

        case 3:
            quant = int(input('Quantas vezes o produto será parcelado? (OBS: o produto receberá 20% de juros.)'))
            pro = pro + pro*0.20
            print('O preço com juros de 20% ficará em {}x de {:.2f}R$'.format(quant,pro/quant))
#ACABOU.