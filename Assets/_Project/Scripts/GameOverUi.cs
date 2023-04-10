using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUi : MonoBehaviour
{
    public static GameOverUi Instance { get; private set; }

    public Text TimeSpent;
    public Text TargetDestroyed;

    private void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    public void Display()
    {
        gameObject.SetActive(true);
        GameSystem.Instance.StopTimer();
        Controller.Instance.DisplayCursor(true);

        float time = GameSystem.Instance.RunTime;
        int targetDestroyed = GameSystem.Instance.DestroyedTarget;
        int totalTarget = GameSystem.Instance.TargetCount; //ar trebui sa arate 11 nu 9, problema e in gamesystem

        TargetDestroyed.text = targetDestroyed + "/" + totalTarget;
        TimeSpent.text = time.ToString("N2") + "s";
    }

}
