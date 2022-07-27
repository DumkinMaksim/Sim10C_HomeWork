//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

int FillVowelLetter(string[]  word)
{	int  rezult=0;
	char[]  glasletter={'a', 'A','e','E', 'i','I','o','O', 'u','U', 'y','Y'};

	for (int i=0; i<word.Length; i++)
		for (int j=0; j<glasletter.Length; j++)

			if (word[i][0] ==  glasletter[j])

			rezult++;

	return rezult;
}



void    ShowWords(string[] words)
{
	for (int  i=0;i<words.Length;i++)
		Console.Write(words[i]+"  ");
}
string[] wordsarray={"wer","opera","soft","aeroport","elephant","qwe", "wer", "ert", "rty", "tyu"};

ShowWords(wordsarray);

Console.WriteLine();

Console.WriteLine("words starting with a vowel letter ->  "+FillVowelLetter(wordsarray));
