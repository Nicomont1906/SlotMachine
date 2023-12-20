# SlotMachine
SlotMachine è un programma che permette di realizzare una SlotMachine.
Questo progetto è stato suddiviso in 3 diversi progettazioni:
- Realizzare una libreria di classi C# con le classi relative alla SlotMachine
- Realizzare un programma WPF che usa la libreria di classi
- Realizzare un programma Console che usa la stessa libreria di classi

  MainWindowXaml.cs
  ```
  private void checkBoxStopSimb1_Checked(object sender, RoutedEventArgs e)
        {
            slotMachine.StopSimbolo1 = true;
        }
  ```
  questo metodo ci permette, se vogliamo di bloccare la prima Box, facciamo così anche per gli altri Box in modo tale da poter fissare una qualunche casella.
```
private void Spin_Click(object sender, RoutedEventArgs e)
        {
            slotMachine.Gioca();

            if (slotMachine.NumGiocata % 3 == 0)
            {
                // Rilascia le checkbox alla fine di ogni serie di tre giocate
                checkBoxStopSimb1.IsChecked = false;
                checkBoxStopSimb2.IsChecked = false;
                checkBoxStopSimb3.IsChecked = false;
            }

            textBoxLett1.Text = slotMachine.Simbolo1.ToString();
            textBoxLett2.Text = slotMachine.Simbolo2.ToString();
            textBoxLett3.Text = slotMachine.Simbolo3.ToString();

            textBoxResult.Text = "Vincita = " + slotMachine.GetMoneteVinte().ToString();
            textBoxCredits.Text = "Crediti = " + slotMachine.Credito.ToString();

            if (slotMachine.Credito == 0)
            {
                Spin.Visibility = Visibility.Hidden;
                textBoxCredits.Text = "Hai terminato i crediti! = " + slotMachine.Credito.ToString();
            }
        }
```


Fa girare la slot machine invocando il metodo Gioca() sull'oggetto slotMachine.
Se il numero totale di giocate effettuate è multiplo di 3, reimposta le checkbox associate ai simboli a "non spuntate".
Aggiorna le caselle di testo con i simboli attualmente visualizzati sulla slot machine.
Aggiorna una casella di testo con l'informazione sulla vincita corrente.
Aggiorna una casella di testo con l'informazione sui crediti rimanenti nella slot machine.
Se il saldo dei crediti è zero, nasconde il pulsante "Spin" e mostra un messaggio che indica che i crediti sono esauriti.
