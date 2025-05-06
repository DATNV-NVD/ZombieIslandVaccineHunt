using UnityEngine;

public class WinScript : MonoBehaviour
{

    public GameObject winMessage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winMessage.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(SaveScript.gotVaccine == true)
            {
                winMessage.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
