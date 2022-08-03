using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    GameObject _view;

    private void Start()
    {
        _view = transform.GetChild(0).gameObject;
    }

    public void ShowView()
    {
        _view.SetActive(true);
    }

    public void HideView()
    {
        _view.SetActive(false);
    }
}
