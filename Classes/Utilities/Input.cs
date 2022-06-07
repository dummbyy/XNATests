using Microsoft.Xna.Framework.Input;
using System;

namespace XNATests.Classes.Utilities
{
    public static class Input 
    {
        private static KeyboardState keyboardState;
        private static KeyboardState lastKeyboardState;
        private static MouseState mouseState;
        private static MouseState lastMouseState;

        public static void Update()
        {
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();

            lastMouseState = mouseState;
            mouseState = Mouse.GetState();
        }

    #region Keyboard Input


        public static bool IsKeyDown(Keys key)
        {
            if(keyboardState.IsKeyDown(key) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsKeyUp(Keys key)
        {
            if(keyboardState.IsKeyUp(key) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsKeyPressed(Keys key)
        {
            if(keyboardState.IsKeyDown(key) == true && lastKeyboardState.IsKeyDown(key) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    #endregion

    #region Mouse Inputs
        public static bool LeftButtonDown()
        {
            if(mouseState.LeftButton == ButtonState.Pressed)
                return true;
            else
                return false;
        }
        public static bool RightButtonDown()
        {
            if(mouseState.RightButton == ButtonState.Pressed)
                return true;
            else
                return false;
        }
        public static bool LeftButtonPressed()
        {
            if(mouseState.LeftButton == ButtonState.Pressed && lastMouseState.LeftButton == ButtonState.Released)
                return true;
            else
                return false;
        }
        public static bool RightButtonPressed()
        {
            if(mouseState.RightButton == ButtonState.Pressed && lastMouseState.RightButton == ButtonState.Released)
                return true;
            else
                return false;
        }
    #endregion
    }
}