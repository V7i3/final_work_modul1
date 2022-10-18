
string[] ArrayThreeCharacter(string[] arrayStr){
    string[] str = new string[arrayStr.Length];
    for(int i = 0; i < arrayStr.Length; i++){
        if(arrayStr[i].Length <= 3 ){
            str[i] = arrayStr[i];
        }
    }
    str = str.Where(x => x != null).ToArray();
    return str;
}

void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        if(i+1 != array.Length) Console.Write(array[i] + ", ");
        else Console.WriteLine(array[i]);
    }
}

string[] arr = {"1234", "1567", "-2", "computer science"};
Console.Write($"Слова меньше 4 символов: ");
PrintArray(ArrayThreeCharacter(arr));
