using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    private bool spin;
    private float speed;
    private int[] angle = new int[] { 0, 45, 90, 135, 180, 225, 270, 315, 360 };
    public Text reward_txt;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        spin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spin && speed > 0)
        {
            transform.Rotate(0, 0, speed);
            speed -= .1f;
        }
        if (spin && speed <= 0)//end of speed
        {
            for (int i = 0; i < angle.Length; i++)
            {
                if (transform.rotation.eulerAngles.z == angle[i])
                {
                    transform.Rotate(0, 0, 1);
                    break;
                }
            }
            if (transform.rotation.eulerAngles.z > angle[0] && transform.rotation.eulerAngles.z < angle[1])
                reward_txt.text = "BLUE";
            if (transform.rotation.eulerAngles.z > angle[1] && transform.rotation.eulerAngles.z < angle[2])
                reward_txt.text = "PURPLE";
            if (transform.rotation.eulerAngles.z > angle[2] && transform.rotation.eulerAngles.z < angle[3])
                reward_txt.text = "PINK";
            if (transform.rotation.eulerAngles.z > angle[3] && transform.rotation.eulerAngles.z < angle[4])
                reward_txt.text = "RED";
            if (transform.rotation.eulerAngles.z > angle[4] && transform.rotation.eulerAngles.z < angle[5])
                reward_txt.text = "ORANGE";
            if (transform.rotation.eulerAngles.z > angle[5] && transform.rotation.eulerAngles.z < angle[6])
                reward_txt.text = "YELLOW";
            if (transform.rotation.eulerAngles.z > angle[6] && transform.rotation.eulerAngles.z < angle[7])
                reward_txt.text = "GREEN";
            if (transform.rotation.eulerAngles.z > angle[7] && transform.rotation.eulerAngles.z < angle[0])
                reward_txt.text = "LIGHT BLUE";
            speed = 0;
            spin = false;
        }
    }
    public void spin_button()
    {
        spin = true;
        speed = Random.Range(20, 50);
        reward_txt.text = "Reward";
    }
}
