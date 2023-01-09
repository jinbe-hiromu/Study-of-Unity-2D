using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public bool IsTimeup = false;
    private GameObject _txtTimer;
    private GameObject _txtPoint;
    private GameObject _txtTimeup;
    private GameObject _btnRetry;
    private float _time = 30.0f;
    private int _point = 0;

    // Start is called before the first frame update
    void Start()
    {
        _txtTimer = GameObject.Find("Time");
        _txtPoint = GameObject.Find("Score");
        _txtTimeup = GameObject.Find("Timeup");
        _btnRetry = GameObject.Find("Retry");
        _btnRetry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_time >= 0)
        {
            _time -= Time.deltaTime;        // ‘O‰ñƒtƒŒ[ƒ€‚©‚ç‚Ì·•ª
            _txtTimer.GetComponent<TextMeshProUGUI>().text = _time.ToString("F1");
            _txtPoint.GetComponent<TextMeshProUGUI>().text = "Score: " +_point.ToString();
        }
        else
        {
            _txtTimeup.GetComponent<TextMeshProUGUI>().text = "Timeup!";
            _btnRetry.SetActive(true);
            IsTimeup = true;
        }
    }

    public void AddScore(int score)
    {
        _point += score;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
