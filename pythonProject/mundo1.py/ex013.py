pcent: float
produto: float

produto = float(input('Qual o preço do produto? R$'))
pcent = float(input('Digite o desconto desejado no prduto: '))
r = produto-(produto*pcent/100)
print('O produto que custava R$',produto,', na promoção com desconto de ',pcent,'% vai custar R${:.2f}'.format(r))