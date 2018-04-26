using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour {
    public Canvas Esc;
    public Canvas death;
    // Use this for initialization
    void Start () {
        Esc.enabled = false;
        death.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Esc.enabled = true;
            Time.timeScale = 0;
        }
    }
    public void Load(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void paly()
    {
        GM.isActive = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void NoPress()
    {
        Esc.enabled = false;
        Time.timeScale = 1;
    }
    public void NoPress1()
    {
        Esc.enabled = false;
        Time.timeScale = 1;
        GM.isActive = false;
    }
}
