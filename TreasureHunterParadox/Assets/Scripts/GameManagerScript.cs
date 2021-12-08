using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    //TODO
    //Save Erika Timeline, conversations fel canvas, buttons shaklaha 3edel, function el maain menu button
    //add minecraft zombie sound, zaghrootet shakira, Wilhelm Scream, 

    //Timelines
    public PlayableDirector IntroTimeLine;
    public PlayableDirector KickDoorTimeLine;
    public PlayableDirector PushButtonTimeLine;
    public PlayableDirector PreChoiceTwoTimeLine;
    public PlayableDirector KillEveryoneTimeLine;
    public PlayableDirector SaveErikaTimeLine;

    //Cameras & Canvases
    public GameObject MainCamera;
    public GameObject OptionOneCanvas;
    public GameObject OptionTwoCanvas;

    public Text ConversationText;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            IntroTimeLine.Play();
        }
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    public void StartKickDoorTimeLine() {
        IntroTimeLine.Stop();
        KickDoorTimeLine.Play();
        OptionOneCanvas.SetActive(false);
    }
    public void StartPushButtonTimeLine() {
        IntroTimeLine.Stop();
        PushButtonTimeLine.Play();
        OptionOneCanvas.SetActive(false);

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
