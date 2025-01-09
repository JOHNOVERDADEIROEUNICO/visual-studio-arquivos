try:
    a = int(input('Numerador: '))
    b = int(input('Denominador: '))
    r = a/b
#except Exception as erro:
    #print('Infelizmente você é BURRO! e tivemos um problema... :(')
    #print(f'O problema foi {erro.__class__}')

#except Exception as erro:
    #print(f'O Erro foi {erro.__cause__}')

except(ValueError, TypeError):
    print('Tivemos problemas com os tipos de dados que você digitou.')

except ZeroDivisionError:
    print('Não é possível dividir um número por Zero!')

except KeyboardInterrupt:
    print('O usuário preferiu não inserir os dados!')

else:   
    print(f'O resultado é {r:.2f}')

finally:
    print('Volte sempre!')