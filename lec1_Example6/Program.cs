int weight1 = 1;
int weight2 = 2;
int weight3 = 6;
int weight4 = 8;
int weight5 = 4;

int max = weight1;

if (weight2>max) {
    max = weight2;
}

if (weight3>max) {
    max = weight3;
}

if (weight4>max) {
    max = weight4;
}

if (weight5>max) {
    max = weight5;
}
Console.WriteLine ("Максимальный вес: "+ max);