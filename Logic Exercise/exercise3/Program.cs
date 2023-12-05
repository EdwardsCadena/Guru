
Console.Write("Ingrese un carácter para los ojos: ");
string ojos = Console.ReadLine();

Console.Write("Ingrese un carácter para las cejas: ");
string cejas = Console.ReadLine();

Console.Write("Ingrese un carácter para la nariz: ");
string nariz = Console.ReadLine();

Console.Write("Ingrese tres caracteres para la boca: ");
string boca = Console.ReadLine();

Console.Write("Ingrese un carácter para el pelo: ");
string pelo = Console.ReadLine();

Console.Write("Ingrese un carácter para las orejas: ");
string orejas = Console.ReadLine();

Console.Write("Ingrese un carácter para delinear la cara: ");
string contorno = Console.ReadLine();

Console.Write("Ingrese tres caracteres para el mentón: ");
string menton = Console.ReadLine();

string cara = $@"
  {pelo}{pelo}{pelo}{pelo}{pelo}
{contorno}   {cejas}   {cejas}   {contorno}
{orejas[0]}  {ojos}  {ojos}  {orejas[1]}
 {contorno}     {nariz}     {contorno}
 {contorno}   {boca}   {contorno}
  {contorno}         {contorno}
     {menton}";

Console.WriteLine(cara);