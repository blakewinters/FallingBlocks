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
    public class Splash : Screen {
        Texture2D _background;

        public Splash(Texture2D background) {
            Name = "Splash";

            _background = background;
        }

        public override void Update() {

        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(_background, _background.Bounds, Color.White);
        }
    }
}
