using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private int fieldnr;
    private string color;
    private int einsatz;

    public Field(int fieldnr, string color, int einsatz)
    {
        this.fieldnr = fieldnr;
        this.color = color;
        this.einsatz = einsatz;
    }
    public int Fieldnr
    {
        get { return fieldnr; }
        set { fieldnr = value; }
    }
    public int Einsatz
    {
        get { return einsatz; }
        set { einsatz = value; }
    }
}
