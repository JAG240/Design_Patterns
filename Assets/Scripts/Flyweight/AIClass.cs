using UnityEngine;

[CreateAssetMenu(fileName = "AI Class", menuName =  "AI Class")]
public class AIClass : ScriptableObject
{
    public enum Team { human, monster }

    [SerializeField] Team _team;
    [SerializeField] float _maxHealth;
    [SerializeField] Material[] _materials = new Material[3];

    public Team team { get; private set; }
    public float maxHealth { get; private set; }
    public Material[] materials { get; private set; }

    private void OnEnable()
    {
        team = _team;
        maxHealth = _maxHealth;
        materials = _materials;
    }
}