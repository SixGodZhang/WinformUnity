using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Forms;
using UnityWinForms.Examples;

public class TestWinform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 例子1：
        //var form = new Form();
        //form.Show();

        // 例子2:
        //MessageBox.Show("Hello World.");

        // 例子3:
        var form = new FormExamples();
        form.Show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
