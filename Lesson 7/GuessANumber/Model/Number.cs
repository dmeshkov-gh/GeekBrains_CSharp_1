using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber.Model
{
    class Number
    {
        public delegate void Message(string message); // Делегат, который передает сообщение в Form
        public event Message MyMessage;

        public event Action IsGameEnded;
        public int NumberToGuess { get; }
        public int MyNumber { get; set; }
        public Number()
        {
            NumberToGuess = new Random().Next(1, 101); 
        }

        public void CheckNumber()
        {
            if(NumberToGuess == MyNumber)
            {
                MyMessage?.Invoke("You win! Congratulations!");
                IsGameEnded?.Invoke();
            }
            if(NumberToGuess < MyNumber)
            {
                MyMessage?.Invoke("Too much! Try a lesser number!");
            }
            if(NumberToGuess > MyNumber)
            {
                MyMessage?.Invoke("Not Enough! Try a greater number!");
            }
        }
    }
}
