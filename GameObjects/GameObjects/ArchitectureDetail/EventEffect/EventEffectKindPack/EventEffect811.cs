﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect811 : EventEffectKind
    {
        
        public override void ApplyEffectKind(Person person, Event e)
        {
            if (person.BelongedFactionWithPrincess != null)
            {
                person.execute(person.BelongedFactionWithPrincess);
            }
        }
    }
}

