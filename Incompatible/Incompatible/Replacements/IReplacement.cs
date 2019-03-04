using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Incompatible.Replacements
{
    interface IReplacement
    {
        // should the replacement always be shown?
        // * true = show if any deprecated mods are found
        // * false = show only if broken mods are found
        bool Always { get; }

        // workshop id(s) of mod(s) to upgrade to
        ulong[] Replacements { get; }

        // require all listed replacements?
        // * true = when upgrading, all replacements are required
        // * false = user can choose which replacements to upgrade to
        bool Combined { get; }

        // some text to give user more info about the upgrade
        string Notes { get; }

        // workshop id(s) of mod(s) that will be replaced when upgrading
        // * broken mods will be unsubscribed
        // * non-broken mods can be merely disabled
        ulong[] Deprecates { get; }
    }
}
