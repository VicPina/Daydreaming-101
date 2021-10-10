using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private PlayerController thePlayer;
    public SpriteRenderer TheSR;
    public Sprite DOC;
    public bool dooropen, waiting;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waiting)
        {
            if (Vector3.Distance(thePlayer.followinkey.transform.position,transform.position) <0.1f)
            {
                waiting = false;
                dooropen = true;
                TheSR.sprite = DOC;
                thePlayer.followinkey.gameObject.SetActive(false);
                thePlayer.followinkey = null;
            }
        }

        if (dooropen && Vector3.Distance(thePlayer.transform.position, transform.position)<1f && Input.GetAxis("Vertical") > 0.1f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(thePlayer.followinkey != null)
            {
                thePlayer.followinkey.followTarget = transform;
                waiting = true;
            }
        }
    }
}
