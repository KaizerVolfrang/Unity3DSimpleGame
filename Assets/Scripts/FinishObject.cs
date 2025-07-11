using UnityEngine;

public class FinishObject : MonoBehaviour
{

    public TimerManager timerManager;
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            timerManager.Win();
        }
    }
}
