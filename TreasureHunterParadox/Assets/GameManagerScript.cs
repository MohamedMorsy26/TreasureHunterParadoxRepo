using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManagerScript : MonoBehaviour
{
    public PlayableDirector IntroTimeLine;
    public PlayableDirector KickDoorTimeLine;
    public GameObject OptionOneCamera;
    public GameObject MainCamera;
    public GameObject AfterFirstChoiceCamera;
    public GameObject OptionOneCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
}
