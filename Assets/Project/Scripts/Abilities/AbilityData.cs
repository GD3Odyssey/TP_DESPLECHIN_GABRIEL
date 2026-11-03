using UnityEngine;

/// <summary>
/// Définition d'une compétence (données fixes uniquement).
/// Ne contient volontairement AUCUN état d'exécution (cooldown restant, etc.) :
/// cet état est géré par l'AbilityManager, propre à chaque personnage.
/// </summary>
[CreateAssetMenu(fileName = "Ability_New", menuName = "RPG/Ability Data")]
public class AbilityData : ScriptableObject
{
    [Header("Affichage")]
    [SerializeField] private string abilityName = "Nouvelle compétence";
    [SerializeField, TextArea(2, 4)] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private Color effectColor = Color.white;

    [Header("Gameplay")]
    [SerializeField, Min(0f)] private float damage = 10f;
    [SerializeField, Min(0f)] private float cooldown = 2f;
    [SerializeField, Min(0.1f)] private float projectileSpeed = 10f;

    [Header("Effets visuels et animation")]
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject impactPrefab;
    [SerializeField] private string animationTrigger;

    // Accès en lecture seule : les données ne doivent pas être modifiées à l'exécution.
    public string AbilityName => abilityName;
    public string Description => description;
    public Sprite Icon => icon;
    public Color EffectColor => effectColor;
    public float Damage => damage;
    public float Cooldown => cooldown;
    public float ProjectileSpeed => projectileSpeed;
    public GameObject ProjectilePrefab => projectilePrefab;
    public GameObject ImpactPrefab => impactPrefab;
    public string AnimationTrigger => animationTrigger;
}
