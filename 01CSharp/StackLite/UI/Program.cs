﻿using UI;
using BL;
using DL;

//Dependency Injection
IRepository repo = new FileRepository();
ISLBL bl = new SLBL(repo);
new MainMenu(bl).Start();