using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGCollide : MonoBehaviour
{

    private void OnTriggerEnter2D()
    {
        FindObjectOfType<healthDisplay>().HealthDown();
    }


}
