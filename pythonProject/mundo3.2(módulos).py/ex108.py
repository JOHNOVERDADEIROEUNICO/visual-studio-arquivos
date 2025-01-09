import ex107_until_108_files

preço = float(input('Digite o preço: R$:'))

print(f'A metade de R${ex107_until_108_files.moeda(preço)} é {ex107_until_108_files.moeda(ex107_until_108_files.metade(preço))}')

print(f'O dobro de R${ex107_until_108_files.moeda(preço)} é {ex107_until_108_files.moeda(ex107_until_108_files.dobro(preço))}')

print(f'Aumentando 10% de R${ex107_until_108_files.moeda(preço)} temos {ex107_until_108_files.moeda(ex107_until_108_files.dezporcento(preço))}')