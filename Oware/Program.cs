/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System;

namespace Oware
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player one = new Player("Player 1");
            //Player two = new Player("Player 2");
            ScoreHouse player1 = new ScoreHouse();
            Player p1 = new Player("Player 1", player1);    //first player
            ScoreHouse player2 = new ScoreHouse();
            Player p2 = new Player("Player 2", player2);
            Board b = new Board(p1, p2);    //second player
            // rest left as exercise to reader!
        }
    }
}
