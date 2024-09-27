using System;
using System.Collections.Generic;

class Dictionary
{
    // Method to return the key with the highest score
    public static string BestScore(Dictionary<string, int> myList)
    {
        // Check if the dictionary is empty
        if (myList == null || myList.Count == 0)
        {
            return "None";
        }

        // Variables to track the key with the highest value
        string bestKey = null;
        int highestScore = -1;

        // Loop through the dictionary to find the highest score
        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > highestScore)
            {
                highestScore = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey;
    }
}
