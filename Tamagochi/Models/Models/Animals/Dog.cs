﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;


namespace Models
{
    public class Dog : Mammal, ICarnivorous, ISoundable, IPlayable
    {
        private const string dogSoundPath = @"...\...\Resourses\Sound\DogSound.wav";

        private List<Meat> food;

        public Dog(Gender sex, string name)
            : base(sex, name)
        {
           // this.Food = new List<Meat>();
        }

        public Dog(Gender sex, string name, int initialPoints,Condition initialCondition, List<Meat> initialFood)
            : base(sex, name,initialCondition, initialPoints)
        {
            this.Food = initialFood;
        }

        public List<Meat> Food
        {
            get 
            {
                return new List<Meat>(this.food); 
            }
            private set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("List cannot has 0 arguments.");
                }
                this.food = value;
            }
        }

        public void Hunt()
        {
            Random rnd = new Random();
            int huntingPoints = rnd.Next(2, 20);
            AddPoints(huntingPoints);
        }

        public void MakeSound()
        {
            SoundPlayer playSound = new SoundPlayer(dogSoundPath);
            playSound.Play();
        }
    }
}
