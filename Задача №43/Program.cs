// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CrossPoint(double[] array)
{
    double x = (array[0] - array[2]) / (array[3] - array[1]);
    double y = (array[3] * array[0] - array[1] * array[2]) / (array[3] - array[1]);
    if(array[1] == array[3]) Console.Write("Lines do not intersect!");
    else Console.Write($"The point of intersection of the lines: ({x}; {y})");
}

double[] userArray(string[] array)
{
    double[] array_01 = new double[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
    {
        double nextEl = nextElArr($"Enter {array[idx]} coords: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

double nextElArr(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    double num = 0.0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = inpValid(elem);
        if(resVal == true)
        {
            num = Double.Parse(elem);
        }
        else
        {
            Console.WriteLine("Enter error! Try again!");
            continue;
        }      
    }
    return num;
}

bool inpValid(string num)
{
    bool res_val = Double.TryParse(num, out double res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("Enter 's' to start or enter 'q' to stop: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] array_01 = {"b1", "k1", "b2", "k2"};
        double[] doubArray = new double[array_01.Length];
        doubArray = userArray(array_01);
        CrossPoint(doubArray);
    }    
}