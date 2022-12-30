using BattleGame;
using System;

namespace WhatIsOvrride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slime slime = new Slime();
            slime.Name = "123";
            Console.WriteLine("[Main] 슬라임 클래스에서 필드를 가져옴 -> {0}", slime.Name);

        }
    }
}