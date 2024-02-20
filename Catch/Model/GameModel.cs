﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catch.Persistence;

namespace Catch.Model
{
    public class GameModel
    {
        private GameTable _table;
        private Enemy1 _enemy1;
        private Enemy2 _enemy2;
        private Player _player;
        private Boolean van_e1, van_e2, van_p;
        private DataAccess da;

        public GameTable Table { get { return _table; } set { _table = value; } }
        public Enemy1 ENEMY1 { get { return _enemy1; } set { _enemy1 = value; } }
        public Enemy2 ENEMY2 { get { return _enemy2; } set { _enemy2 = value; } }
        public Player PLAYER { get { return _player; } set { _player = value; } }
        public bool E1 { get { return van_e1; } set { van_e1 = value; } }
        public bool E2 { get { return van_e2; } set { van_e2 = value; } }
        public bool P { get { return van_p; } set { van_p = value; } }

        public DataAccess Da { get { return da; } set { da = value; } }
        public bool IsGameOver { get {
                return (!ENEMY1.Alive && !ENEMY2.Alive) ||
                        !PLAYER.Alive || PLAYER.Get_Caught;
            } }

        /*
        Játékos: 3
        Enemy1: 2
        Enemy2: 4
        Field: 0
        Akna: 1
        PlayerAkna: 5
        Enemy1Akna: 6
        Enemy2Akna: 7
         */

        public event EventHandler<GameModelEventArgs> GameOver;
        public event EventHandler<GameModelEventArgs> Step;

        public GameModel(DataAccess da)
        {
            Da = da;
            int[,] x = new int[2, 2];
            _table = new GameTable(1, x);
            Da = da;
            van_e1 = false;
            van_e2 = false;
            van_p = false;
        }
        public void MovePlayer(char c)
        {
            PLAYER.Move(c, Table);
            if (PLAYER.Step)
            {
                OnStep(3);
            }
            if (PLAYER.Get_Caught)
            {
                OnGameOver(0);
            }
            if (PLAYER.Alive == false)
            {
                OnGameOver(2);
            }
            if (ENEMY1.Alive == false && ENEMY2.Alive == false)
            {
                OnGameOver(1);
            }
        }

        public void Enemy1Move(int sc)
        {
            if (sc % 0.5 == 0)
            {
                ENEMY1.Move(Table, ENEMY1.
                            next(ENEMY1.
                            merreKéne(ENEMY1.Pos, PLAYER.Pos)));
                if (PLAYER.Get_Caught)
                {
                    OnGameOver(0);
                }
                if (PLAYER.Alive == false)
                {
                    OnGameOver(2);
                }
                if (ENEMY1.Alive == false && ENEMY2.Alive == false)
                {
                    OnGameOver(1);
                }
            }
        }

        public void Enemy2Move(int sc)
        {
            if (sc % 1 == 0)
            {
                ENEMY2.Move(Table, ENEMY2.
                            next(ENEMY2.
                            merreKéne(ENEMY2.Pos, PLAYER.Pos)));
                if (PLAYER.Get_Caught)
                {
                    OnGameOver(0);
                }
                if (PLAYER.Alive == false)
                {
                    OnGameOver(2);
                }
                if (ENEMY1.Alive == false && ENEMY2.Alive == false)
                {
                    OnGameOver(1);
                }
            }
        }

        public void Save(string path, GameTable t)
        {
            da.SaveAsync(path, t);
        }
        public GameTable Loaddef(string path)
        {   
            GameTable table = Da.Load(path);
            table.setE1(table.E1);
            table.setE2(table.E2);
            table.setP(table.P);
            PLAYER = new Player(table.PPos[0], table.PPos[1]);
            P = true;
            ENEMY1 = new Enemy1(table.E1Pos[0], table.E1Pos[1], PLAYER);
            E1 = true;
            ENEMY2 = new Enemy2(table.E2Pos[0], table.E2Pos[1], PLAYER);
            E2 = true;
            
            this.Table = table;
            return table;
        }
        public GameTable Load(string path)
        {
            GameTable table = Da.Load(path);
            if (table.E1)
            {
                ENEMY1 = new Enemy1(table.E1Pos[0], table.E1Pos[1], PLAYER);
                E1 = true;
            }
            if (table.E2)
            {
                ENEMY2 = new Enemy2(table.E2Pos[0], table.E2Pos[1], PLAYER);
                E2 = true;
            }
            if (table.P)
            {
                PLAYER = new Player(table.PPos[0], table.PPos[1]);
                P = true;
            }

            this.Table = table;
            return table;
        }
        public void OnGameOver(int i)
        {
            if (GameOver != null)
                GameOver(this, new GameModelEventArgs(true, i));
        }
        public void OnStep(int i)
        {
            if (Step != null)
                Step(this, new GameModelEventArgs(true, i));
        }
    }
}
