using System.Collections;
using System.Collections.Generic;
using TowerDefense.Game;
using UnityEngine;
using UnityEngine.UI;

public class TemporyUIController : MonoBehaviour {

    public Button btnLoad;
    public Button btnSave;
    public Button btnReset;
    public Button btnStartPause;

    // Use this for initialization
    void Start () {
        btnLoad.onClick.AddListener(OnClickLoad);
        btnSave.onClick.AddListener(OnClickSave);
        btnReset.onClick.AddListener(OnClickReset);
        btnStartPause.onClick.AddListener(OnClickPause);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClickLoad()
    {
        GameManager.instance.LoadData();
    }

    void OnClickSave()
    {
        GameManager.instance.SaveData();
    }

    void OnClickReset()
    {
        GameManager.instance.ResetLevel();
    }
    
    enum Status
    {
        Build,
        Start,
        Pause
    }
    Status currentStatus;
    void OnClickPause()
    {
        if (currentStatus == Status.Pause)
        {
            currentStatus = Status.Start;
            btnStartPause.GetComponentInChildren<Text>().text = "Start";
        }
        else if (currentStatus == Status.Build)
        {
            currentStatus = Status.Start;
            btnStartPause.GetComponentInChildren<Text>().text = "Start";
        }
        else if (currentStatus == Status.Start)
        {
            currentStatus = Status.Pause;
            btnStartPause.GetComponentInChildren<Text>().text = "Pause";
        }

    }
}
