int[] array = {51,25,13,4,25,68,217,48,41};

int n = array.Length;
int find = 25;

int index = 0;

while (index < n){
    if (array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}