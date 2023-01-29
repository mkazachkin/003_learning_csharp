//Два человека идут на встречу друг другу со скоростью firstSpeed и secondSpeed.
//Расстояние между ними wayLength.
//От первого человека ко второму бежит собака. Как только собака добегает до второго человека,
//она разворачивается и бежит к первому. Добежав до первого, собака снова разворачивается
//и бежит ко второму. Скорость собаки dogSpeed.
//Сколько раз собака проделает путь от человека к человеку, до того, как они
//окажутся друг от друга на расстоянии 10 м?

//Initializing
double firstSpeed, secondSpeed, currentManSpeed, closingSpeed, timeToMeetDog, wayLength, dogSpeed;
int counter;
//Meeting distance
const double meetLength = 0.01; //10 meters in km. 
//Let's input some parameters.
Console.Clear();
Console.Write("Введите скорость первого человека (км/ч): ");   //Speed in km/h
firstSpeed = double.Parse(Console.ReadLine());
Console.Write("Введите скорость второго человека (км/ч): ");   //Speed in km/h
secondSpeed = double.Parse(Console.ReadLine());
Console.Write("Введите скорость собаки (км/ч): ");             //Speed in km/h
dogSpeed = double.Parse(Console.ReadLine());
Console.Write("Введите расстояние между людьми (км): ");       //Distance in km
wayLength = double.Parse(Console.ReadLine());

//Let's check entered parameters.
if ((dogSpeed < firstSpeed) | (dogSpeed < secondSpeed))
{
    //We can't proceed with this parameters.
    Console.WriteLine("Собака не сможет убежать от человека. Задача нерешаемая.");

}
else if (wayLength < meetLength)
{
    //We can't proceed with this parameters.
    Console.WriteLine("Люди уже встретились. Собаке не надо бежать.");
}
else
{
    //We can do it.
    counter = 1;
    currentManSpeed = secondSpeed;
    while (wayLength > meetLength)
    {
        closingSpeed = currentManSpeed + dogSpeed;
        timeToMeetDog = wayLength / closingSpeed;
        wayLength = wayLength - timeToMeetDog * (firstSpeed + secondSpeed);
        counter++;
        if (currentManSpeed == firstSpeed)
        {
            currentManSpeed = secondSpeed;
        }
        else
        {
            currentManSpeed = firstSpeed;
        }
    }
    //Result output
    Console.WriteLine("Собака сбегает туда-обратно " + counter + " раз.");
}