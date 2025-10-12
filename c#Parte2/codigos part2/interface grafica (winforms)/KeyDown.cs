private void Calculadora_KeyDown(object sender, KeyEventArgs e)
 {

     // Números e Operadores:
     //Curiosidade: se for configurar no KeyDown para ele pegar um caracter que precisa de duas teclas, essa configuração deve vir primeiro, pois se não o sistema vai entender que voce está pressionando uma das duas teclas de caracter ao inves de duas.
     if (e.KeyCode == Keys.D5 && e.Shift)
     {
         porcetagem_Click(null, null);
         e.SuppressKeyPress = true;
     }
     else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) // Teclado normal
     {
         txtDisplay.Text += (e.KeyCode - Keys.D0).ToString();
         e.SuppressKeyPress = true;
     }
     else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) // Teclado numérico
     {
         txtDisplay.Text += (e.KeyCode - Keys.NumPad0).ToString();
         e.SuppressKeyPress = true;
     }
     else if (e.KeyCode == Keys.Add)
     {
         Mais_Click(null, null);
         e.SuppressKeyPress = true;
     }
     else if (e.KeyCode == Keys.Subtract)
     {
         Menos_Click(null, null);
         e.SuppressKeyPress = true;
     }
     else if (e.KeyCode == Keys.Multiply)
     {
         Multiplicador_Click(null, null);
         e.SuppressKeyPress = true;
     }
     else if (e.KeyCode == Keys.Divide)
     {
         Divisor_Click(null, null);
         e.SuppressKeyPress = true;
     }

     // Igual (= ou Enter)
     else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
     {
         Igual_Click(null, null);
         e.SuppressKeyPress = true;

     }

     // Clear (ESC ou Delete)
     else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
     {
         Clear_Click(null, null);
     }

     // Ponto decimal
     else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
     {
         if (!txtDisplay.Text.Contains(","))
         {
             txtDisplay.Text += ",";
             e.SuppressKeyPress = true;
         }
     }
 
 }