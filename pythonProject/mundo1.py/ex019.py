import math

ang: float

ang = float(input('Ângulo: '))
rad = math.radians(ang)
print('O seno {}\nO cos {}\nA tan {}'.format(math.sin(rad),math.cos(rad),math.tan(rad)))