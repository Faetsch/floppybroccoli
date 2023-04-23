using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpAmount = 8f;
    [SerializeField] UnityEvent onScore;

    private const int MENU_SCENE = 0;

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            rb.velocity = new Vector2(0, jumpAmount);
        }
    }

    /*
     * Erst nachdem der score trigger tatsächlich verlassen wird, gibt es einen Punkt
     */
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            onScore?.Invoke();
        }
    }

    /*
     * Bei Berühren von pipes/floor/ceiling -> Spielneustart
     */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(MENU_SCENE);
    }
}
