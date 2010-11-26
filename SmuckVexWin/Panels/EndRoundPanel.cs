﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using DDW.V2D;
using V2DRuntime.Display;
using DDW.Input;
using DDW.Display;
using V2DRuntime.Components;
using Smuck.Components;
using Microsoft.Xna.Framework.Input;

namespace Smuck.Panels
{
    public class EndRoundPanel : Panel
    {
        public List<ScoreBox> scoreBox;

        public EndRoundPanel(Texture2D texture, V2DInstance inst) : base(texture, inst) { }

		public override bool OnPlayerInput(int playerIndex, DDW.Input.Move move, TimeSpan time)
		{			
			bool result = base.OnPlayerInput(playerIndex, move, time);
			if (result && isActive && Visible)
			{
				if (move == Move.ButtonA)//(move.Releases & Buttons.A) != 0) //
				{
                    Continue(this, null);
                    result = false;
				}
			}
			return result;
		}
        public override void Removed(EventArgs e)
        {
            base.Removed(e);
            foreach (ScoreBox sb in scoreBox)
            {
                sb.Player = null;
            }
        }
		public event EventHandler Continue;
    }
}
