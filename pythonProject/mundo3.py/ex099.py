def maior(*num):
    mai = 0
    print('Analisando os valores passados...')

    for i in range(len(num)):
        print(num[i], end=' ')

        if len(num) == 0:
            mai = num[i]
        elif num[i] > mai:
            mai = num[i]

    if len(num) > 1:
        print(f'Foram analisados {len(num)} valores ao todo.')
    else:
        print(f'Foram analisados {0} valores ao todo.')

    print(f'O maior valor informado foi {mai}.')

maior(20, 1, 2, 3)
maior()