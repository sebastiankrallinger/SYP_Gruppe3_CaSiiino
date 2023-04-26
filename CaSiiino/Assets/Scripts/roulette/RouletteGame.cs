using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RouletteGame : MonoBehaviour
{
    public GameObject Button;
    public GameObject InputField;
    
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
    };
    public void setEinsatz()
    {
        foreach (Field f in fieldlist)
        {
            if (f.Fieldnr == 1)
            {
                
            }
        }
    }
}
