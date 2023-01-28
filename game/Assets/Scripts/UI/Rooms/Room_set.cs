using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Room_set : MonoBehaviour
{
    [SerializeField] private TMP_Text _Level;
    [SerializeField] private TMP_Text _XP;
    [SerializeField] private TMP_Text _Money;
    public void ScenLoad(string name)
    {
        SceneManager.LoadScene(name);
    }
}