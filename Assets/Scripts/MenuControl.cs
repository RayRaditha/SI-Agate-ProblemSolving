using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] private Button menu1;
    [SerializeField] private Button menu2;
    [SerializeField] private Button menu3;
    [SerializeField] private Button menu4;
    [SerializeField] private Button menu5;
    [SerializeField] private Button menu6;
    [SerializeField] private Button menu7;
    [SerializeField] private Button menu8;
    [SerializeField] private Button menu9;

    // Start is called before the first frame update
    void Start()
    {
        menu1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        menu2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        menu3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        menu4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        menu5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        menu6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });

        menu7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        menu8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });

        menu9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
