matriz = [[0,0,0],[0,0,0],[0,0,0]]
s1 = s2 = mai = 0

for l in range (0,3):
    for c in range(0,3):
        matriz[l][c] = int(input(f'Digite um número para [{l},{c}]: '))

print('-='*40)

for l in range (0,3):
    for c in range(0,3):
        print(f'[{matriz[l][c]:^5}]',end='')
        if matriz[l][c] % 2 == 0:
            s1 += matriz[l][c]
    print()

for l in range(0,3):
    s2 += matriz[l][2]

for c in range(0,3):
    if mai == 0:
        mai = matriz[1][c]

    elif matriz[1][c] > mai:
        mai = matriz[1][c]

print('-='*40)

print(f'A soma dos valores pares é {s1}.\nA soma dos valores da terceira coluna é {s2}.\nO maior valor da segunda linha é {mai}.')