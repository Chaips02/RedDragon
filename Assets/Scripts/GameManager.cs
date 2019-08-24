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
    public void GoLakeL1()
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
    public void GoMountL1()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[1].SetActive(false);
            _levels[14].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[14].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                
            });
        });
    }

    //Lake
    public void GoLeft()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[2].SetActive(false);
            _levels[3].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[3].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });

    }

    //Lake
    public void GoMid()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[2].SetActive(false);
            _levels[10].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[10].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }

    //Lake
    public void GoRight()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[2].SetActive(false);
            _levels[13].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[13].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });

    }
    //Lake1
    public void Leave()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[3].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[3].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake1
    public void Stay()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[3].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[3].SetActive(false);
            _levels[4].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[4].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void Force()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[4].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[4].SetActive(false);
            _levels[5].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[5].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //LakeDeath
    public void Continue()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[5].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[5].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void PlayDead()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[4].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[4].SetActive(false);
            _levels[6].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[6].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void R2()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[6].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[6].SetActive(false);
            _levels[7].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[7].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void SayBye()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[7].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[7].SetActive(false);
            _levels[8].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[8].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void Ok()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[8].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[8].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void R1()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[6].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[6].SetActive(false);
            _levels[9].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[9].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake1
    public void Thanks()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[9].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[9].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Lake2
    public void Boat()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[10].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[10].SetActive(false);
            _levels[11].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[11].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake2
    public void Swim()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[10].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[10].SetActive(false);
            _levels[12].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[12].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake death
    public void CarryOn()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[11].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[11].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake death
    public void GoOn()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[12].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[12].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Walk()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[13].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[13].SetActive(false);
            _levels[14].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[14].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Home()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[14].GetComponent<CanvasGroup>(), 0f, 2f);
    fadeOut.setOnComplete(() => {
            _levels[14].SetActive(false);
    _levels[2].SetActive(true);
    LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
    fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Stop()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[13].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[13].SetActive(false);
            _levels[15].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[15].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void HomeRitire()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[16].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[16].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Lock()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[15].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[15].SetActive(false);
            _levels[17].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[17].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void WA()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[17].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[17].SetActive(false);
            _levels[18].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[18].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Next()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[18].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[18].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void RA()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[17].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[17].SetActive(false);
            _levels[19].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[19].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Yes()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[19].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[19].SetActive(false);
            _levels[20].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[20].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Oh()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[20].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[20].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }

    //Lake3
    public void No()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[19].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[19].SetActive(false);
            _levels[21].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[21].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void NoLeveIt()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[21].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[21].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void Sure()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[21].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[21].SetActive(false);
            _levels[22].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[22].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake3
    public void ContinueAdventure()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[22].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[22].SetActive(false);
            _levels[1].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
}