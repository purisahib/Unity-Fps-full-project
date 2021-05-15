using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject charPosition;

    private int sharp_Shooter1_Index = 0;
    private int sharp_Shooter2_Index = 1;
    private int sharp_Shooter3_Index = 2;
    void Start()
    {
        characters[sharp_Shooter1_Index].SetActive(true);
        characters[sharp_Shooter1_Index].transform.position = charPosition.transform.position;
    }


    public void SelectCharacter()
    {
        int index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);


        TurnOffCharacters();

        characters[index].SetActive(true);
        characters[index].transform.position = charPosition.transform.position;

        GameManager.instance.selectedCharacter = index;

    }
    // Update is called once per frame

        void TurnOffCharacters()
    {
        for(int i = 0; i< characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
    }
    void Update()
    {
        
    }
}
