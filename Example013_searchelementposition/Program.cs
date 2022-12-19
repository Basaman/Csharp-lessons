int [] array = { 111, 222, 34, 46, 555, 62, 77, 222, 81};

int n = array.Length;
int find = 81;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
