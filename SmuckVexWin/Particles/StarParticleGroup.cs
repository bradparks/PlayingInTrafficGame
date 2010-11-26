﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V2DRuntime.Particles;
using DDW.V2D;
using Microsoft.Xna.Framework.Graphics;

namespace Smuck.Particles
{
	public class StarParticleGroup : ParticleGroup
	{
		public StarParticles pe;
		public StarParticleGroup()
        {
        }
		public StarParticleGroup(Texture2D texture, V2DInstance inst) : base(texture, inst)
        {
        }
		public override void AddedToStage(EventArgs e)
		{
            base.AddedToStage(e);
            isContinous = true;
		}
        public void SetParticleScale(float scale)
        {
            if (pe != null)
            {
                pe.particleScale = scale;
            }
        }
	}
}
