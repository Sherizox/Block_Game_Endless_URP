using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{

    public float Speed;
    
    private float EndPoint  = 3.2f;

    private float Horizontal;

    bool Left=false;
    bool Right=false;


    private void Start()
    {

        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        PlayerMoment();
        if (transform.position.x < -EndPoint)
        {
            transform.position= new Vector3 (-EndPoint, 0,0);
        }
        if (transform.position.x > EndPoint)
        {
            transform.position = new Vector3(EndPoint, 0, 0);
        }
      

        if (Left == true)
        {
            //rb.velocity= Vector3.left*Speed*Time.deltaTime;
           transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Right == true)
        {
            //rb.velocity= Vector3.right*Speed*Time.deltaTime;
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
    }
    
    public void LPointerDown()
    {
       Left = true;
       
    }

    public void LPointerUp()
    {
        Left = false;
     
    }

    public void RPointerDown()
    {
        Right = true;

    }

    public void RPointerUp()
    {
        Right = false;

    }
    public void PlayerMoment()
    {
        if (UnityEngine.Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (UnityEngine.Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
    }
}
