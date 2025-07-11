using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Text timerText; // ��������� ������� ��� ����������� �������
    public GameObject panelTime; // ������ TimeOver
    public GameObject winLosePanel;
    public GameObject menuPanel;
    public Text winLoseText;
    public int timerSeconds = 60;
    private bool isTimerStart = false;
    private Coroutine coroutineTimer;
    void Start()
    {
        panelTime.SetActive(false); // ��������� ��������� ������ �� ������ ����
        winLosePanel.SetActive(false);
        menuPanel.SetActive(false);
    }

    public void StartTimer()
    {
        if (isTimerStart) return;

        isTimerStart = true;
        panelTime.SetActive(true);
        coroutineTimer = StartCoroutine(Time());
    }

    public IEnumerator Time()
    {
        for (int i = timerSeconds; i >= 0; i--)
        {
            timerText.text = i.ToString(); // ��������� ����� �������
            yield return new WaitForSeconds(1f);
        }
        timerText.text = "����� �����";
        winLosePanel.SetActive(true);
        winLoseText.text = "�� ���������";
        OpenMenu();
         // ���������� ��������� ������ �� ���������� �������
    }

    private void OpenMenu()
    {
        menuPanel.SetActive(true);

    }

    public void Win()
    {
        StopCoroutine(coroutineTimer);
        winLosePanel.SetActive(true);
        winLoseText.text = "�� ��������";
        OpenMenu();
    }

    public void Die()
    {
        StopCoroutine(coroutineTimer);
        winLosePanel.SetActive(true);
        winLoseText.text = "�� ���������";
        OpenMenu();
    }
}
