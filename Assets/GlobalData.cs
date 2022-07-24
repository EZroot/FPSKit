using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static GlobalData Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField]
    bool _saveGame;

    [SerializeField]
    bool _loadGame;

    [SerializeField]
    bool _showMenu;

    [SerializeField]
    bool _playGame;

    public bool ShowMenuBool { get => _showMenu; set => _showMenu = value; }
    public bool SaveGameBool { get => _saveGame; set => _saveGame = value; }
    public bool LoadGameBool { get => _loadGame; set => _loadGame = value; }
    public bool PlayGame { get => _playGame; set => _playGame = value; }
}
