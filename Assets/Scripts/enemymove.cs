using UnityEngine;

public class enemymove : MonoBehaviour
{
    public float speedForward = 8f;
    private Rigidbody rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
     
       
    }
    private void Update()
    {
        rb.AddForce(-Vector3.forward * speedForward, ForceMode.VelocityChange);
        if (transform.position.z < -8.56)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
       // rb.AddForce(-Vector3.forward * speedForward, ForceMode.VelocityChange);
    }
}
