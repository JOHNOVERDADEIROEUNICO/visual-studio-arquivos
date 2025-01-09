#variaveis
peso = float(input("informe seu peso: "))
    
altura = float(input("informe sua altura: "))
#calculo   
imc = peso/altura**2
#resposta/condicionais
print("seu imc é: {:.2f}".format(imc))

if imc >= 18 and imc <= 25:
    print("voce esta no peso ideial")

elif imc < 18:
    print("voce esta abaixo do peso")
        
elif imc > 25 and imc <= 30:
    print("voce esta com sobrepeso")
          
elif imc > 30 and imc <= 35:
    print("voce esta obeso")
            
elif imc > 35 and imc <= 40:
    print("voce esta com obesidade severa")
              
else:
    print("voce esta com obesidade morbida")
#ACABOU.
