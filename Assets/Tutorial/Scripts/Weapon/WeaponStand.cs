using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WeaponStand : MonoBehaviour
{
public void OnSocketed(SelectEnterEventArgs args)
{
    Debug.Log("OnSocketed triggered");
    var reloadable = args.interactableObject.transform.GetComponent<IReloadable>();
    if (reloadable != null)
    {
        Debug.Log("Reloading started");
        reloadable.StartReload();
    }
    else
    {
        Debug.Log("No IReloadable component found");
    }
}

public void OnUnsocketed(SelectExitEventArgs args)
{
    Debug.Log("OnUnsocketed triggered");
    var reloadable = args.interactableObject.transform.GetComponent<IReloadable>();
    if (reloadable != null)
    {
        Debug.Log("Reloading stopped");
        reloadable.StopReload();
    }
    else
    {
        Debug.Log("No IReloadable component found");
    }
}


}
