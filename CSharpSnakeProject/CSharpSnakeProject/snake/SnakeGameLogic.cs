using mySnake.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySnake.snake
{
    internal class SnakeGameLogic : BaseGameLogic
    {
        private SnakeGamePlayState gameplayState = new SnakeGamePlayState();        
               
        public void GotoGameplay()
        {
            gameplayState.fieldWidth = screenWidth;
            gameplayState.fieldHeight = screenHeight;
            ChangeState(gameplayState);
            gameplayState.Reset();
        }
        public override void OnArrowUp()
        {
            if (currentState != gameplayState) return;
            gameplayState.SetDirection(SnakeDir.Up);
        }

        public override void OnArrowDown()
        {
            if (currentState != gameplayState) return;
            gameplayState.SetDirection(SnakeDir.Down);
        }

        public override void OnArrowLeft()
        {
            if (currentState != gameplayState) return;
            gameplayState.SetDirection(SnakeDir.Left);
        }

        public override void OnArrowRight()
        {
            if (currentState != gameplayState) return;
            gameplayState.SetDirection(SnakeDir.Right);
        }

        public override void Update(float deltaTime)
        {
            if (currentState != gameplayState)
            {
                GotoGameplay();
            }
        }

        public override ConsoleColor[] CreatePalette()
        {
            return
            [
                ConsoleColor.Green,
                ConsoleColor.Red,
                ConsoleColor.White,
                ConsoleColor.Blue,
            ];
        }
    }
}
