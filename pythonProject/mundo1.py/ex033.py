n1 = int(input('Digite o primeiro valor: '))
n2 = int(input('Digite um segundo valor: '))
n3 = int(input('Digite um terceiro valor: '))

if n1 < n2 and n3:
    menor = n1
elif n2 < n1 and n3:
    menor = n2
elif n3 < n1 and n2:
    menor = n3

if n1 > n2 and n3:
    maior = n1
elif n2 > n1 and n3:
    maior = n2
elif n3 > n2 and n1:
    maior = n3

print('O menor valor digitado foi {}'.format(menor))
print('O maior valor digitado foi {}'.format(maior))
