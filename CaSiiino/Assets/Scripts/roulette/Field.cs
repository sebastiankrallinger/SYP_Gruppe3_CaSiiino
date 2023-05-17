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
    private string bezeichnung;
    private int einsatz;

    public Field(int fieldnr, string bezeichnung, int einsatz)
    {
        this.fieldnr = fieldnr;
        this.bezeichnung = bezeichnung;
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
        set { einsatz += value; }
    }
    public string Bezeichnung
    {
        get { return bezeichnung; }
        set { bezeichnung = value; }
    }
}
