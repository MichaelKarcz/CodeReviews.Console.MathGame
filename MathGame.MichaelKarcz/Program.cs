﻿using MathGame.MichaelKarcz;

var menu = new Menu();

var date = DateTime.Now;

var name = Helpers.GetName();

menu.ShowMenu(name, date);