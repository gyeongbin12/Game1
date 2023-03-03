using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleButton : CreateButton
{

    private List<GameObject> button = new List<GameObject>();

    void Start()
    {
        Create(3, "Button (Legacy)");

        button[0].GetComponent<Button>().onClick.AddListener(Function1);
        button[1].GetComponent<Button>().onClick.AddListener(Function2);
        button[2].GetComponent<Button>().onClick.AddListener(Function3);
    }

    public override void Create(int createCount, string buttonName)
    {
        for(int i = 0; i < createCount; i++)
        {
            GameObject buttonPreFab = Instantiate(Resources.Load<GameObject>(buttonName));

            button.Add(buttonPreFab);

            button[i].transform.SetParent(parentPosition);
        }
    }

    public override void Function1()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public override void Function2()
    {
        Debug.Log("Fuction 2 »£√‚");
        SoundManager.Instance.Sound();
    }

    public override void Function3()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
