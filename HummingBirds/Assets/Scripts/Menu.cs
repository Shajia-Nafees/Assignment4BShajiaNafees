using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void Penguin()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void Hummingbird()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
}