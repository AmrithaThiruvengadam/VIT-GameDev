using UnityEngine;
using UnityEngine.Networking; 
using System.Collections;

 
public class MyBehaviour : MonoBehaviour {
    void Start() {
        StartCoroutine(GetText());
    }
 
    IEnumerator GetText() {
        UnityWebRequest www = new UnityWebRequest("https://s3-ap-southeast-1.amazonaws.com/cdn.hitwicket.co/sample_user_data.json ");
        www.downloadHandler = new DownloadHandlerBuffer();
        yield return www.SendWebRequest();
 
        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
            Debug.Log(www.downloadHandler.text);
 
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }
}
    }
}
