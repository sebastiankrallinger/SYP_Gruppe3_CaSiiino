using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateRouletteWheel : MonoBehaviour
{

    void Start()
    {
    }
    void Update(PointerEventData eventData)
    {
        transform.rotation *= Quaternion.Euler(0, 50f * Time.deltaTime, 90);
    }
}