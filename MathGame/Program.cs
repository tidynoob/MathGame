﻿using MathGame;

Menu menu = new();

DateTime date = DateTime.UtcNow;

string? name = Helpers.GetName();

menu.ShowMenu(name, date);