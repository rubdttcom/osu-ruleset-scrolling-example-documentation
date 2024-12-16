// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset
{
    public partial class MyCoolWorkingRulesetInputManager : RulesetInputManager<MyCoolWorkingRulesetAction>
    {
        public MyCoolWorkingRulesetInputManager(RulesetInfo ruleset)
            : base(ruleset, 0, SimultaneousBindingMode.Unique)
        {
        }
    }

    public enum MyCoolWorkingRulesetAction
    {
        [Description("Move up")]
        MoveUp,

        [Description("Move down")]
        MoveDown,
    }
}
