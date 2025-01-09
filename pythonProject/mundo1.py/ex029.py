km: int
multa: int

km = int(input('Quantos por hora o carro estava? '))
if km <= 80:
    print('Tenha um bom dia.')
else:
    multa = (km - 80)*7
    print('A multa a ser paga devera ser de : ',multa,'R$.')
    print('Tenha um bom dia.')
