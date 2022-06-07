#region Usings

using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using XNATests.Classes.Common;
using XNATests.Classes.Utilities;


#endregion

namespace XNATests.Classes.Game
{
    public class Player : GameObject
    {
        
        public static float m_Speed;
        public Player()
        {

        }

        public Player(Vector2 inputPos)
        {
            this.position = inputPos;
        }

        public override void Initialize()
        {
            m_Speed = 6f;

            this.scale = 1f;
            this.rotation = 0f;
            this.isActive = true;
            this.color = Color.White;
            this.spriteEffects = SpriteEffects.None;
            base.Initialize();
        }

        public override void Load(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("Character/Character1");
            base.Load(content);
        }

        public override void Update(List<GameObject> objects)
        {
            base.Update(objects);
            CheckInput();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        private void CheckInput()
        {
            Movement();
        }

        private void Movement()
        {
            if(Input.IsKeyDown(Keys.W) == true && this.isActive == true)
            {
                this.position.Y -= m_Speed;
            }
            else if(Input.IsKeyDown(Keys.S) == true && this.isActive == true)
            {
                this.position.Y += m_Speed;
            }

            if (Input.IsKeyDown(Keys.A) == true && this.isActive == true)
            {
                this.position.X -= m_Speed;
            }
            else if(Input.IsKeyDown(Keys.D) == true && this.isActive == true)
            {
                this.position.X += m_Speed;
            }
        }
    }
}
