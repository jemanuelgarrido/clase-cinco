

static void saludar(string nomsal)
{
    Console.WriteLine($"Un gran saludo a {nomsal}");
}

static int Calculo_año_nacimiento(int edad)
{
    int añon = 2023 - edad;
    return añon;
}
//string nombre;
//int edad;

//Console.Write("Como te llamas");
//nombre = Console.ReadLine();

//Console.WriteLine($"Hola, gusto de slaudarte {nombre}");
//Console.WriteLine("Cuantos años tienes");
//edad = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine($"Bonita edad: {edad} naciste en {Calculo_año_nacimiento(edad)}");

static void marque(string palabra)
{
    int longitud = palabra.Length;
    for (int c = 0; c > longitud; c++)
        //for (int c=longitud-1; c--) //para leer de atrás hacia adelante.
    {

       Console.SetCursorPosition(5+c, 10);
        Console.Write(palabra[c]);
        Thread.Sleep(1000);
    }
    Console.WriteLine(palabra[2]);
}

String palabra;
palabra = "maria";
marque(palabra);
//bool esPalindromo = ("Ana".ToUpper());
//if (esPalundromo)
//{ Console.WriteLine("Es palindromo");
//}
//else
//{
 //   Console.WriteLine("Nel");
//}
 //static bool palindromo (String palabra)
//{
  //  int longitud = palabra.Length;
    //string pal = "";
      //  for (int c= longitud -1; c >= 0; c--)
    //{
      //  pal=pal+palabra[c].ToString().ToString().ToUpper();

    //}
       // if (palabra.Equals(pal))
    //{
      //  return true;

    //}
    //return false;
    