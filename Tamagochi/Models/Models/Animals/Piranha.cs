﻿using System;
using System.Collections.Generic;

namespace Models
{
	class Piranha : Fish, IAnimal, ICarnivorous
	{
		#region Constants
		private const string PiranhaPictureDefault = @"..\..\..\Models\Resourses\Pictures\Piranha\Picture_01.jpg";
		private const string PiranhaPictureEating = @"..\..\..\Models\Resourses\Pictures\Piranha\Picture_02.jpg";
		private const string PiranhaPictureUnhappy = @"..\..\..\Models\Resourses\Pictures\Piranha\Picture_03.jpg";
		private const double HappinessIncrement = 20;
		private const double FeedIncrement = 20;
		#endregion

		#region Fields
		private List<Meat> meatFoodAllowed;
		#endregion

		#region Constructors

		public Piranha(Gender  sex, string name)
			: base(sex, name)
		{
			base.Pictures = new string[3] { PiranhaPictureDefault, PiranhaPictureEating, PiranhaPictureUnhappy };
			this.MeatFoodAllowed = new List<Meat> { new Drumstick(), new Pizza(), new Steak() };
		}

		internal Piranha(Gender sex, string name, Condition condition)
			: base(sex, name, condition)
		{
		}
		#endregion
		public List<Meat> MeatFoodAllowed
		{
			get
			{
				return this.meatFoodAllowed;
			}
			protected set
			{
				if (value != null)
				{
					this.meatFoodAllowed = value;
				}
				else
				{
					throw new ArgumentNullException("List of allowed foods cannot be null");
				}
			}
		}

		public void Hunt()
		{
			double incrementMult = new Random().Next(0, 1);
			var modifiedCondition = this.CurrentCondition;
			modifiedCondition.Feed += (int)(incrementMult * FeedIncrement);
			modifiedCondition.Happiness += (int)(incrementMult * HappinessIncrement);
			this.CurrentCondition = modifiedCondition;
		}
	}
}
