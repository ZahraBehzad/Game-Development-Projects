using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    // Start is called before the first frame update

    private static int _water = 0;
    private static int _corn =0;

    public static int water
    {
        get{return _water;}
        set{_water = value;}
    }
    public static int corn
    {
        get{return _corn;}
        set{_corn = value;}
    }
    // public int corn = 0;
    // public int water=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
