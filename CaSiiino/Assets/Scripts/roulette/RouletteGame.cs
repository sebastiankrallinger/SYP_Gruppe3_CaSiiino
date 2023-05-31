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
    private int randomfield=0;
    public GameObject Button;
    public TMP_InputField inputField;
    public TMP_Text setText;
    public TMP_Text gewinntext;
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
        new Field(41,"black",0),
        new Field(42,"red",0),
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
        string thisinfile="";
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
                    f.Einsatz = betrag;
                    //System.Diagnostics.Debug.WriteLine(f.Fieldnr + "\t" + f.Einsatz);
                    inputField.text = " ";
                    //File.WriteAllText("Assets/Scripts/roulette/data.txt", f.Fieldnr + "\t" + f.Einsatz);
                }
            }
            if (37 <= f.Fieldnr && f.Fieldnr <= 51)
            {
                if (f.Fieldnr == btnnr)
                {
                    f.Einsatz += betrag;
                    inputField.text = " ";
                    //File.WriteAllText("Assets/Scripts/roulette/data.txt", f.Bezeichnung + "\t" + f.Einsatz);
                }
            }
        }
        foreach(Field f in fieldlist)
        {
            thisinfile += f.Fieldnr+","+f.Bezeichnung+","+f.Einsatz+"/";
        }
        File.WriteAllText("Assets/Scripts/roulette/dataofallfields.txt", thisinfile);
    }
    public void spinthewheel()
    {
        Random rnd = new Random();
        randomfield=rnd.Next(0, 35 + 1);
        //randomfield = 15;
    }
    public int Gewinnermittlung()
    {
        int gewinn=0;
        int i = 0;
        string color="";
        string datafromfile = File.ReadAllText("Assets/Scripts/roulette/dataofallfields.txt");
        string[] subs = datafromfile.Split("/");
        foreach (Field f in fieldlist)
        {
            string[] subs2=subs[i].Split(",");
            f.Fieldnr = Convert.ToInt32(subs2[0]);
            f.Bezeichnung = subs2[1];
            f.Einsatz= Convert.ToInt32(subs2[2]);
            i++;
        }
        foreach(Field f in fieldlist)
        {
            if (f.Fieldnr == randomfield)
            {
                color = f.Bezeichnung;
            }
        }
        foreach(Field f in fieldlist)
        {
            if (0 < f.Fieldnr && f.Fieldnr <= 36)
            {
                if (f.Fieldnr == randomfield)
                {
                    gewinn += f.Einsatz * 36;
                }
            }
            if (37 == f.Fieldnr)
            {
                if (randomfield>18)
                {
                    gewinn += f.Einsatz * 2;
                }
            }
            if (38 == f.Fieldnr)
            {
                if (randomfield<19)
                {
                    gewinn += f.Einsatz * 2;
                }
            }
            if (39 == f.Fieldnr)
            {
                if (randomfield%2==0)
                {
                    gewinn += f.Einsatz * 2;
                }
            }
            if (40 == f.Fieldnr)
            {
                if (randomfield % 2 == 1)
                {
                    gewinn += f.Einsatz * 2;
                }
            }
            if (41 == f.Fieldnr)
            {
                if (f.Bezeichnung == color)
                {
                    gewinn += f.Einsatz * 2;
                }
            }
            if (42 == f.Fieldnr)
            {
                if (f.Bezeichnung == color)
                {
                    gewinn += f.Einsatz * 2;
                }
            }
            if (43 == f.Fieldnr|| 44 == f.Fieldnr)
            {
                if (0<randomfield&&randomfield<13)
                {
                    gewinn += f.Einsatz * 3;
                }
            }
            if (45 == f.Fieldnr || 46 == f.Fieldnr)
            {
                if (12 < randomfield && randomfield < 25)
                {
                    gewinn += f.Einsatz * 3;
                }
            }
            if (47 == f.Fieldnr || 48 == f.Fieldnr)
            {
                if (24 < randomfield && randomfield < 37)
                {
                    gewinn += f.Einsatz * 3;
                }
            }
            if (49 == f.Fieldnr)
            {
                if (randomfield%3==1)
                {
                    gewinn += f.Einsatz * 3;
                }
            }
            if (50 == f.Fieldnr)
            {
                if (randomfield%3==2)
                {
                    gewinn += f.Einsatz * 3;
                }
            }
            if (51 == f.Fieldnr)
            {
                if (randomfield % 3 == 0)
                {
                    gewinn += f.Einsatz * 3;
                }
            }
        }
        return gewinn;
    }
    public void Gewinnanzeige()
    {
        gewinntext.text = "Du hast " + Gewinnermittlung() + " Cristalle gewonnen!"+"\n\n"+randomfield;
    }
}
