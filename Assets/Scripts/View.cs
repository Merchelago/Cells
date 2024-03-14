using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public Metabolism metabolism;
    public Text textEnergy;

    // Start is called before the first frame update
    void Awake()
    {
        EventBus.OnChangeEnergy.AddListener(() => { textEnergy.text = $"Energy:{metabolism.Energy}"; });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
