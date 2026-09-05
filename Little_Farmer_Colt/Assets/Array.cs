using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int[,]pigletArray = new int[10,3];
    int[,]pigArray = new int[10,3];
    int[,]chickArray = new int[10,3];
    int[,]chickenArray = new int[10,3];
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<10;i++)
        {
            pigletArray[i,0]=1;
            pigletArray[i,1]=0;
            pigletArray[i,2]=0;

            pigArray[i,0]=0;
            pigArray[i,1]=0;
            pigArray[i,2]=0;

            chickArray[i,0]=1;
            chickArray[i,1]=0;
            chickArray[i,2]=0;

            chickenArray[i,0]=0;
            chickenArray[i,1]=0;
            chickenArray[i,2]=0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
