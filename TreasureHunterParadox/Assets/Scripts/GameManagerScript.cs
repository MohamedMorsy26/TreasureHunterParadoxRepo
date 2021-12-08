using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    //Timelines
    public PlayableDirector IntroSettingsTimeLine;
    public PlayableDirector IntroTimeLine;
    public PlayableDirector KickDoorTimeLine;
    public PlayableDirector PushButtonTimeLine;
    public PlayableDirector PreChoiceTwoTimeLine;
    public PlayableDirector KillEveryoneTimeLine;
    public PlayableDirector SaveErikaTimeLine;

    //Cameras & Canvases
    public GameObject MainCamera;
    public GameObject SettingsCanvas;
    public GameObject OptionOneCanvas;
    public GameObject OptionTwoCanvas;
    public GameObject RedLight, GreenLight;

    public Light TreasureLight;

    public Text ConversationText;

    bool LightingUp = true;

    void Start() {
        IntroSettingsTimeLine.Play();
    }
    void Update(){
        if (LightingUp)
        {
            TreasureLight.intensity += 0.2f;
            if (TreasureLight.intensity >= 3f) {
                LightingUp = false;
            }
        }
        else {
            TreasureLight.intensity -= 0.2f;
            if (TreasureLight.intensity <= 0.2) {
                LightingUp = true;
            }
        }
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    public void StartIntroTimeLine() {
        IntroSettingsTimeLine.Stop();
        SettingsCanvas.SetActive(false);
        IntroTimeLine.Play();

    }
    public void StartKickDoorTimeLine() {
        IntroTimeLine.Stop();
        KickDoorTimeLine.Play();
        OptionOneCanvas.SetActive(false);
        RedLight.SetActive(false);
        GreenLight.SetActive(false);
    }
    public void StartPushButtonTimeLine() {
        IntroTimeLine.Stop();
        PushButtonTimeLine.Play();
        OptionOneCanvas.SetActive(false);
        RedLight.SetActive(false);
        GreenLight.SetActive(false);
    }
    public void StartPreChoiceTwoTimeLine()
    {
        PreChoiceTwoTimeLine.Play();
    }
    public void StartKillEveryoneTimeLine() {
        PreChoiceTwoTimeLine.Stop();
        OptionTwoCanvas.SetActive(false);
        KillEveryoneTimeLine.Play();
    }
    public void StartSaveErikaTimeLine(){
        PreChoiceTwoTimeLine.Stop();
        OptionTwoCanvas.SetActive(false);
        SaveErikaTimeLine.Play();

    }
    public void WhatAreYouDoing() {
        ConversationText.text = "Erika: What are you doing?!";
    }
    public void DoingWhatIHaveToDo(){
        ConversationText.text = "Kenny: Doing what I have to do";
    }
    public void WaitYouAreATraitor() {
        ConversationText.text = "Erika: Wait, you're a traitor?!";
    }
    public void AlwaysHaveBeen() {
        ConversationText.text = "Kenny: Always have been...";
    }
    public void PhewThatWasClose(){
        ConversationText.text = "Erika: Phew, that was close";
    }
    public void ThankYou() {
        ConversationText.text = "Erika: Thank you";
    }
    public void KennyALittleHelpHere() {
        ConversationText.text = "Erika: Hey, Kenny, a little help here, please?";
    }
    public void DudeComeOn() {
        ConversationText.text = "Erika: Dude, just shoot this thing already!";
    }
}
