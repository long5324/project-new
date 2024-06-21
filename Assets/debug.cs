
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using static scan_finding;

public class debug : MonoBehaviour
{
    public Vector2 location_check;
    // Update is called once per frame
    public void check_point()
    {
        string arrayJson = new string("");
        arrayJson = PlayerPrefs.GetString("path_findding", string.Empty);
        if(arrayJson=="") {
            Debug.Log("cant read data");
                return;
                }
        data_finding tg_data_finding = !string.IsNullOrEmpty(arrayJson) ? JsonUtility.FromJson<data_finding>(arrayJson) : null;

        foreach (Vector2 tg in tg_data_finding.list_point_wall)
        {
            if (tg == location_check)
            {
                Debug.Log("wall");
                return;
            }
        }

        foreach (point tg in tg_data_finding.points_activiti)
        {
            if(tg.location == location_check)
            {
                Debug.Log("loaction point" + tg.location+ "  "+ tg.state);
                Debug.Log("info_platform" +"  ("+ tg.location_platform.left + "," + tg.location_platform.right +")  "+ "  height" + tg.location_platform.heigh);
                foreach (aim tg_aim in tg.list_aim_point)
                {
                    switch (tg_aim.state_activiti)
                    {
                        case state_activiti.fall:
                            Debug.Log(tg_aim.position_soucre+" fall to " + tg_aim.position_target+" veloxity "+tg_aim.velocity);
                            break;
                        case state_activiti.move:
                            Debug.Log(tg_aim.position_soucre + " move to " + tg_aim.position_target + " veloxity " + tg_aim.velocity);
                            break;
                        case state_activiti.jump:
                            Debug.Log(tg_aim.position_soucre + " jump to " + tg_aim.position_target + " veloxity " + tg_aim.velocity);
                            break;
                    }
                }
                return;
            }

        }


    }
}
