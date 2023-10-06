using UnityEngine;

public class SaveLoadManager : MonoBehaviour, IQuickSaveHandler
{
    private void OnEnable()
    {
        EventBus.Subscribe(this, 2);
    }

    private void OnDisable()
    {
        EventBus.Unsubscribe(this);
    }

    public void HandleQuickSave()
    {
        print("Invoke SaveLoadManager");
    }

    public void HandleQuickLoad()
    {
        print("Invoke Load");
    }
}