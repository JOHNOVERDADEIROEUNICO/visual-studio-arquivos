from encapsulamento import ContaBancaria

def main():
    c1 = ContaBancaria(111, "John", 5000)
    c1.deposito(500)
     
    print(c1)

if __name__ == "__main__":
    main()