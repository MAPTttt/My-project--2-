using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshPro timerText;
    private float timer;
    private bool timerActive;
    
    void Start()
    {
        timerText = GetComponent<TextMeshPro>();
        SceneManager.sceneLoaded += OnSceneLoaded;
        timerActive = true;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "End")
        {
            timerActive = false;
        }
    }

    void Update()
    {
        if(!timerActive) return;
        
        timer += Time.deltaTime;
        
        var minutes = Mathf.FloorToInt(timer / 60);
        var seconds = Mathf.FloorToInt(timer % 60);
        var milliseconds = Mathf.FloorToInt((timer * 1000) % 1000);
        
        timerText.text = $"{minutes:00}:{seconds:00}:{milliseconds:000}";
    }
    
    
}
