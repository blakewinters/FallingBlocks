using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FallingBlocks.Screens {
    public abstract class Screen {
        public string Name { get; set; }

        public Screen() {

        }

        public abstract void Update();

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
