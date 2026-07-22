import hashlib
from pwinput import pwinput

class Diario():
    def __init__(self):
        senha = input("Digite uma senha para proteger o diário: ").strip()

        if len(senha) > 0:
            cod = senha.encode('utf-8')
            hash = hashlib.sha256(cod).hexdigest()

            self.__segredos = []
            self.__senha = hash
        else:
            raise ValueError("Digite algo.")

    def escrever(self, msg):
        if isinstance(msg, str) and len(msg) > 0:
            self.__segredos.append(msg.strip())

    def ler(self):
        senha = str(pwinput("Digite sua senha: ")).strip()
        
        if len(senha) > 0 or senha == None:
            cod = senha.encode('utf-8')
            chave = hashlib.sha256(cod).hexdigest()

            if chave != self.__senha:
                raise PermissionError("Senha inválida; Acesso negado.")
            else:
                for segredos in self.__segredos:
                    print(f"- {segredos}")
        else:
            raise ValueError("Algo deu errado.")

    @property
    def senha(self):
        raise PermissionError(f"Acesso negado.")