﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public abstract class Bird : Animal, ISoundabla, IPlayable
    {
        public void MakeSound()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public int Points
        {
            get { throw new NotImplementedException(); }
        }

        public void AddPoints()
        {
            throw new NotImplementedException();
        }
    }
}
