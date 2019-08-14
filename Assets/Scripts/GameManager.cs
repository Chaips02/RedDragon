using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _levels;

    //Start Scene
    public void GoAhead()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[0].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[0].SetActive(false);
            _levels[1].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                // Añadir aquí instrucciones que queremos que se ejecuten una vez se ha terminado de hacer el fade in (si las hay)
            });
        });
    }

    // Level 1
    public void OptionA()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[1].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                
            });
        });
    }

    // Level 1
    public void OptionB()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[1].SetActive(false);
            _levels[3].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[3].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                
            });
        });
    }
}