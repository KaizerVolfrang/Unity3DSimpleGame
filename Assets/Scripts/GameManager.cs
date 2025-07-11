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
        healthUI.text = $"Здоровье: {healthPlayer}";
        points = 0;
        pointsUI.text = "Очки: " + points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            healthPlayer--;
            Debug.Log("Здоровье: " + healthPlayer);
            healthUI.text = $"Здоровье: {healthPlayer}";
            if (healthPlayer <= 0)
            {
                timerManager.Die();
            }
        }
        else if (other.tag == "Apple")
        {
            points++;
            Debug.Log("Очки: " + points);
            pointsUI.text = "Очки: " + points;
            Destroy(other.gameObject);
        }
    }
}
