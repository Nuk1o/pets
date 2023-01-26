using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Player_game;
using TMPro;

public class Room_set : MonoBehaviour
{
    [SerializeField] private TMP_Text _Level;
    [SerializeField] private TMP_Text _XP;
    [SerializeField] private TMP_Text _Money;
    private void Start()
    {
        Player_game.test player_res = new test();
        player_res.lvl = 4;
        player_res.xp = 200;
        player_res.money = 1337;
        
        _Level.text = player_res.lvl.ToString();
        _XP.text = player_res.xp.ToString();
        _Money.text = player_res.money.ToString();
    }

    public void ScenLoad(string name)
    {
        SceneManager.LoadScene(name);
    }
}