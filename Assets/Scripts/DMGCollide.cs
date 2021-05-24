using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGCollide : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<healthDisplay>().HealthDown();
        Destroy(otherCollider.gameObject);
    }


}
