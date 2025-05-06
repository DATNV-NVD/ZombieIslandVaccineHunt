using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingScreenBarSystem : MonoBehaviour {

    
       AsyncOperation async;
       public GameObject loadingScreenText;
       public GameObject creditsMessage;

       public void CreditsOn()
       {
            creditsMessage.SetActive(true);
       }

       public void CreditsOff()
       {
            creditsMessage.SetActive(false);
       }
    
        public void ExitGame()
        {
            Application.Quit();
        }


    public void loadingScreen (int sceneNo)
    {
        loadingScreenText.gameObject.SetActive(true);
        StartCoroutine(WaitToLoad(sceneNo));
        
    }

    private void Start()
    {
        creditsMessage.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = true;
    }
    IEnumerator WaitToLoad (int sceneNo)
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(Loading(sceneNo));
    }


    IEnumerator Loading (int sceneNo)
    {
        async = SceneManager.LoadSceneAsync(sceneNo);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
            
            if (async.progress == 0.9f)
            {
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

}
