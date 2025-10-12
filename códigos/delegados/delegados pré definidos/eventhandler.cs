//ESTE DELEGADO É UMA GRANDE ABSTRAÇÃO, NORMALMENTE USADO EM PROGAMAÇÃO ORIENTADA A EVENTOS, SE QUISER ENTENDER MELHOR OLHAR A PASTA SOBRE O ASSUNTO.
// Sem argumentos personalizados
public event EventHandler AlgoAconteceu;

// Com argumentos personalizados
public event EventHandler<MyEventArgs> AlgoImportante;
