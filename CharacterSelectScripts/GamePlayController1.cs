using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController1 : MonoBehaviour
{
   public void LoadOtherLevels()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        SceneLoader.instance.LoadLevel(name);
    }
}
