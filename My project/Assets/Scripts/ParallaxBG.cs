using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxBG : MonoBehaviour
{
    
    Vector2 startpos;
    [SerializeField] int moveModifier;

    // Start is called before the first frame update
    private void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float posX = Mathf.Lerp(transform.position.x, startpos.x + (pos.x + moveModifier), 2f * Time.deltaTime);
        float posY = Mathf.Lerp(transform.position.y, startpos.y + (pos.y + moveModifier), 2f * Time.deltaTime);
        //Mathf.Lerp - linearly interpolates between a and b by t

        transform.position = new Vector3
        (
            posX,
            posY,
            0
        );
    }
}
