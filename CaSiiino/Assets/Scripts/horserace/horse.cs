using UnityEngine;

public class horse : MonoBehaviour
{
    private static int nextID = 1; 
    public int objectID;

    public int setId()
    {
        if (nextID > 4)
        {
            objectID = 0; 
            nextID = 1;
        }
        objectID = nextID;
        nextID++;
        return objectID;
    }
}
