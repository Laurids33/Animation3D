using UnityEngine;

public class MenschBewegen : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        bool GehtVariable = false;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
            GehtVariable = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
        anim.SetBool("GehtParameter", GehtVariable);
    }
}
