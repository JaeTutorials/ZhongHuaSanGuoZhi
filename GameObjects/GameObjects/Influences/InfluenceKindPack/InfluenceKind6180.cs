﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind6180 : InfluenceKind
    {
        private float rate;

        public override void ApplyInfluenceKind(Person p)
        {
            p.MovementDaysBonus += rate;
        }

        public override void PurifyInfluenceKind(Person p)
        {
            p.MovementDaysBonus -= rate;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.rate = float.Parse(parameter);
            }
            catch
            {
            }
        }

        public override double AIFacilityValue(Architecture a)
        {
            return this.rate * 160;
        }
    }
}

