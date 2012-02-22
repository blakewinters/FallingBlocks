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
    public class ScreenManager {
        List<Screen> _screenList = new List<Screen>();
        Screen _currentScreen;

        public ScreenManager(FallingBlocks game) {
        }

        public bool AddScreen(Screen screen) {
            var found = false;
            foreach (var scr in _screenList) {
                if (scr.Name != screen.Name) continue;
                found = true;
            }
            if(!found) _screenList.Add(screen);
            if (_screenList.Count == 1) _currentScreen = screen;

            return (!found);
        }

        public bool RemoveScreen(string screenName) {
            var found = false;
            foreach (var screen in _screenList) {
                if (screen.Name != screenName) continue;
                _screenList.Remove(screen);
                found = true;
                break;
            }

            return (found);
        }

        public bool SwitchScreens(string screenName) {
            var found = false;
            foreach (var screen in _screenList) {
                if (screen.Name != screenName) continue;
                _currentScreen = screen;
                found = true;
                break;
            }

            return (found);
        }

        public string GetCurrentScreen() {
            return (_currentScreen.Name);
        }

        public void Update(GameTime gameTime) {
            _currentScreen.Update();
        }

        public void Draw(SpriteBatch spriteBatch) {
            _currentScreen.Draw(spriteBatch);
        }
    }
}
