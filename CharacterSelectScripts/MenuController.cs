using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject buttonPanel, characterSelectPanel, createCharacterPanel;
    private MainMenuCamera mainMenuCamera;


    private void Awake()
    {
        mainMenuCamera = Camera.main.GetComponent<MainMenuCamera>();
    }

    public void PlayGame()
    {
        mainMenuCamera.ChangePosition(1);
        buttonPanel.SetActive(false);
        characterSelectPanel.SetActive(true);
        
    }
    public void BackToMainMenu()
    {
        mainMenuCamera.ChangePosition(0);
        buttonPanel.SetActive(true);
        characterSelectPanel.SetActive(false);
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneLoader.instance.LoadLevel("LevelSelect");
    }

    public void CreateCharacter()
    {
        characterSelectPanel.SetActive(false);
        createCharacterPanel.SetActive(true);
    }
    public void Accept()
    {
        characterSelectPanel.SetActive(true);
        createCharacterPanel.SetActive(false);
    }
    public void Cancel()
    {
        characterSelectPanel.SetActive(true);
        createCharacterPanel.SetActive(false);
    }
}
