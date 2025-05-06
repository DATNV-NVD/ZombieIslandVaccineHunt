using UnityEngine;

public class BeginScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0.0f;
        Cursor.visible = true;
    }

    public void Begin()
    {
        Time.timeScale = 1.0f;
        Cursor.visible = false;
        Destroy(gameObject);
    }
    
}
