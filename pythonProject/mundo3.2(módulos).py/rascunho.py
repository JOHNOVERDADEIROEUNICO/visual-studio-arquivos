def moeda(p = 0, m = 'R$'):
    return f'{m}{p:.2f}'.replace('.',',')

f = str(input('Digite o preço: R$'))


f = float(f)

f = f + f
print(f)
