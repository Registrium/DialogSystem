using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringTest : MonoBehaviour
{
    string naration = "ABCDEFGHIJK";
    // Start is called before the first frame update
    void Start()
    {
        for (int a = 0; a < naration.Length; a++) {
            Debug.Log(naration[a]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
