using UnityEngine;

public class HeroBattleController : MonoBehaviour
{
    [SerializeField] Transform[] heroContainers;

    private void Awake()
    {
        SetHeroes();
    }

    void SetHeroes()
    {
        for (int i = 0; i < HeroManager.SelectedHeroes.Count; i++)
        {
            Debug.Log(HeroManager.SelectedHeroes[i]);
            Instantiate(Resources.Load(HeroManager.SelectedHeroes[i]), heroContainers[i]);
        }
    }
}