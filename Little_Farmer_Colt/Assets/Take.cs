using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    Animator anim;
    int takeHash = Animator.StringToHash("Take");
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.T)){
            anim.Play(takeHash);
            GameData.water = GameData.water+1;
            Debug.Log(GameData.water);
        }
    }
}
