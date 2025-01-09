import ex109files

preço = float(input('Digite o preço: R$:'))

print(f'A metade de R${ex109files.moeda(preço)} é {ex109files.metade(preço)}')

print(f'O dobro de R${ex109files.moeda(preço)} é {ex109files.dobro(preço)}')

print(f'Aumentando 10% de R${ex109files.moeda(preço)} temos {ex109files.dezporcento(preço)}')