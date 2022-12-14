using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float destroyTime = 30f;
    private float time = 0;

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= destroyTime)
        {
            Destroy(gameObject);
        }
    }
}
