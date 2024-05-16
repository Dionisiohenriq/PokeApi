using System.Text.Json.Serialization;

namespace PokeApi.Client.Responses
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class PokeApiGetPokemonResponse
    {
        [JsonPropertyName("ability")]
        public List<AbilityDetail> Abilities { get; set; }
        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }
        [JsonPropertyName("cries")]
        public Cries Cries { get; set; }
        [JsonPropertyName("forms")]
        public List<Forms> Forms { get; set; }
        [JsonPropertyName("game_indices")]
        public List<GameIndices> GameIndices { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("held_items")]
        public string[] HeldItems { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
        [JsonPropertyName("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }
        [JsonPropertyName("moves")]
        public List<Moves> Moves { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("order")]
        public int Order { get; set; }
        [JsonPropertyName("past_abilities")]
        public string[] PastAbilities { get; set; }
        [JsonPropertyName("past_types")]
        public string[] PastTypes { get; set; }
        [JsonPropertyName("species")]
        public Species Species { get; set; }
        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }
        [JsonPropertyName("stats")]
        public List<Stats> Stats { get; set; }
        [JsonPropertyName("types")]
        public List<Types> Types { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

    }

    public class AbilityDetail
    {
        [JsonPropertyName("ability")]
        public Ability Ability { get; set; }
        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
    }

    public class Ability
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Cries
    {
        [JsonPropertyName("latest")]
        public string Latest { get; set; }
        [JsonPropertyName("legacy")]
        public string Legacy { get; set; }
    }

    public class Forms
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class GameIndices
    {
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }
        [JsonPropertyName("version")]
        public Version Version { get; set; }

    }

    public class Version
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Moves
    {
        [JsonPropertyName("move")]
        public Move Move { get; set; }
        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetails> VersionGroupDetails { get; set; }
    }

    public class Move
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class VersionGroupDetails
    {
        [JsonPropertyName("level_learned_at")]
        public int LevelLearnedAt { get; set; }
        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup VersionGroup { get; set; }
    }

    public class MoveLearnMethod
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class VersionGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Species
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("other")]
        public Other Other { get; set; }
        [JsonPropertyName("versions")]
        public Versions Versions { get; set; }
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class Other
    {
        [JsonPropertyName("dream_world")]
        public DreamWorld DreamWorld { get; set; }
        [JsonPropertyName("home")]
        public Home Home { get; set; }
        [JsonPropertyName("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
        [JsonPropertyName("showdown")]
        public Showdown Showdown { get; set; }
    }

    public class DreamWorld
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
    }

    public class Home
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class Showdown
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class Versions
    {
        [JsonPropertyName("generation-i")]
        public GenerationI GenerationI { get; set; }
        [JsonPropertyName("generation-ii")]
        public GenerationII GenerationII { get; set; }
        [JsonPropertyName("generation-iii")]
        public GenerationII GenerationIII { get; set; }
        [JsonPropertyName("generation-iv")]
        public GenerationIV GenerationIV { get; set; }
        [JsonPropertyName("generation-v")]
        public GenerationIV GenerationV { get; set; }
        [JsonPropertyName("generation-vi")]
        public GenerationIV GenerationVI { get; set; }
        [JsonPropertyName("generation-vii")]
        public GenerationIV GenerationVII { get; set; }
        [JsonPropertyName("generation-viii")]
        public GenerationIV GenerationVIII { get; set; }
    }

    public class GenerationI
    {
        [JsonPropertyName("red-blue")]
        public RedBlue RedBlue { get; set; }
        [JsonPropertyName("yellow")]
        public Yellow Yellow { get; set; }
    }

    public class RedBlue
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_gray")]
        public string BackGray { get; set; }
        [JsonPropertyName("back_transparent")]
        public string BackTransparent { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_gray")]
        public string FrontGray { get; set; }
        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class Yellow
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_gray")]
        public string BackGray { get; set; }
        [JsonPropertyName("back_transparent")]
        public string BackTransparent { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_gray")]
        public string FrontGray { get; set; }
        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class GenerationII
    {
        [JsonPropertyName("crystal")]
        public Crystal Crystal { get; set; }
        [JsonPropertyName("gold")]
        public Gold Gold { get; set; }
        [JsonPropertyName("silver")]
        public Silver Silver { get; set; }
    }

    public class Crystal
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_transparent")]
        public string BackShinyTransparent { get; set; }
        [JsonPropertyName("back_transparent")]
        public string BackTransparent { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_transparent")]
        public string FrontShinyTransparent { get; set; }
        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class Gold
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class Silver
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class GenerationIII
    {
        [JsonPropertyName("emerald")]
        public Emerald Emerald { get; set; }
        [JsonPropertyName("firered-leafgreen")]
        public FireRedLeafGreen FireRedLeafGreen { get; set; }
        [JsonPropertyName("ruby-sapphire")]
        public RubySapphire RubySapphire { get; set; }
    }

    public class Emerald
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class FireRedLeafGreen
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class RubySapphire
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class GenerationIV
    {
        [JsonPropertyName("diamond-pearl")]
        public DiamondPearl DiamondPearl { get; set; }
        [JsonPropertyName("heartgold-soulsilver")]
        public HeartGoldSoulSilver HeartGoldSoulSilver { get; set; }
        [JsonPropertyName("platinum")]
        public Platinum Platinum { get; set; }
    }

    public class DiamondPearl
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class HeartGoldSoulSilver
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class Platinum
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class GenerationV
    {
        [JsonPropertyName("black-white")]
        public BlackWhite BlackWhite { get; set; }
    }

    public class BlackWhite
    {
        [JsonPropertyName("animated")]
        public Animated Animated { get; set; }
        [JsonPropertyName("back_default")]

        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class Animated
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class GenerationVI
    {
        [JsonPropertyName("omegaruby-alphasapphire")]
        public OmegaRubyAlphaSapphire OmegaRubyAlphaSapphire { get; set; }
        [JsonPropertyName("x-y")]
        public XY XY { get; set; }
    }

    public class OmegaRubyAlphaSapphire
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class XY
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class GenerationVII
    {
        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }
        [JsonPropertyName("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }

    public class Icons
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
    }

    public class UltraSunUltraMoon
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class GenerationVIII
    {
        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }
    }

    public class Stats
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
        [JsonPropertyName("effort")]
        public int Effort { get; set; }
        [JsonPropertyName("stat")]
        public Stat Stat { get; set; }
    }

    public class Stat
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Types
    {
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        [JsonPropertyName("type")]
        public Type Type { get; set; }
    }

    public class Type
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
