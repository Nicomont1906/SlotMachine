using SlotMachineLib;
using System;

namespace montaspro.nicolo._4i.SlotConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inizializzazione della slot machine
            SlotMachine slotMachine = new SlotMachine();

            // Variabili per tenere traccia dello stato delle checkbox
            bool stopSimbolo1 = false;
            bool stopSimbolo2 = false;
            bool stopSimbolo3 = false;

            while (true)
            {
                Console.WriteLine("Premi 'S' per girare la slot machine o 'Q' per uscire:");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(input) == 'Q')
                {
                    break;
                }
                else if (char.ToUpper(input) == 'S')
                {
                    // Imposta lo stato della slot machine in base alle checkbox
                    slotMachine.StopSimbolo1 = stopSimbolo1;
                    slotMachine.StopSimbolo2 = stopSimbolo2;
                    slotMachine.StopSimbolo3 = stopSimbolo3;

                    // Esegue la giocata
                    slotMachine.Gioca();

                    // Visualizza i risultati
                    Console.WriteLine($"Simbolo 1: {slotMachine.Simbolo1}");
                    Console.WriteLine($"Simbolo 2: {slotMachine.Simbolo2}");
                    Console.WriteLine($"Simbolo 3: {slotMachine.Simbolo3}");
                    Console.WriteLine($"Vincita: {slotMachine.GetMoneteVinte()}");
                    Console.WriteLine($"Crediti: {slotMachine.Credito}");

                    // Rilascia le checkbox alla fine di ogni serie di tre giocate
                    if (slotMachine.NumGiocata % 3 == 0)
                    {
                        stopSimbolo1 = stopSimbolo2 = stopSimbolo3 = false;
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Riprova.");
                }
            }
        }
    }
}
