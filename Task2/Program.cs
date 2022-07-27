// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
//объединяя элементы исходного массива попарно.

//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
string[] PairwiseUnion(string[]  word)
{	
    string[] change=new string[word.Length/2];
	for (int i=0; i<word.Length-1; i++)
        {
        word[i]=word[i]+word[i+1];
        }
        
	return word;
}



void    ShowWords(string[] words)
{
	for (int  i=0;i<words.Length;i++)
		Console.Write(words[i]+"  ");
}

void    ShowWordsCheng(string[] words)
{
	for (int  i=0;i<words.Length;i+=2)
		Console.Write(words[i]+"  ");
}
string[] wordsarray={"wer","opera","soft","aeroport","elephant","qwe", "wer", "ert", "rty", "tyu"};

ShowWords(wordsarray);

Console.WriteLine();

ShowWordsCheng(PairwiseUnion(wordsarray));