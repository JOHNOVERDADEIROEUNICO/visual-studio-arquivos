class Avalicao:
    def __init__(self, Nome, Disciplina, Nota = 0.0):
        self.__nome = Nome
        self.__disciplina = Disciplina 
        self.__nota = Nota

    def __str__(self):
        return f"O(A) aluno(a) {self.nome} na disciplina {self.disciplina} possuí a nota de {self.nota}"

    #getters e setters:
    @property
    def nome(self):
        return self.__nome

    @property
    def disciplina(self):
        return self.__disciplina

    @property
    def nota(self):
        return self.__nota
    
    @nota.setter
    def setNota(self, valor):
        if not valor:
            raise ValueError("Atributo vazio")
        self.__nota = valor