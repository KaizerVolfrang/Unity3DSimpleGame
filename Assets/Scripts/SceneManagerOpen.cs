using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerOpen : MonoBehaviour
{
    public void gameOpen()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
