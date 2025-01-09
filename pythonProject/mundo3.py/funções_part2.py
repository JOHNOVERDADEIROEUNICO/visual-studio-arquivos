def contador(*num):
    tam = len(num)
    for valor in num:
        print(f'{valor} ', end='')
    print(f'Recebi os  valores {num} e são ao todo {tam} números.', end='')
    print('FIM!')

contador(2, 1, 7)
print()
contador(8, 0)
print()
contador(4, 4, 7, 6, 2)
print()