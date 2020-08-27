using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ChatController : MonoBehaviour
{
    public Text text;
    public Text text1;
    int a = 0;
    int b = 0;
    int d = 0;
    string[] lines;
    string testText = "";

    void SpliterSon(int num1) {
        string[] words = lines[num1].Split('/');
        text1.text = words[0];
        if (testText.Length != words[1].Length) {
            foreach(var c in words[1]) {
                testText += c;
                text.text = testText;
            }
        } else {
            return;
        }
    }

    IEnumerator SpliterSon1(int num1) {
        string[] words = lines[num1].Split('/');
        text1.text = words[0];
        if (testText.Length != words[1].Length) {
            foreach(var c in words[1]) {
                testText += c;
                text.text = testText;
                yield return new WaitForSeconds(0.1f);
            }
        } else {
            yield return null;
        }
    }

    void Spliter(int num) { // lines의 a번째 줄을 긁어와 구분하는 함수
        if (d == 0) {
            StartCoroutine(SpliterSon1(num));
        }
    }

    void Start()
    {
        lines = File.ReadAllLines("Assets/Test.txt");
    }

    // Update is called once per frame
    void Update()
    {
        if (a == b) {
            Spliter(a);
            a++; //b++필요
            d++;
        }

        if (Input.GetMouseButtonDown(0)) {
            testText = "";
            b++;
            d = 0;
        }
        
    }
}
////////////////////////////////////////////////