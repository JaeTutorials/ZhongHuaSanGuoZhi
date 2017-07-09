﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect820 : EventEffectKind
    {
        
        public override void ApplyEffectKind(Person person, Event e)
        {
            if (person.BelongedFactionWithPrincess != null)
            {
                person.MoveToArchitecture(person.BelongedFactionWithPrincess.Leader.BelongedArchitecture);
            }
        }
    }
}

