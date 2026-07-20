from rpg import *

def main():
    p1 = Guerreiro("Ioannes", 1000)

    p2 = Mago("Merlin", 800)

    p1.atacar(p2)
    p2.atacar(p1)
    
    p1.atacar(p2)
    p2.curar()
    p1.atacar(p2)
    p2.atacar(p1)

    p1.curar()
    p2.atacar(p1)


main()