using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider lengthSlider;
    public Slider widthSlider;
    public Slider heightSlider;
    
    public GameObject lengthTextObject;
    public GameObject widthTextObject;
    public GameObject heightTextObject;
    public GameObject volumeTextObject;
    public GameObject edgeLengthTextObject;

    private TextMeshProUGUI lengthText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }
    private TextMeshProUGUI edgeLengthText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        edgeLengthText = edgeLengthTextObject.GetComponent<TextMeshProUGUI>();

        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        lengthText.text = "Cube Length: " + myCube.GetLength().ToString();
        widthText.text = "Cube Width: " + myCube.GetWidth().ToString();
        heightText.text = "Cube Height: " + myCube.GetHeight().ToString();
        volumeText.text = "Cube Volume: " + myCube.GetVolume().ToString();
        edgeLengthText.text = "Cube Edge Length: " + myCube.GetEdgeLength().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetLength(lengthSlider.value);
        myCube.SetWidth(widthSlider.value);
        myCube.SetHeight(heightSlider.value);
    }
}
