Console.WriteLine("Введите первое число");
int max;
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c =  Convert.ToInt32(Console.ReadLine());
if(a>b){
    max=a;
}
if(a>c){
    max=a;
}
else {
    max=c;
}
if(b>a){
    max=b;
}
if(c>b){
    max=c;
}
Console.WriteLine("Максимальное число:"+ max );
