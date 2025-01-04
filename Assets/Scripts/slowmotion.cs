using System.Collections;
using UnityEngine;

public class slowmotion : MonoBehaviour
{
    public float timeEffect = 0.5f;
    private float startFixedDeltaTime;

   
    private float targetFOV = 70.3f; 
    private float fovChangeSpeed = .8f;

    void Start()
    {
        startFixedDeltaTime = Time.fixedDeltaTime;
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            StartCoroutine(SlowMotionEffect());
           
           
        }
    }


    IEnumerator SlowMotionEffect()
    {

        Time.timeScale = timeEffect;
        Time.fixedDeltaTime = startFixedDeltaTime * timeEffect;

        StartCoroutine(ChangeFOV(targetFOV));


        yield return new WaitForSecondsRealtime(1);

        if (HealthScript.instance.dead == false)
        {
            Camera.main.fieldOfView = 76.3f;
            Time.timeScale = 1.0f;
            Time.fixedDeltaTime = startFixedDeltaTime;
        }
        else if (HealthScript.instance.dead == true)
        {
            Time.timeScale = 0f;

        }

       
    }
    IEnumerator ChangeFOV(float targetFOV)
    {
        float startFOV = Camera.main.fieldOfView;
        float elapsedTime = 0;

        while (elapsedTime < fovChangeSpeed)
        {
            elapsedTime += Time.unscaledDeltaTime;
            Camera.main.fieldOfView = Mathf.Lerp(startFOV, targetFOV, elapsedTime / fovChangeSpeed);
            yield return null;
        }

        Camera.main.fieldOfView = targetFOV; 
    }
}
