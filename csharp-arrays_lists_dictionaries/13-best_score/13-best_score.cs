using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        // Check if the dictionary is empty
        if (myList == null || myList.Count == 0)
        {
            return "None";
        }

        // Initialize variables to track the key with the highest value
        string bestKey = string.Empty;  // Use an empty string instead of null to avoid warnings
        int highestScore = -1;

        // Loop through the dictionary to find the key with the highest score
        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > highestScore)
            {
                highestScore = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey ?? "None";  // Ensure no null reference return
    }
}
