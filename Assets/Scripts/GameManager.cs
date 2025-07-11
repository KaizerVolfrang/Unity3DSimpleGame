using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public int healthPlayer;
    public int points;
    public Text healthUI; 
    public Text pointsUI; 
    public TimerManager timerManager;
    private void Start()
    {
        healthUI.text = $"��������: {healthPlayer}";
        points = 0;
        pointsUI.text = "����: " + points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            healthPlayer--;
            Debug.Log("��������: " + healthPlayer);
            healthUI.text = $"��������: {healthPlayer}";
            if (healthPlayer <= 0)
            {
                timerManager.Die();
            }
        }
        else if (other.tag == "Apple")
        {
            points++;
            Debug.Log("����: " + points);
            pointsUI.text = "����: " + points;
            Destroy(other.gameObject);
        }
    }
}
