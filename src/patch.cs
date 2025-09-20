// SPDX-License-Identifier: MIT

namespace Fahrenheit.Modules.EFP;

public abstract class EfpPatch {
    public abstract FhSettingsCategory get_settings();

    public abstract void hook();
}
