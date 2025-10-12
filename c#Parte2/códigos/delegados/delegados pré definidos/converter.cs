//COMO O PROPRÍO NOME JÁ DIZ TEM COMO OBJETIVO CONVERTER UM MÉTODO DE UM TIPO PARA OUTRO TIPO.
Converter<string, int> converter = s => int.Parse(s);
int numero = converter("123");  // 123
