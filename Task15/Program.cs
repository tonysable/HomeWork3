Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= a){
    Console.WriteLine($"{count} -> {count * count * count}");
    count++;
}