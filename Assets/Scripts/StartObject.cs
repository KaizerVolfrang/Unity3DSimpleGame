using UnityEngine;

public class StartObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TimerManager timerManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            timerManager.StartTimer();
        }
    }
}
