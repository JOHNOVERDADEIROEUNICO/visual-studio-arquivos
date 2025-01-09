igual = []
expressão = str(input('Digite a expressão: '))
igual.append(expressão.count('('))
igual.append(expressão.count(')'))
if igual[0] == igual[1]:
    print('Essa é uma experessão válida!')
else:
    print('Essa é uma expressão inválida')