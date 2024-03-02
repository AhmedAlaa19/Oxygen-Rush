using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
    public static bool once_called;

    // Start is called before the first frame update
    void Start()
    {
        if (!once_called)
        {
            DontDestroyOnLoad(gameObject);
            once_called = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
