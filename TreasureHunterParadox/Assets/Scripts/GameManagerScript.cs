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
    public GameObject OptionOneCanvas;
    public GameObject PreChoiceTwoCamera;
    public GameObject OptionTwoCanvas;

    //Audioclips
    //get: always have been and its music, BTE for menu, gunshot...
    public AudioSource MusicPlayer, SFXPlayer;
    public AudioClip MoneyMoney, AlwaysHasBeenMusic;

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

    }
    public void PlayTheMoney() {
        MusicPlayer.PlayOneShot(MoneyMoney);
    }
    public void PlayAlwaysHasBeenMusic() {
        MusicPlayer.PlayOneShot(AlwaysHasBeenMusic);
    }
}
