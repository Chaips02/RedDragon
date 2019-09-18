using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _levels;
    int crystals = 0;
    int ending = 0;
    //Introduction Video
    public void GoAhead1()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[24].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[24].SetActive(false);
            _levels[0].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[0].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                
                // Añadir aquí instrucciones que queremos que se ejecuten una vez se ha terminado de hacer el fade in (si las hay)
                
            });
        });
    }

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
            _levels[23].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[23].GetComponent<CanvasGroup>(), 1f, 2f);
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
            _levels[50].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[50].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //CrystalForStay
    public void CrystalStay()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[50].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[50].SetActive(false);
            _levels[4].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[4].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {
                crystals++;
                Debug.Log("Crystal For Staying");

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
            _levels[51].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[51].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {

            });
        });
    }
    //Crystal Bramble Forest
    public void CrystalBrambleForest()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[51].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() =>
        {
            _levels[51].SetActive(false);
            _levels[2].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() =>
            {
             crystals++;
                Debug.Log("Crystal Bramble Forest");
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
            _levels[52].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[52].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Crystal Unblock Lock
    public void CrystalUnblockLock()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[17].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[52].SetActive(false);
            _levels[19].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[19].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                crystals++;
                Debug.Log("Crystal Unblock Lock");
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
            _levels[53].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[53].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Crystalx2 Grimori
    public void Crystalx2Grimory()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[53].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[53].SetActive(false);
            _levels[22].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[22].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                crystals ++;
                crystals ++;
                Debug.Log("Crystalx2 Grimori");
                if (crystals == 2)
                {
                    Debug.Log("QUE GUAI DKJSGFHJMNAFRBKHJB");
                }
            });
        });
    }


    //Lake3
    public void ContinueAdventure()
    {

        ending++;
        if (ending == 2)
        {
            if (crystals == 8)
            {
                Debug.Log("YOU WIN!");
                    }
            else
            {
                Debug.Log("YOU LOSE!");
                    }
        }
        else
        {
            LTDescr fadeOut = LeanTween.alphaCanvas(_levels[22].GetComponent<CanvasGroup>(), 0f, 2f);
            fadeOut.setOnComplete(() => {
                _levels[22].SetActive(false);
                _levels[1].SetActive(true);
                LTDescr fadeIn = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 1f, 2f);
                fadeIn.setOnComplete(() => {
                    Debug.Log("Go to the mountain");





                });
            });
        }
    }
    //MountainSourrandings
    public void ExploreSourrandings()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[23].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[23].SetActive(false);
            _levels[25].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[25].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainSourrandings
    public void YesMS()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[25].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[25].SetActive(false);
            _levels[26].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[26].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainSourrandings
    public void OfCourse()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[2].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[26].SetActive(false);
            _levels[27].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[27].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }

    //MountainSourrandings
    public void R1MS()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[27].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[27].SetActive(false);
            _levels[28].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[28].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }

    //MountainSourrandings
    public void R2MS()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[27].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[27].SetActive(false);
            _levels[29].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[29].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }

    //MountainSourrandings
    public void NoMS()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[25].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[25].SetActive(false);
            _levels[30].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[30].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainSourrandings
    public void SorryNo()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[26].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[26].SetActive(false);
            _levels[30].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[30].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainSourrandings
    public void Cave()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[28].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[28].SetActive(false);
            _levels[54].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[54].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //CrystalEnigma
    public void CrystalEnigma()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[54].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[54].SetActive(false);
            _levels[30].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[30].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                crystals++;
                Debug.Log("CrystalEnigma");

            });
        });
    }


    //MountainSourrandings
    public void Cave2()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[29].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[29].SetActive(false);
            _levels[30].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[30].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainSourrandings
    public void Lectern()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[30].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[30].SetActive(false);
            _levels[31].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[31].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainSourrandings
    public void GoMountain()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[31].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[31].SetActive(false);
            _levels[23].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[23].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void GoTop()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[23].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[23].SetActive(false);
            _levels[32].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[32].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Stairs()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[32].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[32].SetActive(false);
            _levels[33].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[33].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void GoBack()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[33].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[33].SetActive(false);
            _levels[32].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[32].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Jump()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[33].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[33].SetActive(false);
            _levels[34].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[34].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void StairsDeath()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[34].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[34].SetActive(false);
            _levels[32].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[32].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Climbing()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[32].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[32].SetActive(false);
            _levels[35].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[35].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void BackOff()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[35].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[35].SetActive(false);
            _levels[32].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[32].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void KeepClimbing()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[35].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[35].SetActive(false);
            _levels[36].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[36].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void KeepExploring()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[36].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[36].SetActive(false);
            _levels[37].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[37].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
//MountainTop
    public void GoSee()
{
    LTDescr fadeOut = LeanTween.alphaCanvas(_levels[36].GetComponent<CanvasGroup>(), 0f, 2f);
    fadeOut.setOnComplete(() => {
        _levels[36].SetActive(false);
        _levels[39].SetActive(true);
        LTDescr fadeIn = LeanTween.alphaCanvas(_levels[39].GetComponent<CanvasGroup>(), 1f, 2f);
        fadeIn.setOnComplete(() => {

        });
    });
}
//MountainTop
public void RunAway()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[37].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[37].SetActive(false);
            _levels[39].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[39].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Chat()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[37].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[37].SetActive(false);
            _levels[38].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[38].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void DoIt()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[38].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[38].SetActive(false);
            _levels[23].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[23].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Ignore()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[38].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[38].SetActive(false);
            _levels[39].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[39].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void GetIn()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[39].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[39].SetActive(false);
            _levels[49].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[49].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    public void CrystalPantheon()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[49].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[49].SetActive(false);
            _levels[40].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[40].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                crystals++;
                Debug.Log("CrystalPantheon");


            });
        });
    }

    //MountainTop
    public void GoDown()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[40].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[40].SetActive(false);
            _levels[41].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void StaurnPicture()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[41].SetActive(false);
            _levels[42].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[42].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void InscriptionInWall()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[41].SetActive(false);
            _levels[43].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[43].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void GreekMithologyBook()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[41].SetActive(false);
            _levels[44].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[44].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Hourglass()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[41].SetActive(false);
            _levels[45].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[45].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Chest()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[41].SetActive(false);
            _levels[46].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[46].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Next1()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[43].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[43].SetActive(false);
            _levels[41].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Next2()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[43].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[43].SetActive(false);
            _levels[41].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Next3()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[44].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[44].SetActive(false);
            _levels[41].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void Next4()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[45].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[45].SetActive(false);
            _levels[41].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void CheckChamber()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[46].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[46].SetActive(false);
            _levels[41].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[41].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void R1MT()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[46].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[46].SetActive(false);
            _levels[47].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[47].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //MountainTop
    public void R2MT()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[46].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[46].SetActive(false);
            _levels[48].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[48].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {

            });
        });
    }
    //Open chest
    public void EndMountain()
    {
        LTDescr fadeOut = LeanTween.alphaCanvas(_levels[47].GetComponent<CanvasGroup>(), 0f, 2f);
        fadeOut.setOnComplete(() => {
            _levels[47].SetActive(false);
            _levels[55].SetActive(true);
            LTDescr fadeIn = LeanTween.alphaCanvas(_levels[55].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                ending++;
                Debug.Log("Muntanya");
            });
        });
    }
    //Charm
    public void Charm()
    {
        crystals++;
        Debug.Log("Charm");
        if (ending == 1)
        {
            LTDescr fadeOut = LeanTween.alphaCanvas(_levels[55].GetComponent<CanvasGroup>(), 0f, 2f);
            fadeOut.setOnComplete(() => {
                _levels[55].SetActive(false);
                _levels[1].SetActive(true);
                LTDescr fadeIn = LeanTween.alphaCanvas(_levels[1].GetComponent<CanvasGroup>(), 1f, 2f);
                fadeIn.setOnComplete(() => {
                    Debug.Log("Go to the lake");
                });
            });
        }

        else
        /*{
            Debug.Log("You a loser");
        }*/
        {
            if (crystals == 8) { 
            LTDescr fadeOut = LeanTween.alphaCanvas(_levels[55].GetComponent<CanvasGroup>(), 0f, 2f);
            fadeOut.setOnComplete(() => {
            _levels[55].SetActive(false);
            _levels[0].SetActive(true);
             LTDescr fadeIn = LeanTween.alphaCanvas(_levels[0].GetComponent<CanvasGroup>(), 1f, 2f);
            fadeIn.setOnComplete(() => {
                Debug.Log("You win");
                });
            });
            }
            else
            {
                LTDescr fadeOut = LeanTween.alphaCanvas(_levels[55].GetComponent<CanvasGroup>(), 0f, 2f);
                fadeOut.setOnComplete(() => {
                    _levels[55].SetActive(false);
                    _levels[0].SetActive(true);
                    LTDescr fadeIn = LeanTween.alphaCanvas(_levels[0].GetComponent<CanvasGroup>(), 1f, 2f);
                    fadeIn.setOnComplete(() => {
                        Debug.Log("You lose");
                    });
                });
            }
        }



    }


}
