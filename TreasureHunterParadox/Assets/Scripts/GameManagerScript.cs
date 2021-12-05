using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

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

    //Cameras & Canvases
    public GameObject MainCamera;
    public GameObject OptionOneCamera;
    public GameObject OptionOneCanvas;
    public GameObject AfterFirstChoiceCamera;
    public GameObject PreChoiceTwoCamera;
    public GameObject PreChoiceTwoCanvas;

    //Audioclips
    //get: always have been and its music, BTE for menu, gunshot...
    public AudioSource MusicPlayer, SFXPlayer;
    public AudioClip MoneyMoney, AlwaysHasBeenMusic, IntroAmongUs, IntroMoveOut,
        FbiOpenUp, AmongUsButton, AmongUsVent, AmongUsStealthKill, AmongUsKill;
    // Start is called before the first frame update
    void Start(){}

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
        AfterFirstChoiceCamera.SetActive(false);
    }
    public void StartKillEveryoneTimeLine() {
        PreChoiceTwoCanvas.SetActive(false);
        PreChoiceTwoCamera.SetActive(false);
        PreChoiceTwoTimeLine.Stop();
        KillEveryoneTimeLine.Play();
    }
    public void StartSaveErikaTimeLine(){

    }
    public void PlayTheMoney() {
        MusicPlayer.PlayOneShot(MoneyMoney);
    }
    public void PlayAlwaysHasBeenMusic() {
        MusicPlayer.PlayOneShot(AlwaysHasBeenMusic);
    }
    public void PlayAmongUsIntro(){
        SFXPlayer.PlayOneShot(IntroAmongUs);
    }
    public void PlayMoveOut() {
        SFXPlayer.PlayOneShot(IntroMoveOut);
    }
    public void PlayFbiOpenUp() {
        SFXPlayer.PlayOneShot(FbiOpenUp);
    }
    public void PlayAmongUsButton() {
        SFXPlayer.PlayOneShot(AmongUsButton);
    }
    public void PlayAmongUsVent() {
        SFXPlayer.PlayOneShot(AmongUsVent);
    }
    public void PlayAmongUsStealthKill() {
        SFXPlayer.PlayOneShot(AmongUsStealthKill);
    }
    public void PlayAmongUsInstaKill() {
        SFXPlayer.PlayOneShot(AmongUsKill);
    }

}
