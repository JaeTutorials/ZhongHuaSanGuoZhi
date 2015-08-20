﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind550 : ConditionKind
    {
        private int number = 0;

        public override bool CheckConditionKind(Person person)
        {
            return (person.RoutCount >= this.number);
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

