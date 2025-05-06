using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
