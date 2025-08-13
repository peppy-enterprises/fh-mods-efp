using System.Collections.Generic;

using Fahrenheit.Core;

namespace Fahrenheit.Modules.EFP;

internal abstract class EfpPatch {
    public abstract FhSettingsCategory get_settings();

    public abstract void hook();
}
