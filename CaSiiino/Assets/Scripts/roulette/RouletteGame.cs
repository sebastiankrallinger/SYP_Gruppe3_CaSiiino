using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;
using System.IO;
using Random = System.Random;

public class RouletteGame : MonoBehaviour
{
    private int randomfield;
    public GameObject Button;
    public TMP_InputField inputField;
    public TMP_Text setText;
    List<Field> fieldlist = new List<Field>()
    {
        new Field(0,"green",0),
        new Field(1,"black",0),
        new Field(2,"red",0),
        new Field(3,"black",0),
        new Field(4,"red",0),
        new Field(5,"black",0),
        new Field(6,"red",0),
        new Field(7,"black",0),
        new Field(8,"red",0),
        new Field(9,"black",0),
        new Field(10,"red",0),
        new Field(11,"black",0),
        new Field(12,"red",0),
        new Field(13,"black",0),
        new Field(14,"red",0),
        new Field(15,"black",0),
        new Field(16,"red",0),
        new Field(17,"black",0),
        new Field(18,"red",0),
        new Field(19,"black",0),
        new Field(20,"red",0),
        new Field(21,"black",0),
        new Field(22,"red",0),
        new Field(23,"black",0),
        new Field(24,"red",0),
        new Field(25,"black",0),
        new Field(26,"red",0),
        new Field(27,"black",0),
        new Field(28,"red",0),
        new Field(29,"black",0),
        new Field(30,"red",0),
        new Field(31,"black",0),
        new Field(32,"red",0),
        new Field(33,"black",0),
        new Field(34,"red",0),
        new Field(35,"black",0),
        new Field(36,"red",0),
        new Field(37,"Passe",0),
        new Field(38,"Manque",0),
        new Field(39,"Pair",0),
        new Field(40,"Inpair",0),
        new Field(41,"Schwarz",0),
        new Field(42,"Rot",0),
        new Field(43,"(1-12)",0),
        new Field(44,"(1-12)",0),
        new Field(45,"(13-24)",0),
        new Field(46,"(13-24)",0),
        new Field(47,"(25-36)",0),
        new Field(48,"(25-36)",0),
        new Field(49,"Linke Spalte",0),
        new Field(50,"Mitte Spalte",0),
        new Field(51,"Rechte Spalte",0),
    };

    public void whichField()
    {
        string[] subs1 = Button.name.Split("n");
        string[] subs2 = subs1[1].Split('P', 'M', 'I', 'S', 'R', 'D', 'l', 'm', 'r');
        File.WriteAllText("Assets/Scripts/roulette/data.txt", subs2[0]);
        int btnnr = Int32.Parse(subs2[0]);
        foreach (Field f in fieldlist)
        {
            if (0 <= f.Fieldnr && f.Fieldnr <= 36)
            {
                if (f.Fieldnr == btnnr)
                {
                    setText.text = "Geben sie hier den Betrag ein den sie auf das Feld " + f.Fieldnr + " setzen wollen!";
                    inputField.text = " ";
                }
            }
            if(37 <= f.Fieldnr && f.Fieldnr <= 51)
            {
                if (f.Fieldnr == btnnr)
                {
                    setText.text = "Geben sie hier den Betrag ein den sie auf das Feld " + f.Bezeichnung + " setzen wollen!";
                    inputField.text = " ";
                }
            }
        }
    }
    public void setEinsatz()
    {
        int betrag;
        int.TryParse(inputField.text, out betrag); 
        string data=File.ReadAllText("Assets/Scripts/roulette/data.txt");
        int btnnr = Int32.Parse(data);
        foreach (Field f in fieldlist)
        {
            if (0 <= f.Fieldnr && f.Fieldnr <= 36)
            {
                if (f.Fieldnr == btnnr)
                {
                    f.Einsatz += betrag;
                    inputField.text = " ";
                    File.WriteAllText("Assets/Scripts/roulette/data.txt", f.Fieldnr + "\t" + f.Einsatz);
                }
            }
            if (37 <= f.Fieldnr && f.Fieldnr <= 51)
            {
                if (f.Fieldnr == btnnr)
                {
                    f.Einsatz += betrag;
                    inputField.text = " ";
                    File.WriteAllText("Assets/Scripts/roulette/data.txt", f.Bezeichnung + "\t" + f.Einsatz);
                }
            }
        }
    }
    public void spinthewheel()
    {
        Random rnd = new Random();
        randomfield=rnd.Next(0, 36 + 1);
        File.WriteAllText("Assets/Scripts/roulette/data.txt", Convert.ToString(randomfield));
    }
    
}
