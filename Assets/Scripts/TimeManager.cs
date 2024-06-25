using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public void StopTime()
    {
        Time.timeScale = 0;
    }

    public void ContinueTime()
    {
        Time.timeScale = 1f;
    }
}
