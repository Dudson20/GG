using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsManager.SetVolume(0, 4f);
        Debug.Log(PlayerPrefsManager.GetVolume());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
