string str;
long a;
Console.WriteLine("Введите число: ");
str = Console.ReadLine();
a = Convert.ToInt32(str);
long c;
c = a;
long b;
b = 0;
    while (a > 0){
        b *= 10;
        b += a % 10;
        a /= 10;
     }
if(c == b){
    Console.WriteLine("Это палиндром!");
}
else{
    Console.WriteLine("Не палиндром");
}    