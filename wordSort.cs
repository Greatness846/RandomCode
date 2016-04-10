private bool sortAlphabetically(string indexWord, string firstPosWord, int charIndex, string ascDsc = "asc") {

bool swapPosition;

if (ascDsc == "dsc")

{

if (charIndex < firstPosWord.Length && charIndex < indexWord.Length)

{

if ((char.ToUpper(indexWord[charIndex]) - 64) > (char.ToUpper(firstPosWord[charIndex]) - 64))

{

return true;

}

else if ((char.ToUpper(indexWord[charIndex]) - 64) == (char.ToUpper(firstPosWord[charIndex]) - 64))

{

swapPosition = sortAlphabetically(indexWord, firstPosWord, charIndex + 1, ascDsc);

return swapPosition;

}

else { return false; }

}

else { return false; }

}

else {

if (charIndex < firstPosWord.Length && charIndex < indexWord.Length)

{

if ((char.ToUpper(indexWord[charIndex]) - 64) < (char.ToUpper(firstPosWord[charIndex]) - 64))

{

return true;

}

else if ((char.ToUpper(indexWord[charIndex]) - 64) == (char.ToUpper(firstPosWord[charIndex]) - 64))

{

swapPosition = sortAlphabetically(indexWord, firstPosWord, charIndex + 1, ascDsc);

return swapPosition;

}

else { return false; }

}

else { return false; }

}

}
