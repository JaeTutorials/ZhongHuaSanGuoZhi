﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind1300 : ConditionKind
    {
        private int number = 0;

        public override bool CheckConditionKind(Troop troop)
        {
            return ((int) troop.Army.Kind.Type == this.number);
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.number = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

