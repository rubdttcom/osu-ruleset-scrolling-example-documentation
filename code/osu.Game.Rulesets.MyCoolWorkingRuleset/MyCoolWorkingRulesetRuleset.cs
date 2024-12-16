// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Beatmaps;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Mods;
using osu.Game.Rulesets.MyCoolWorkingRuleset.UI;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset
{
    public class MyCoolWorkingRulesetRuleset : Ruleset
    {
        public override string Description => "gather the osu!coins";

        public override DrawableRuleset CreateDrawableRulesetWith(IBeatmap beatmap, IReadOnlyList<Mod> mods = null) => new DrawableMyCoolWorkingRulesetRuleset(this, beatmap, mods);

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) => new MyCoolWorkingRulesetBeatmapConverter(beatmap, this);

        public override DifficultyCalculator CreateDifficultyCalculator(IWorkingBeatmap beatmap) => new MyCoolWorkingRulesetDifficultyCalculator(RulesetInfo, beatmap);

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            switch (type)
            {
                case ModType.Automation:
                    return new[] { new MyCoolWorkingRulesetModAutoplay() };

                default:
                    return Array.Empty<Mod>();
            }
        }

        public override string ShortName => "mycoolworkingruleset";

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new[]
        {
            new KeyBinding(InputKey.W, MyCoolWorkingRulesetAction.MoveUp),
            new KeyBinding(InputKey.S, MyCoolWorkingRulesetAction.MoveDown),
        };

        public override Drawable CreateIcon() => new MyCoolWorkingRulesetRulesetIcon(this);

        // Leave this line intact. It will bake the correct version into the ruleset on each build/release.
        public override string RulesetAPIVersionSupported => CURRENT_RULESET_API_VERSION;
    }
}
