using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public Transform posRespawn;
    


    

    public void DeadPlayer()

    {
        transform.position = posRespawn.position;
    }
}
