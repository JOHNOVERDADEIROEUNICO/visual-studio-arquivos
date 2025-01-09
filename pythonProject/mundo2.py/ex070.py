
print('-'*40)
print(' LOJA SUPER BARATÃO '.center(40, '='))
print('-'*40)
p = s = countmc = pmb = count = 0

while True:
    n = str(input('Nome do produto: '))
    p = float(input('Preço: R$'))
    s += p
    count += 1

    if count == 1 or p < pmb:
        pmb = p
        nmb = n

    if p > 1000:
        countmc += 1

    resp = ' '
    while resp not in 'sn':
        resp = str(input('Quer continuar [s/n]? ')).strip().lower()[0]
    if resp == 'n':
        break

print(' fim do programa '.center(40, '='))
print(f'O total da compra foi R${s:.2f}')
print(f'Temos {countmc} produto(s) custando mais de R$1000.00')
print(f'O produto mais barato foi {nmb} que custa R${pmb:.2f}')
