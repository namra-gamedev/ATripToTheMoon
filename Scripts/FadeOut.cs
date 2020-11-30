using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    public float waitFor;
    Scene scene;

    void Start()
    {
        Fade();
        scene = SceneManager.GetActiveScene();
    }
    public void Fade()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        yield return new WaitForSeconds(waitFor);
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
        SceneManager.LoadScene((scene.buildIndex + 1), LoadSceneMode.Single);
    }

}
