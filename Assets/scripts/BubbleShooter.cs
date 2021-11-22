using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    [SerializeField]
    GameObject BubbleObj;

    [SerializeField]
    Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ShootBubble();
        }   
    }

    void ShootBubble()
    {
       Instantiate(BubbleObj, spawnPos.transform.position, Quaternion.identity);
        
    }
}
