byte numero1, numero2;
ushort resultado;

Console.WriteLine("Ingresa dos Numeros de dos cifras para Multiplicar:");
Console.WriteLine("Numero1:");
numero1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Numero2:");
numero2 = Convert.ToByte(Console.ReadLine());
resultado = Convert.ToUInt16(numero1 * numero2);
Console.WriteLine("El Resultado es:" + resultado);



