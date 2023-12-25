using System.Runtime.InteropServices.Marshalling;

string[] mass = {"Hello", "123", "geekbrains", "2024", "BM", "c#"};
bool Symbols(string a){
    if(a.Length <= 3){
        return true;                 // Функция, проверяющая подходит ли строка под условие задачи
    }
    else return false;
}
int Number(string[] mass){
    int n = 0;
    foreach(string a in mass){
        if(Symbols(a) == true){          // Функция, определяющая количество элементов в массиве, подходящих условию задачи
            n++;
        }
    }
    return n;
}
string[] NewMass(string[] mass){
    int n = Number(mass);
    string[] newmass = new string[n];
    int j = 0;
    for(int i = 0; i < mass.Length; i++){                       // Функция создания нового массива
        bool res = Symbols(mass[i]);
        if(res == true){
            newmass[j] = mass[i];
            j++;
        }
    }
    return newmass;
}
void PrintMass(string[] newmass){
    Console.Write("[");
    for(int i = 0; i < newmass.Length - 1; i++){                    // Функция вывода нового массива
        Console.Write($"{newmass[i]}, ");
    }
    Console.Write($"{newmass[newmass.Length - 1]}]");
}
string[] newmass = NewMass(mass);
PrintMass(newmass);








