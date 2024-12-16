// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Objects;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Objects.Drawables;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Replays;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset.UI
{
    [Cached]
    public partial class DrawableMyCoolWorkingRulesetRuleset : DrawableScrollingRuleset<MyCoolWorkingRulesetHitObject>
    {
        public DrawableMyCoolWorkingRulesetRuleset(MyCoolWorkingRulesetRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
            Direction.Value = ScrollingDirection.Left;
            TimeRange.Value = 6000;
        }

        protected override Playfield CreatePlayfield() => new MyCoolWorkingRulesetPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new MyCoolWorkingRulesetFramedReplayInputHandler(replay);

        public override DrawableHitObject<MyCoolWorkingRulesetHitObject> CreateDrawableRepresentation(MyCoolWorkingRulesetHitObject h) => new DrawableMyCoolWorkingRulesetHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new MyCoolWorkingRulesetInputManager(Ruleset?.RulesetInfo);
    }
}
