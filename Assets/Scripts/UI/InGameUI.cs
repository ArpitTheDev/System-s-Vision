using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameUI : UI_Screen
{
    public Button btnPrefab;
    public Button[] buttons;

    Dictionary<int, string> colorData = new Dictionary<int, string>();
    private float padding = 35;

    private void Start()
    {
        colorData.Clear();
        Color_Factory_Method color_Factory_Method = new Color_Factory_Method();
        colorData = color_Factory_Method.GenerateData("TextData").LoadData(); //TextData //JsonData

        buttons = new Button[colorData.Count];

        for (int i = 0; i < colorData.Count; i++)
        {
            int index = i;
            //
            Button btn = (Button)Instantiate(btnPrefab) as Button;

            RectTransform btnRectTransform = btn.GetComponent<RectTransform>();

            btnRectTransform.anchorMin = new Vector2(0f, 1f); // Set the minimum anchor point to (0, 1) - top-left corner of the parent
            btnRectTransform.anchorMax = new Vector2(0f, 1f);

            btn.name = i.ToString();
            //
            btn.onClick.AddListener(() => OnButtonClick(index));
            //
            //btn.transform.parent = transform;
            btnRectTransform.SetParent(transform, false);
            //
            btnRectTransform.anchoredPosition
                = new Vector2(20 + padding * i,
                -100);

            Color color;
            if (UnityEngine.ColorUtility.TryParseHtmlString(colorData[i], out color))
            {
                btn.image.color =  color;
               
            }
            else
            {
                Debug.Log("Failed to parse color.");
            }

            buttons[i] = btn;
        }
    }

    public void OnButtonClick(int i)
    {
        //Debug.Log(buttons[i].image.color);
        EventManager.TriggerSetInputColor(buttons[i].image.color);
    }

    public void OpenMainMenu() 
    {
        SceneManager.LoadScene(0);
    }
}
