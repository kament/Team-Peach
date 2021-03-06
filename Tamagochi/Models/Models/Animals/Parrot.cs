﻿namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.Media;
    //using Food;

    public class Parrot : Bird, IAnimal, IHerbivorous, IPlayable, ISoundable
    {
        #region Constants
        private const string ParrotSoundPath =      @"..\..\..\Models\Resourses\Sound\ParrotSound.wav";
        private const string ParrotPictureDefault = @"..\..\..\Models\Resourses\Pictures\Parrot\initial.png";
        private const string ParrotPictureEating =  @"..\..\..\Models\Resourses\Pictures\Parrot\eat.png";
        private const string ParrotPictureUnahppy = @"..\..\..\Models\Resourses\Pictures\Parrot\sad.png";
        private const string ParrotPicturePlaying = @"..\..\..\Models\Resourses\Pictures\Parrot\play.png";
        private const int HappinessIncrement = 20;
        private const int PlayPointsIncrement = 20;
        #endregion

        #region Fields
        private List<Plant> plantFoodAllowed = new List<Plant>();
        private int points;
        #endregion

        #region Constructors
        internal Parrot()
            : base()
        {
        }

        internal Parrot(Gender sex, string name)
            : base(sex, name)
        {
            base.Pictures = new string[4] { ParrotPictureDefault, ParrotPictureEating, ParrotPictureUnahppy, ParrotPicturePlaying };
            this.plantFoodAllowed = new List<Plant> { new Apple(), new Banana() };
        }

        internal Parrot(Gender sex, string name, Condition condition)
            : base(sex, name, condition)
        {
        }
        #endregion
        
        public List<Plant> PlantsFoodAllowed
        {
            get
            {
                return this.plantFoodAllowed;
            }
            protected set
            {
                if (value != null)
                {
                    this.plantFoodAllowed = value;
                }
                else
                {
                    throw new ArgumentNullException("List of allowed foods cannot be null");
                }
            }
        }


        public void Play()
        {
            this.CurrentCondition.ChangeHappiness(HappinessIncrement);
        }

        public void AddPoints(int aditionalPoints)
        {
            this.Points += aditionalPoints;
        }

        public string SoundPath
        {
            get
            {
                return ParrotSoundPath;
            }
        }

        public void MakeSound()
        {
            SoundPlayer playSound = new SoundPlayer(SoundPath);
            playSound.Play();
        }

        public int Points
        {
            get { return this.points; }
            protected set { this.points = value; }
        }
    }
}
