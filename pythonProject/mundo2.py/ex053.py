frase = str(input('Digite uma frase: ')).strip().upper()
palavras = frase.split()
junto = ''.join(palavras)
inverso = ''
for letra in range(len(junto) -1,-1,-1):
    inverso += junto[letra]
print(junto,inverso)
if junto == inverso:
    print('Esta palavra é um palíndromo!')
else:
    print('Esta palavra não é um palíndromo!')
#sem o uso de for:
# palavras = frase.split()
# junto = ''.join(palavras)
# inverso = junto [::-1]
# variavel += é o mesmo que variavel = variavel + algo.