using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Threading;
using Tank_Last_Version.objects;

namespace Tank_Last_Version
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        enum GameState
        {
            MainMenu,
            AIMode,
            Options,
            Playing,
            Info,
        }

        GameState currentGameState = GameState.MainMenu;

        int screenHeight = 600, screenWidth = 900;

        ConnectionHandler connection_handler;
        Parser messageParser;
        Map worldMap;

        ButtonClass btnNormalMode;
        ButtonClass btnAIMode;
        ButtonClass btnOption;
        ButtonClass btnExit;
        ButtonClass btnMainMenu;
        ButtonClass btnSoundOn;
        ButtonClass btnSoundOff;
        ButtonClass btnBack;

        Song backGroundSong;
        SpriteFont font;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //screen resolution adjustment
            graphics.PreferredBackBufferHeight = screenHeight;
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.ApplyChanges();

            IsMouseVisible = true;

            worldMap = new Map(10);
            messageParser = new Parser(worldMap);
            connection_handler = new ConnectionHandler(messageParser);

            backGroundSong = Content.Load<Song>("back_ground_music");
            MediaPlayer.Play(backGroundSong);

            font = Content.Load<SpriteFont>("myFont");

            btnNormalMode = new ButtonClass(Content.Load<Texture2D>("normal_mode"), graphics.GraphicsDevice);
            btnNormalMode.setPosition(new Vector2(600, 50));

            btnAIMode = new ButtonClass(Content.Load<Texture2D>("ai_mode"), graphics.GraphicsDevice);
            btnAIMode.setPosition(new Vector2(600, 110));

            btnOption = new ButtonClass(Content.Load<Texture2D>("options"), graphics.GraphicsDevice);
            btnOption.setPosition(new Vector2(600, 175));

            btnExit = new ButtonClass(Content.Load<Texture2D>("exit"), graphics.GraphicsDevice);
            btnExit.setPosition(new Vector2(600, 235));

            btnMainMenu = new ButtonClass(Content.Load<Texture2D>("button_mm"), graphics.GraphicsDevice);
            btnMainMenu.setPosition(new Vector2(650, 535));

            btnSoundOn = new ButtonClass(Content.Load<Texture2D>("sound_on"), graphics.GraphicsDevice);
            btnSoundOn.setPosition(new Vector2(200, 235));

            btnSoundOff = new ButtonClass(Content.Load<Texture2D>("sound_off"), graphics.GraphicsDevice);
            btnSoundOff.setPosition(new Vector2(500, 235));

            btnBack = new ButtonClass(Content.Load<Texture2D>("back"), graphics.GraphicsDevice);
            btnBack.setPosition(new Vector2(350, 335));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            MouseState mouse = Mouse.GetState(); 

            switch (currentGameState)
            {
                case GameState.MainMenu :
                    if (btnNormalMode.isClicked)
                    {
                        btnNormalMode.isClicked = false;
                        bool response = connection_handler.connect();
                        if (response)
                        {
                            currentGameState = GameState.Playing;
                        }
                        else
                        {
                            currentGameState = GameState.Info;
                        }
                    }
                    if (btnExit.isClicked)
                    {
                        btnExit.isClicked = false;
                        this.Exit();
                    }
                    if (btnAIMode.isClicked)
                    {
                        btnAIMode.isClicked = false;
                        currentGameState = GameState.AIMode;
                    }

                    if (btnOption.isClicked)
                    {
                        btnOption.isClicked = false;
                        currentGameState = GameState.Options;

                    }

                    btnNormalMode.Update(mouse);
                    btnAIMode.Update(mouse);
                    btnOption.Update(mouse);
                    btnExit.Update(mouse);
                    break;
                case GameState.Options:
                    if (btnBack.isClicked) currentGameState = GameState.MainMenu;
                    if (btnSoundOn.isClicked)
                    {
                        MediaPlayer.Resume();
                    }
                    if (btnSoundOff.isClicked)
                    {
                        MediaPlayer.Stop();
                    }
                    btnBack.Update(mouse);
                    btnSoundOff.Update(mouse);
                    btnSoundOn.Update(mouse);
                    break;
                case GameState.Playing :
                    if (btnMainMenu.isClicked)
                    {
                        btnMainMenu.isClicked = false;
                        currentGameState = GameState.MainMenu;
                    }
                    btnMainMenu.Update(mouse);
                    break;

                case GameState.Info:
                    if (btnBack.isClicked)
                    {
                        btnBack.isClicked = false;
                        currentGameState = GameState.MainMenu;
                    }
                    btnBack.Update(mouse);
                    break;
            }


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black );

            spriteBatch.Begin();

            switch (currentGameState)
            {
                case GameState.MainMenu:
                    spriteBatch.Draw(Content.Load<Texture2D>("MainMenu"), new Rectangle(0, 0, graphics.GraphicsDevice.Viewport.Width, graphics.GraphicsDevice.Viewport.Height ), Color.White);
                    btnNormalMode.draw(spriteBatch);
                    btnAIMode.draw(spriteBatch);
                    btnOption.draw(spriteBatch);
                    btnExit.draw(spriteBatch);
                    break;

                case GameState.Options:                    
                    spriteBatch.Draw(Content.Load<Texture2D>("MainMenu"), new Rectangle(0, 0, graphics.GraphicsDevice.Viewport.Width, graphics.GraphicsDevice.Viewport.Height), Color.LightSeaGreen);
                    btnSoundOn.draw(spriteBatch);
                    btnSoundOff.draw(spriteBatch);
                    btnBack.draw(spriteBatch);
                    break;
                case GameState.Playing:
                    spriteBatch.Draw(Content.Load<Texture2D>("side_bar"), new Rectangle(600, 0, 300, 600), Color.White);
                    spriteBatch.DrawString(font, "Points ", new Vector2(710, 50), Color.YellowGreen);
                    spriteBatch.DrawString(font, "Coins ", new Vector2(800, 50), Color.YellowGreen);
                    spriteBatch.Draw(Content.Load<Texture2D>("tank_red_up"), new Rectangle(650,100,30,30), Color.White);
                    spriteBatch.Draw(Content.Load<Texture2D>("tank_blue_up"), new Rectangle(650, 150, 30, 30), Color.White);
                    spriteBatch.Draw(Content.Load<Texture2D>("tank_purple_up"), new Rectangle(650, 200, 30, 30), Color.White);
                    spriteBatch.Draw(Content.Load<Texture2D>("tank_green_up"), new Rectangle(650, 250, 30, 30), Color.White);
                    spriteBatch.Draw(Content.Load<Texture2D>("tank_yellow_up"), new Rectangle(650, 300, 30, 30), Color.White);
                    draw_map();
                    ProcessKeyboard();
                    btnMainMenu.draw(spriteBatch);
                    break;
                case GameState.Info:
                    spriteBatch.Draw(Content.Load<Texture2D>("MainMenu"), new Rectangle(0, 0, graphics.GraphicsDevice.Viewport.Width, graphics.GraphicsDevice.Viewport.Height), Color.LightSeaGreen);
                    spriteBatch.Draw(Content.Load<Texture2D>("net_error_message"), new Rectangle(250, 250, 425, 100), Color.White);
                    btnBack.setPosition(new Vector2(340, 400));
                    btnBack.draw(spriteBatch);
                    break;

            }
            //spriteBatch.Draw(Content.Load<Texture2D>("MainMenu"), new Rectangle(0, 0, 600, 600), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void draw_map()
        {
            int size = worldMap.mapSize;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    MapObject mo = worldMap.getSpot(row, col);

                    if (mo == null)
                    {
                        continue;
                    }
                    else if(mo is Water ){
                        spriteBatch.Draw(Content.Load<Texture2D>("water"),new Rectangle (row*60,col*60,60,60),Color.White);
                    }else if(mo is Stone){
                        spriteBatch.Draw(Content.Load<Texture2D>("stone"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                    }else if(mo is Brick){
                        Brick brick = (Brick)mo;
                        if (brick.damageLevel == 0)
                            spriteBatch.Draw(Content.Load<Texture2D>("brick_100"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                        else if (brick.damageLevel == 1)
                            spriteBatch.Draw(Content.Load<Texture2D>("brick_75"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                        else if (brick.damageLevel == 2)
                            spriteBatch.Draw(Content.Load<Texture2D>("brick_50"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                        else if (brick.damageLevel == 3)
                            spriteBatch.Draw(Content.Load<Texture2D>("brick_25"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                        else
                            continue;

                    }else if(mo is LifePack  ){
                        spriteBatch.Draw(Content.Load<Texture2D>("health_pack"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                    }
                    else if (mo is Coin)
                    {
                        spriteBatch.Draw(Content.Load<Texture2D>("coin"), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                    }
                    else if (mo is Tank)
                    {
                        Tank tank = (Tank)mo;
                        String assertName = "";
                        switch(tank.name){
                            case "P0":
                                switch (tank.direction)
                                {
                                    case 0:
                                        assertName = "tank_red_up";
                                        break;
                                    case 1:
                                        assertName = "tank_red_right";
                                        break;
                                    case 2:
                                        assertName = "tank_red_down";
                                        break;
                                    case 3:
                                        assertName = "tank_red_left";
                                        break;
                                }
                                break;
                            case "P1":
                                switch (tank.direction)
                                {
                                    case 0:
                                        assertName = "tank_blue_up";
                                        break;
                                    case 1:
                                        assertName = "tank_blue_right";
                                        break;
                                    case 2:
                                        assertName = "tank_blue_down";
                                        break;
                                    case 3:
                                        assertName = "tank_blue_left";
                                        break;
                                }
                                break;
                            case "P2":
                                switch (tank.direction)
                                {
                                    case 0:
                                        assertName = "tank_green_up";
                                        break;
                                    case 1:
                                        assertName = "tank_green_right";
                                        break;
                                    case 2:
                                        assertName = "tank_green_down";
                                        break;
                                    case 3:
                                        assertName = "tank_green_left";
                                        break;
                                }
                                break;
                            case "P3":
                                switch (tank.direction)
                                {
                                    case 0:
                                        assertName = "tank_purple_up";
                                        break;
                                    case 1:
                                        assertName = "tank_purple_right";
                                        break;
                                    case 2:
                                        assertName = "tank_purple_down";
                                        break;
                                    case 3:
                                        assertName = "tank_purple_left";
                                        break;
                                }
                                break;;
                            case "P4":
                                switch (tank.direction)
                                {
                                    case 0:
                                        assertName = "tank_yellow_up";
                                        break;
                                    case 1:
                                        assertName = "tank_yellow_right";
                                        break;
                                    case 2:
                                        assertName = "tank_yellow_down";
                                        break;
                                    case 3:
                                        assertName = "tank_yellow_left";
                                        break;
                                }
                                break;                      
                        }
                        spriteBatch.Draw(Content.Load<Texture2D>(assertName), new Rectangle(row * 60, col * 60, 60, 60), Color.White);
                    }
                }
            }
        }
        private void ProcessKeyboard()
        {
            KeyboardState keybState = Keyboard.GetState();

            if (keybState.IsKeyDown(Keys.Left))
                connection_handler.moveLeft();
            if (keybState.IsKeyDown(Keys.Right))
                connection_handler.moveRight();
            if (keybState.IsKeyDown(Keys.Down))
                connection_handler.moveDown();
            if (keybState.IsKeyDown(Keys.Up))
                connection_handler.moveUp();
            if (keybState.IsKeyDown(Keys.Enter) || keybState.IsKeyDown(Keys.Space))
                connection_handler.shoot();
        }
    
    }

}
