using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rpgtowerdefense.States
{
    public abstract class State
    {

        protected Game1 _game;

        protected ContentManager _content;

        public State(Game1 game, ContentManager content)
        {
            _game = game;
            _content = content;
        }

        public abstract void LoadContent();

        public abstract void Update(GameTime gameTime);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);






        internal void Draw(GameTime gameTime, object spriteBatch)
        {
            throw new NotImplementedException();
        }


        public static implicit operator State(SpriteBatch v)
        {
            throw new NotImplementedException();
        }
    }
}
