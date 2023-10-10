int [] array = {1,21,34,3,4,56,6,452,2,4234,56};

int n = array.Length;
int find = 56;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}