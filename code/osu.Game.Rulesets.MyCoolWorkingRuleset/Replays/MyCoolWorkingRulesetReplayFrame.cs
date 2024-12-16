// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset.Replays
{
    public class MyCoolWorkingRulesetReplayFrame : ReplayFrame
    {
        public List<MyCoolWorkingRulesetAction> Actions = new List<MyCoolWorkingRulesetAction>();

        public MyCoolWorkingRulesetReplayFrame(MyCoolWorkingRulesetAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
