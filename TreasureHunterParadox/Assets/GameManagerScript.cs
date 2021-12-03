using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManagerScript : MonoBehaviour
{
    //Timelines
    public PlayableDirector IntroTimeLine;
    public PlayableDirector KickDoorTimeLine;
    public PlayableDirector PushButtonTimeLine;
    public PlayableDirector PreChoiceTwoTimeLine;
    public PlayableDirector KillEveryoneTimeLine;

    //Cameras & Canvases
    public GameObject MainCamera;
    public GameObject OptionOneCamera;
    public GameObject OptionOneCanvas;
    public GameObject AfterFirstChoiceCamera;
    public GameObject PreChoiceTwoCamera;
    public GameObject PreChoiceTwoCanvas;
    public GameObject KillEveryoneCamera;
    public GameObject TreasureCamera;

    //Audioclips
    //get: always have been and its music, BTE for menu, gunshot...

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            IntroTimeLine.Play();
        }
    }

    public void DoShit() {
        //TODO  write stuff here
    }

    public void ChoiceOneInitiate() {
        OptionOneCamera.SetActive(true);
        MainCamera.SetActive(false);
        OptionOneCanvas.SetActive(true);
    }
    public void EnableAfterFirstChoiceCamera() {
        AfterFirstChoiceCamera.SetActive(true);
        OptionOneCamera.SetActive(false);
    }
    public void StartKickDoorTimeLine() {
        OptionOneCanvas.SetActive(false);
        KickDoorTimeLine.Play();
    }
    public void StartPushButtonTimeLine() {
        OptionOneCanvas.SetActive(false);
        PushButtonTimeLine.Play();
    }
    public void StartPreChoiceTwoTimeLine()
    {
        PreChoiceTwoTimeLine.Play();
        PreChoiceTwoCamera.SetActive(true);
        AfterFirstChoiceCamera.SetActive(false);
    }
    public void ChoiceTwoInitiate() {
        PreChoiceTwoCanvas.SetActive(true);
    }
    public void StartKillEveryoneTimeLine() {
        PreChoiceTwoCanvas.SetActive(false);
        KillEveryoneCamera.SetActive(true);
        PreChoiceTwoCamera.SetActive(false);
        PreChoiceTwoTimeLine.Stop();
        KillEveryoneTimeLine.Play();
    }
    public void StartSaveErikaTimeLine(){

    }
    public void EnableTreasureCamera() {
        KillEveryoneCamera.SetActive(false);
        TreasureCamera.SetActive(true);
    }
}
