namespace ModFreshener.Replacements.Scripts
{
    class NetworkSkins : ReplacementBase
    {
        public NetworkSkins()
        {
            option.Add(543722850, 1); // Network Skins by BloodyPenguin and Boformer

            note.Add(1, "'Network Skins' lets you to change or remove the pillars, trees and lights of transport networks.");

            deprecated.Add(463845891, 1); // No Pillars (v1.1 compatible)
            deprecated.Add(547126602, 1); // Street light replacer
            deprecated.Add(423934526, 1); // Tree Replacer

            obsolete.Add(409073164, 1); // * No Pillars
        }
    }
}