n1: float
km: int

km = int(input('Quantos Km serão percorridos?: '))
if km <= 200:
    n1 = 0.50*km
    print('O preço da passagem para percorrer {}km é de: {:.2f} R$'.format(km,n1))
else:
    n1 = 0.45*km
    print('O preço da passagem para viagens acima de 200 recebem 5 centavos de desconto, o preço da passagem para percorrer {}km é de: {:.2f} R$'.format(km,n1))

#outra maneira simples de fazer isso (porém feia) é: n1 = km * 0.50 if km <= 200 else km * 0.45.
