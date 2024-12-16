// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Audio.Track;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Input.Bindings;
using osu.Framework.Input.Events;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Graphics.Containers;
using osuTK;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset.UI
{
    public partial class MyCoolWorkingRulesetCharacter : BeatSyncedContainer, IKeyBindingHandler<MyCoolWorkingRulesetAction>
    {
        public readonly BindableInt LanePosition = new BindableInt
        {
            Value = 0,
            MinValue = 0,
            MaxValue = MyCoolWorkingRulesetPlayfield.LANE_COUNT - 1,
        };

        [BackgroundDependencyLoader]
        private void load(TextureStore textures)
        {
            Size = new Vector2(MyCoolWorkingRulesetPlayfield.LANE_HEIGHT);

            Child = new Sprite
            {
                FillMode = FillMode.Fit,
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Scale = new Vector2(1.2f),
                RelativeSizeAxes = Axes.Both,
                Texture = textures.Get("character")
            };

            LanePosition.BindValueChanged(e => { this.MoveToY(e.NewValue * MyCoolWorkingRulesetPlayfield.LANE_HEIGHT); });
        }

        protected override void OnNewBeat(int beatIndex, TimingControlPoint timingPoint, EffectControlPoint effectPoint, ChannelAmplitudes amplitudes)
        {
            if (effectPoint.KiaiMode)
            {
                bool direction = beatIndex % 2 == 1;
                double duration = timingPoint.BeatLength / 2;

                Child.RotateTo(direction ? 10 : -10, duration * 2, Easing.InOutSine);

                Child.Animate(i => i.MoveToY(-10, duration, Easing.Out))
                     .Then(i => i.MoveToY(0, duration, Easing.In));
            }
            else
            {
                Child.ClearTransforms();
                Child.RotateTo(0, 500, Easing.Out);
                Child.MoveTo(Vector2.Zero, 500, Easing.Out);
            }
        }

        public bool OnPressed(KeyBindingPressEvent<MyCoolWorkingRulesetAction> e)
        {
            switch (e.Action)
            {
                case MyCoolWorkingRulesetAction.MoveUp:
                    changeLane(-1);
                    return true;

                case MyCoolWorkingRulesetAction.MoveDown:
                    changeLane(1);
                    return true;

                default:
                    return false;
            }
        }

        public void OnReleased(KeyBindingReleaseEvent<MyCoolWorkingRulesetAction> e)
        {
        }

        private void changeLane(int change) => LanePosition.Value = (LanePosition.Value + change + MyCoolWorkingRulesetPlayfield.LANE_COUNT) % MyCoolWorkingRulesetPlayfield.LANE_COUNT;
    }
}
