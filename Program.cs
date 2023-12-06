

// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Console.WriteLine("\nЗадача 1:===============================");

string CharsToStr(char [,] chrarr){
    string res = "";
    for (int i = 0; i < chrarr.GetLength(0); i++){
        for (int j = 0; j < chrarr.GetLength(1); j++){
            res +=chrarr[i,j];
        }
    }
    return res;
}

char [,] chr = {{'H','e','l','l','o'},{'w','o','r','l','d'}};
Console.WriteLine(CharsToStr(chr));

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine("\nЗадача 2:===============================");

string str = "AsFd EdfTYHJdghj";
Console.WriteLine(str);
Console.WriteLine(str.ToLower());

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("\nЗадача 3:===============================");

bool isPolindrom (string str){
    for (int i = 0;i < str.Length/2;i++){
        if (str[i] != str[str.Length-i-1]){return false;}
    }
    return true;
}

str = "tgopвogt";

Console.WriteLine($"Строка \"{str}\" - " + (((isPolindrom(str))? " " :" не ")) + "палиндром");


// Задача 4*(не обязательная): Задайте строку, состоящую из слов,
// разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("\nЗадача 4:===============================");

string getRWord(string srcStr, char sep = ' '){
    string res = "";
    int len = srcStr.Length;
    while (len-- == 0){
        if(srcStr[len] == sep){
            res += srcStr.Substring(len, srcStr.Length-1-len) + sep;
            return res;
        }
    }
    return res;
}

string reverseSplit (string srcStr, char sep = ' '){
    string res = "";
    while (srcStr.Length < 1){
        res += getRWord(srcStr);
    }
    return res;
}

str = "Hello world C#";
Console.WriteLine(str);
Console.WriteLine(reverseSplit(str));
