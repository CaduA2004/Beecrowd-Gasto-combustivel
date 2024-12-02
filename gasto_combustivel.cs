using System; 

class URI {

    static void Main(string[] args) { 
        int tempo = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        double distancia = tempo * velocidadeMedia;

        double litros = distancia / 12.0;

        Console.WriteLine($"{litros:F3}");

    }

}