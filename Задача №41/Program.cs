// // Задача №41 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// // сколько чисел больше 0 ввёл пользователь. Ввод чисел 
// // останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

bool inpValid_01(int num)
{
    if(num > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool inpValid(string num)
{
    bool res_val = int.TryParse(num, out int res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

int intUserNum = 0;
string strUserNum = "";
int sumRes = 0;
while(true)
{
    Console.WriteLine("Введите следующее число или слово 'стоп': ");
    strUserNum = Console.ReadLine();
    if(strUserNum.ToLower() == "стоп")
    {
        Console.WriteLine($"Чисел больше 0: {sumRes}");
        break;
    }
    else
    {
        bool result = inpValid(strUserNum);
        if(result == true)
        {
            intUserNum = Int32.Parse(strUserNum);
            bool result_02 = inpValid_01(intUserNum);
            if(result_02 == true) 
            {
                sumRes++;
            }
            continue;
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
            continue;
        }
    }    
}