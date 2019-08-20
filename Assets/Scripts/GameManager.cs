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
            _levels[3].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[3].GetComponent<CanvasGroup>(), 1f, 2f);
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
            _levels[5].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[5].GetComponent<CanvasGroup>(), 1f, 2f);
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
            _levels[7].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[7].GetComponent<CanvasGroup>(), 1f, 2f);
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
    //Lake2
    public void Boat()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[5].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[5].SetActive(false);
            _levels[6].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[6].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake2
    public void Swim()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[5].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[5].SetActive(false);
            _levels[7].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[7].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake death
    public void CarryOn()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[6].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[6].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Lake death
    public void GoOn()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[7].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[7].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
   

}