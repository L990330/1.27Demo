using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reverse : MonoBehaviour
{
    public InputField input;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() =>
        {
            if (input.text != "")
            {
                Rever(input.text);
            }
        });
    }
    string Rever(string str)
    {
        string arr = str;
        string newstr = string.Empty;
        while (str.Contains(",") || str.Contains("."))
        {
            int d = str.IndexOf(',');
            int j = str.IndexOf('.');
            int a = d < j ? d : j;
            if (d == -1)
            {
                a = j;
            }
            if (j == -1)
            {
                a = d;
            }
            for (int i = a - 1; i >= 0; i--)
            {
                newstr += str[i];
            }
            newstr += str[a];
            str = str.Remove(0, a + 1);
        }
        print("输入：" + arr + "输出：" + newstr);
        input.text = newstr;
        return newstr;
    }
}
