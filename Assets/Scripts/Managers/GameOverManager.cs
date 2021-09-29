using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public PlayerHealth playerHealth;
    public bool nowDead;


    Animator anim;                                           
 
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
 
    void Update()
    {
        if (playerHealth.currentHealth <= 0 && !nowDead)
        {
            nowDead = true;
            anim.SetTrigger("GameOver");

            StartCoroutine(wait());

        }
    }
    
 
    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m",Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Level_01");
    }
}