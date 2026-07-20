from poligonos import *

def main():
    q = Quadrado(20)

    print(f"Um quadrado de {q.lados} lado(s) tem um perímetro de {q.perimetro()}.")
    print(f"Um quadrado de {q.lados} lado(s) tem uma área de {q.area()}.")

    c = Circulo()

    print(f"Um círulo de {c.raio}cm raio possui um perimetro de {c.perimetro():.1f}cm.")
    print(f"Um círulo de {c.raio}cm raio possui uma área de {c.area():.1f}cm.")

main()