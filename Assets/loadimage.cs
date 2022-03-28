using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class loadimage : MonoBehaviour
{
    public RawImage clima;
    public string url = "https://w.bookcdn.com/weather/picture/32_50060_1_4_2bcc71_250_24ae60_ffffff_ffffff_1_2071c9_ffffff_0_6.png?scode=124&domid=582&anc_id=56833";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadImageToUnity());
    }

    public IEnumerator LoadImageToUnity()
    {

        WWW W = new WWW(url);
        yield return W;
        Texture2D te = W.texture;
        clima.texture = te;



    }
    // Update is called once per frame

}
