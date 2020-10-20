using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    [SerializeField] Text helthText;
    [SerializeField] Text levelText;
    [SerializeField] Text xPosText;
    [SerializeField] Text yPosText;
    [SerializeField] Text zPosText;


    public int helth;
    public int level;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        helth = 0;
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        updateData();
    }

    private void updateData()
    {
        position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        helthText.text = helth.ToString();
        levelText.text = level.ToString();
        xPosText.text = position.x.ToString();
        yPosText.text = position.y.ToString();
        zPosText.text = position.z.ToString();
    }

    public void increseHelth()
    {
        helth++;
    }

    public void increseLevel()
    {
        level++;
    }

    public void decreseHelth()
    {
        helth--;
    }

    public void decreseLevel()
    {
        level--;
    }

    public void loadData()
    {
        GameData data = SaveSystem.LoadGame();
        helth = data.helth;
        level = data.level;
    }

    public void saveData()
    {
     
        SaveSystem.SaveGame(this);
    }
}
