namespace ModFreshener.Replacements.Scripts
{
   // note: this is for 81 tiles, for 25 tiles see Tiles25.cs
    class Tiles81 : ReplacementBase
    {
        public Tiles81()
        {
            option.Add(576327847, 1); // 81 Tiles by BloodyPenguin

            note.Add(1, "'81 Tiles' allows all tiles on the map to be purchased. This is the latest version, compatible with all DLCs.");

            obsolete.Add(1361478243, 1); // * 81 Tiles
            obsolete.Add(1575247594, 1); // * 81 Tiles Fixed for 1
            obsolete.Add(1560122066, 1); // * 81MOD
            obsolete.Add(548208563, 1);  // * 81 Tiles
            obsolete.Add(422554572, 1);  // * 81 Tiles Updated
        }
    }
}
