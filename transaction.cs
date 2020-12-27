using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transaction : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void changeScene(string name) {

        StartCoroutine(transFormScene(name));

    }

    IEnumerator transFormScene(string name) {
        animator.SetTrigger("End");
        yield return new WaitForSeconds(0);
        SceneManager.LoadScene(name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
