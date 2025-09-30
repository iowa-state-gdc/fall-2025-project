using UnityEngine;

public class Player : MonoBehaviour
{
    public void kys()
    {
        gameObject.SetActive(false);
        GameManager.getInstance().stopTime();
    }

    public void resurrect()
    {
        gameObject.SetActive(true);
        GameManager.getInstance().stopTime();
    }
}
