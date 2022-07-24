using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace FPSKit
{
    public class GameController : BaseFeature<GameData>
    {

        [SerializeField]
        GameStateMachine _stateMachine;
        [SerializeField]
        GameData _gameData;

        public override GameData Data { get => _gameData; set => _gameData = value; }


        //UpdateGameInfoLoader _gameInfoLoader;
        PlayerInfoLoader _playerInfoLoader;
        //OpponentInfoLoader _opponentInfoLoader;

        void Start()
        {
            StartCoroutine(BootGame());
        }
        public override IEnumerator BootGame()
        {
            Initialization();
            yield return null;
            yield return LoadFeature();
            yield return null;
            BootGame();
            yield return null;
            StartFeature();
        }

        public override void Initialization()
        {
            _stateMachine.InitalizeStates(this);
        }

        public override async Task LoadFeature()
        {
            Debug.Log("Load feature");
            _playerInfoLoader = new PlayerInfoLoader();
            PlayerData data = await _playerInfoLoader.LoadData();
        }

        public override async Task SaveFeature()
        {
                Debug.Log("Save feature");
        }

        public override void StartFeature()
        {
            Debug.Log("Starting feature");
        }

        public override void StopFeature()
        {
            Debug.Log("Stopping feature");
        }
    }
}