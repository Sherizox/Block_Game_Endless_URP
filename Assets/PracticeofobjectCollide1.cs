using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeofobjectCollide1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
