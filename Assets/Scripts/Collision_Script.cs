using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System.Xml.Serialization;

public class Collision_Script : MonoBehaviour
{
    // Audio sources and UI elements
    public AudioSource gamemusic;
    public AudioSource keyaudio;
    public AudioSource itempickupaudio;
    public AudioSource needkeyaudio;
    public AudioSource dooropenaudio;
    public GameObject NeedKeyText;

    public bool keycollected = false; // Tracks if the key is collected

    // Snowball management
    public int currentSnowballs = 0;
    public GameObject snowballPrefab;
    public float throwForce = 5f;

    public TextMeshProUGUI snowballText;

    public Battery_Control_Script batteryControlScript;

    public Animator hand;

    void Start()
    {
        batteryControlScript = GetComponent<Battery_Control_Script>();
        UpdateSnowballText();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) // Check for snowball throw input
        {
            ThrowSnowball();
        }
    }

    void ThrowSnowball()
    {
        // Handles the snowball throwing mechanic
        if (currentSnowballs >= 1)
        {
            Transform cameraTransform = Camera.main.transform;
            GameObject snowball = Instantiate(snowballPrefab, cameraTransform.position + cameraTransform.forward, Quaternion.identity);

            Rigidbody x = snowball.GetComponent<Rigidbody>();
            if (x != null)
            {
                x.AddForce(cameraTransform.forward * throwForce, ForceMode.Impulse);
            }
            currentSnowballs--;
            hand.SetTrigger("throw");
            hand.SetTrigger("idle");
            UpdateSnowballText();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        // Handles various object interactions
        if (other.gameObject.tag == "key")
        {
            Destroy(other.gameObject);
            hand.SetTrigger("collect");
            hand.SetTrigger("idle");
            keycollected = true;
            keyaudio.Play();
        }

        if (other.gameObject.tag == "door" && keycollected == true)
        {
            dooropenaudio.Play();
            hand.SetTrigger("open");
            hand.SetTrigger("idle");
            other.gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            Invoke("WinScene", 1f);
        }

        if (other.gameObject.tag == "door" && keycollected == false)
        {
            NeedKeyText.SetActive(true);
            needkeyaudio.Play();
            StartCoroutine(NeedKeyTextBreak());
        }

        if (other.gameObject.tag == "snowball")
        {
            Destroy(other.gameObject);
            hand.SetTrigger("collect");
            hand.SetTrigger("idle");
            currentSnowballs++;
            UpdateSnowballText();
            itempickupaudio.Play();
        }

        if (other.gameObject.tag == "ghost")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
        }

        if (other.gameObject.tag == "battery")
        {
            Debug.Log("Battery Collected");
            Destroy(other.gameObject);
            hand.SetTrigger("collect");
            hand.SetTrigger("idle");
            itempickupaudio.Play();
            batteryControlScript.playerBatteryLife++;
            batteryControlScript.batteryProgressUI.fillAmount = (float)batteryControlScript.playerBatteryLife / (float)batteryControlScript.maxBatteryLife;
        }
    }

    public void WinScene()
    {
        SceneManager.LoadScene(2);
    }

    IEnumerator NeedKeyTextBreak()
    {
        // Hides "Need Key" text after a delay
        yield return new WaitForSeconds(3);
        NeedKeyText.SetActive(false);
    }

    void UpdateSnowballText()
    {
        snowballText.text = "Snowballs: " + currentSnowballs;
    }
}
