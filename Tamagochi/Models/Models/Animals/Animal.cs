﻿using System;
using System.Collections.Generic;
using Polenter.Serialization;

namespace Models
{
    public abstract class Animal
    {
        //TODO: encapsulate all set properties protected or internal (whichever works with the serialization)
        //TODO: make all animal constructors internal (other projects will only use the factory)
        #region Constants
        private const int ConditionMaxValue = 100;
        #endregion

        #region Fields
        private string[] pictures;

        // Cannot encapsulate because it would break the serialization or the methods for changing conditions
        public virtual Condition CurrentCondition{ get; set; }

        private Gender sex;
        private string name;
        protected readonly Random random;
        private List<Food> foodsAllowed = new List<Food>();
        private Dictionary<Food, int> foodsAvailable = new Dictionary<Food, int>();
        private List<Food> foodsInfinite = new List<Food>();
        #endregion

        #region Constructors
        protected Animal()
        {
            this.name = this.GetType().Name;
            this.Sex = Gender.Male;
            this.CurrentCondition = new Condition(ConditionMaxValue);
        }

        protected Animal(Gender sex, string name)
            : this()
        {
            this.Name = name;
            this.sex = sex;
            if (this is ICarnivorous)
            {
                random = new Random();
            }
        }

        protected Animal(Gender sex, string name, Condition initialCondition)
            : this(sex, name)
        {
            this.CurrentCondition = initialCondition;
        }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }
            protected set
            {
                this.sex = value;
            }
        }

        public List<Food> FoodsInfinite
        {
            get
            {
                return this.foodsInfinite;
            }
            set
            {
                if (value != null)
                {
                    this.foodsInfinite = value;
                }
                else
                {
                    throw new ArgumentNullException("List of infinite foods cannot be null");
                }
            }
        }

        public string[] Pictures
        {
            get
            {
                return this.pictures;
            }
            set
            {
                this.pictures = value;
            }
        }
        #endregion

        #region Serialization
        public void Serialize(string path = "../../")
        {
            var serializer = new SharpSerializer();
            serializer.Serialize(this, path + this.name + ".xml");
        }

        public static Animal Deserialize(string path = "../../player.xml")
        {
            var serializer = new SharpSerializer();
            return (Animal)serializer.Deserialize(path); ;
        }

        #endregion
    }
}
