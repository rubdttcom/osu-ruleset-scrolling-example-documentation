// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Objects;
using osu.Game.Rulesets.MyCoolWorkingRuleset.UI;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset.Replays
{
    public class MyCoolWorkingRulesetAutoGenerator : AutoGenerator<MyCoolWorkingRulesetReplayFrame>
    {
        public new Beatmap<MyCoolWorkingRulesetHitObject> Beatmap => (Beatmap<MyCoolWorkingRulesetHitObject>)base.Beatmap;

        public MyCoolWorkingRulesetAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            int currentLane = 0;

            Frames.Add(new MyCoolWorkingRulesetReplayFrame());

            foreach (MyCoolWorkingRulesetHitObject hitObject in Beatmap.HitObjects)
            {
                if (currentLane == hitObject.Lane)
                    continue;

                int totalTravel = Math.Abs(hitObject.Lane - currentLane);
                var direction = hitObject.Lane > currentLane ? MyCoolWorkingRulesetAction.MoveDown : MyCoolWorkingRulesetAction.MoveUp;

                double time = hitObject.StartTime - 5;

                if (totalTravel == MyCoolWorkingRulesetPlayfield.LANE_COUNT - 1)
                    addFrame(time, direction == MyCoolWorkingRulesetAction.MoveDown ? MyCoolWorkingRulesetAction.MoveUp : MyCoolWorkingRulesetAction.MoveDown);
                else
                {
                    time -= totalTravel * KEY_UP_DELAY;

                    for (int i = 0; i < totalTravel; i++)
                    {
                        addFrame(time, direction);
                        time += KEY_UP_DELAY;
                    }
                }

                currentLane = hitObject.Lane;
            }
        }

        private void addFrame(double time, MyCoolWorkingRulesetAction direction)
        {
            Frames.Add(new MyCoolWorkingRulesetReplayFrame(direction) { Time = time });
            Frames.Add(new MyCoolWorkingRulesetReplayFrame { Time = time + KEY_UP_DELAY }); //Release the keys as well
        }
    }
}
