using System.Text.Json.Serialization;

namespace PokeApi.Client.Responses
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public partial class PokeApiGetPokemonResponse
    {
        [JsonPropertyName("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonPropertyName("base_experience")]
        public long BaseExperience { get; set; }

        [JsonPropertyName("cries")]
        public Cries Cries { get; set; }

        [JsonPropertyName("forms")]
        public List<Species> Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public List<GameIndex> GameIndices { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("held_items")]
        public List<object> HeldItems { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("location_area_encounters")]
        public Uri LocationAreaEncounters { get; set; }

        [JsonPropertyName("moves")]
        public List<Move> Moves { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("past_abilities")]
        public List<object> PastAbilities { get; set; }

        [JsonPropertyName("past_types")]
        public List<object> PastTypes { get; set; }

        [JsonPropertyName("species")]
        public Species Species { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("stats")]
        public List<Stat> Stats { get; set; }

        [JsonPropertyName("types")]
        public List<TypeElement> Types { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }
    }

    public partial class Ability
    {
        [JsonPropertyName("ability")]
        public Species AbilityAbility { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("slot")]
        public long Slot { get; set; }
    }

    public partial class Species
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public partial class Cries
    {
        [JsonPropertyName("latest")]
        public Uri Latest { get; set; }

        [JsonPropertyName("legacy")]
        public Uri Legacy { get; set; }
    }

    public partial class GameIndex
    {
        [JsonPropertyName("game_index")]
        public long GameIndexGameIndex { get; set; }

        [JsonPropertyName("version")]
        public Species Version { get; set; }
    }

    public partial class Move
    {
        [JsonPropertyName("move")]
        public Species MoveMove { get; set; }

        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }

    public partial class VersionGroupDetail
    {
        [JsonPropertyName("level_learned_at")]
        public long LevelLearnedAt { get; set; }

        [JsonPropertyName("move_learn_method")]
        public Species MoveLearnMethod { get; set; }

        [JsonPropertyName("version_group")]
        public Species VersionGroup { get; set; }
    }

    public partial class GenerationV
    {
        [JsonPropertyName("black-white")]
        public Sprites BlackWhite { get; set; }
    }

    public partial class GenerationIv
    {
        [JsonPropertyName("diamond-pearl")]
        public Sprites DiamondPearl { get; set; }

        [JsonPropertyName("heartgold-soulsilver")]
        public Sprites HeartgoldSoulsilver { get; set; }

        [JsonPropertyName("platinum")]
        public Sprites Platinum { get; set; }
    }

    public partial class Versions
    {
        [JsonPropertyName("generation-i")]
        public GenerationI GenerationI { get; set; }

        [JsonPropertyName("generation-ii")]
        public GenerationIi GenerationIi { get; set; }

        [JsonPropertyName("generation-iii")]
        public GenerationIii GenerationIii { get; set; }

        [JsonPropertyName("generation-iv")]
        public GenerationIv GenerationIv { get; set; }

        [JsonPropertyName("generation-v")]
        public GenerationV GenerationV { get; set; }

        [JsonPropertyName("generation-vi")]
        public Dictionary<string, Home> GenerationVi { get; set; }

        [JsonPropertyName("generation-vii")]
        public GenerationVii GenerationVii { get; set; }

        [JsonPropertyName("generation-viii")]
        public GenerationViii GenerationViii { get; set; }
    }

    public partial class Other
    {
        [JsonPropertyName("dream_world")]
        public DreamWorld DreamWorld { get; set; }

        [JsonPropertyName("home")]
        public Home Home { get; set; }

        [JsonPropertyName("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }

        [JsonPropertyName("showdown")]
        public Sprites Showdown { get; set; }
    }

    public partial class Sprites
    {
        [JsonPropertyName("back_default")]
        public Uri BackDefault { get; set; }

        [JsonPropertyName("back_female")]
        public object BackFemale { get; set; }

        [JsonPropertyName("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("other")]
        public Other Other { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("versions")]
        public Versions Versions { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("animated")]
        public Sprites Animated { get; set; }
    }

    public partial class GenerationI
    {
        [JsonPropertyName("red-blue")]
        public RedBlue RedBlue { get; set; }

        [JsonPropertyName("yellow")]
        public RedBlue Yellow { get; set; }
    }

    public partial class RedBlue
    {
        [JsonPropertyName("back_default")]
        public Uri BackDefault { get; set; }

        [JsonPropertyName("back_gray")]
        public Uri BackGray { get; set; }

        [JsonPropertyName("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_gray")]
        public Uri FrontGray { get; set; }

        [JsonPropertyName("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

    public partial class GenerationIi
    {
        [JsonPropertyName("crystal")]
        public Crystal Crystal { get; set; }

        [JsonPropertyName("gold")]
        public Gold Gold { get; set; }

        [JsonPropertyName("silver")]
        public Gold Silver { get; set; }
    }

    public partial class Crystal
    {
        [JsonPropertyName("back_default")]
        public Uri BackDefault { get; set; }

        [JsonPropertyName("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonPropertyName("back_shiny_transparent")]
        public Uri BackShinyTransparent { get; set; }

        [JsonPropertyName("back_transparent")]
        public Uri BackTransparent { get; set; }

        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonPropertyName("front_shiny_transparent")]
        public Uri FrontShinyTransparent { get; set; }

        [JsonPropertyName("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

    public partial class Gold
    {
        [JsonPropertyName("back_default")]
        public Uri BackDefault { get; set; }

        [JsonPropertyName("back_shiny")]
        public Uri BackShiny { get; set; }

        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("front_transparent")]
        public Uri FrontTransparent { get; set; }
    }

    public partial class GenerationIii
    {
        [JsonPropertyName("emerald")]
        public OfficialArtwork Emerald { get; set; }

        [JsonPropertyName("firered-leafgreen")]
        public Gold FireredLeafgreen { get; set; }

        [JsonPropertyName("ruby-sapphire")]
        public Gold RubySapphire { get; set; }
    }

    public partial class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }
    }

    public partial class Home
    {
        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }

        [JsonPropertyName("front_shiny")]
        public Uri FrontShiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public partial class GenerationVii
    {
        [JsonPropertyName("icons")]
        public DreamWorld Icons { get; set; }

        [JsonPropertyName("ultra-sun-ultra-moon")]
        public Home UltraSunUltraMoon { get; set; }
    }

    public partial class DreamWorld
    {
        [JsonPropertyName("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonPropertyName("front_female")]
        public object FrontFemale { get; set; }
    }

    public partial class GenerationViii
    {
        [JsonPropertyName("icons")]
        public DreamWorld Icons { get; set; }
    }

    public partial class Stat
    {
        [JsonPropertyName("base_stat")]
        public long BaseStat { get; set; }

        [JsonPropertyName("effort")]
        public long Effort { get; set; }

        [JsonPropertyName("stat")]
        public Species StatStat { get; set; }
    }

    public partial class TypeElement
    {
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        [JsonPropertyName("type")]
        public Species Type { get; set; }
    }


}
