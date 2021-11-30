using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindObjectOfType<PlayerBehaviour>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + new Vector3(0.0f, 0.0f, -11.0f);
    }
}
