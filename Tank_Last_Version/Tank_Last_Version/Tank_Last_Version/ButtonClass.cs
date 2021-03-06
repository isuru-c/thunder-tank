﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tank_Last_Version
{
    class ButtonClass
    {
        Texture2D texture;
        Vector2 position;
        Rectangle rectangle;

        Color colour = new Color(255, 255, 255, 255);

        public Vector2 size;

        public ButtonClass(Texture2D newTexture, GraphicsDevice graphics)
        {
            this.texture = newTexture;
            size = new Vector2(graphics.Viewport.Width /4, graphics.Viewport.Height / 10);
        }

        bool down;
        public bool isClicked;

        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (mouseRectangle.Intersects(rectangle))
            {
                if (colour.A == 255) down = false;
                if (colour.A == 200 || colour.A == 199 || colour.A == 201) down = true;
                if (down) colour.A += 2; else colour.A -= 2;

                if (mouse.LeftButton == ButtonState.Pressed) isClicked = true;
            }
            else if(colour.A<255)
            {
                colour.A = 255;
                isClicked = false;
            }
        }

        public void setPosition(Vector2 newPosition)
        {
            this.position = newPosition;
        }
        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, colour);
        }


    }
}
