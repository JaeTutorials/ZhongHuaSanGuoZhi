﻿using System;

namespace GameObjects.PersonDetail
{
	public class PersonRelationValue : GameObject
	{
        public Person Source { get; set; }
        public Person Person { get; set; }
        public int RelationValue { get; set; }

        public String Name
        {
            get
            {
                return Person.Name;
            }
        }

        public bool HasStrain
        {
            get
            {
                return Source.HasStrainTo(Person);
            }
        }

        public bool HasCloseStrain
        {
            get
            {
                return Source.HasCloseStrainTo(Person);
            }
        }

        public bool IsSpouse
        {
            get
            {
                return Source.Spouse == Person;
            }
        }

        public bool IsBrother
        {
            get
            {
                return Source.Brothers.GameObjects.Contains(Person);
            }
        }

        public bool IsClose
        {
            get
            {
                return Source.Closes(Person);
            }
        }

        public bool IsHate
        {
            get
            {
                return Source.Hates(Person);
            }
        }

        public PersonRelationValue(Person source, Person person, int relationValue)
        {
            this.Source = source;
            this.Person = person;
            this.RelationValue = relationValue;
        }
	}
}
