print('-' *30)
print('Sequência de Fibonacci')
print('-' *30)
termo = int(input('Quantos termos você deseja mostrar? '))
c = 0
v1 = 0
v2 = 0
while c < termo:
    print(v1,end=' -> ')
    v3 = v1
    v1 = v1+v2
    v2 = v3
    if v1 < 1:
        v1 = 1
    c += 1
print('FIM')