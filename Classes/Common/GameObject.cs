using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XNATests.Classes.Common
{
    public class GameObject
    {
        public string tag;
        public Vector2 position;
        public Vector2 origin;
        public float rotation;
        public float scale;
        public float layerDepth;
        public Texture2D texture;
        public Color color = Color.White;
        public bool isActive = true;
        public SpriteEffects spriteEffects = SpriteEffects.None;

        public GameObject()
        {
        }


        public virtual void Initialize()
        {

        }

        public virtual void Update(List<GameObject> objects)
        {

        }

        public virtual void Load(ContentManager content)
        {

        }
        public virtual void Unload()
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (texture != null && isActive == true)
                spriteBatch.Draw(texture, position, null, color, rotation, origin, scale, spriteEffects, layerDepth);
        }

    }
}
