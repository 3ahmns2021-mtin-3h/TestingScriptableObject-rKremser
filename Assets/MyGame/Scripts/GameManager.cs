using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    private InputField userName;
    private TextMeshProUGUI loadedName;

    public NameData nameData;
    public LoadScene loadScene;


    void Start()
    {
        userName = FindObjectOfType<InputField>();
    }

    

    public void SaveName()
    {
        nameData.name = "NameData";
        nameData.yourName = userName.text;
        loadScene.LoadNextScene();

    }

    public void LoadName()
    {
        if(loadedName == null)
        {
            loadedName = GameObject.Find("LoadedName").GetComponent<TextMeshProUGUI>();
        }
        loadedName.text = nameData.yourName;
    }
}
