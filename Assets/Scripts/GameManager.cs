using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private GameManager()
    {
        if(!instance)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Multiple Game Managers in the scene!");
        }
    }
    
    public static GameManager getInstance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
        return instance;
    }

    public void stopTime()
    {
        Time.timeScale = 0;
    }

    public void startTime()
    {
        Time.timeScale = 1;
    }
}
