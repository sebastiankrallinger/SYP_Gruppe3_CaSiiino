using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Filehandling : MonoBehaviour
{
    private string[] split;
    private Dictionary<string, string> players = new Dictionary<string, string>();
    UsernameFunctions userFunctions;
    private string path = "Assets/Assets/Resources/data.txt";
    public static String currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        userFunctions = FindAnyObjectByType<UsernameFunctions>();
    }

    public void write()
    {
        read();
        StreamWriter writer = new StreamWriter(path, true);
        if (players.ContainsKey(userFunctions.username.text))
        {
            currentPlayer = userFunctions.username.text;
            userFunctions.coinsField.text = players[currentPlayer];
            writer.Close();
        }
        else
        {
            currentPlayer = userFunctions.username.text;
            writer.WriteLine(userFunctions.username.text + ";" + userFunctions.coinsField.text);
            writer.Close();
        }
    }

    public void read()
    {
        StreamReader reader = new StreamReader(path);
        string textFile = "";
        do
        {
            textFile = reader.ReadLine();
            if (textFile != null)
            {
                split = textFile.Split(';');
                if (players.ContainsKey(split[0]))
                {
                    break;
                }
                else
                {
                    players.Add(split[0], split[1]);
                }
            }
        } while (textFile != null);


        reader.Close();
    }

    public String getCoins()
    {
        read();
        players.TryGetValue(currentPlayer, out string c);
        return c;
    }
    public String getUser()
    {
        return currentPlayer;
    }

    public void updateCoins(string newAmount, bool win)
    {
        read();
        string currentCoins = players[currentPlayer];
        if (win == true)
        {
            int newCoins = Convert.ToInt32(newAmount) + Convert.ToInt32(currentCoins);
            players[currentPlayer] = Convert.ToString(newCoins);
        }
        else
        {
            int newCoins = Convert.ToInt32(currentCoins) - Convert.ToInt32(newAmount);
            players[currentPlayer] = Convert.ToString(newCoins);
        }
        //Debug.Log(players[currentPlayer]);
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);
        }
        StreamWriter writer = new StreamWriter(path, true);
        foreach (string s in players.Keys)
        {
            foreach (string c in players.Values)
            {
                writer.WriteLine(s + ";" + c);
            }
        }
        writer.Close();
    }

    public int coins()
    {
        read();
        string c = players[currentPlayer];
        return Convert.ToInt32(c);
    }
}
