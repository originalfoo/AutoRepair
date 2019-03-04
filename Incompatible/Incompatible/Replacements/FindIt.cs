namespace Incompatible.Replacements
{
    /*
    * Why recommend upgrading 'More Beautification' to 'Find It'?
    * 
    * 1. More Beautification mod causes severe lag (especially on potato computers) when
    *    opening the build menu.
    * 
    * 2. Find It provides access to far more assets, has additional filters and a search tool.
    * 
    * For these reasons, we believe that Find It is generally better for end-users.
   */

    public class FindIt : IReplacement
    {
        static bool Always => true;

        static readonly ulong[] Replacements = { 837734529u }; // Find It! by SamSamTS

        static bool Combined => false;

        static string Notes => "A fast searchable and filterable build menu providing access to all assets including props.";

        static readonly ulong[] Deprecates =
        {
            540758804, // * Search Box Mod
            505480567, // More beautification (causes lag)
        };
    }
}
