using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MainMenu : MonoBehaviour {


    Scene scene;
    public AudioSource audioSource;
    // Use this for initialization
      void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void StartGame()
    {
        Debug.Log("start game "); //start game
        //first load next scene 
        SceneManager.LoadScene(scene.buildIndex + 1); //load next scene
    }
 
    public void QuitGame()
    {
        Debug.Log(" quit game "); //quit  game
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif

    }
    private bool IsMouseOverUI()
    {
        Debug.Log("");
        return EventSystem.current.IsPointerOverGameObject();
    }
    void Update()
    {
        if (IsMouseOverUI())
        {
            foreach (GameObject go in new PointerEventData(EventSystem.current).hovered)
                print(go.name);
        }
    }

    public void OptionMenu(Canvas canvas2)
    {
        canvas2.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

}
