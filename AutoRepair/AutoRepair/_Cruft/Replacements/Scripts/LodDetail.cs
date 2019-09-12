namespace AutoRepair.Replacements.Scripts
{
    class LodDetail : ReplacementBase
    {
        public LodDetail()
        {
            mandatory = false;

            option.Add(1680642819, 1); // Ultimate Level of Detail by Boformer

            note.Add(1, "'Ultimate Level of Detail' allows you to control LOD settings for trees, props, buildings and networks.");

            deprecated.Add(561888259, 1); // LOD Toggler
            deprecated.Add(635041373, 1); // LOD Reducer
        }
    }
}
