from diario import *

def main():
    try:
        d = Diario()
        d.escrever("Consegui fazer o exercicio")
        d.escrever("Segunda escrita")
        try:
            d.ler()
        except Exception as e:
            print(f"Erro: {e}")
    except Exception as e:
        print(f"Erro: {e}")


if __name__ == "__main__":
    main()