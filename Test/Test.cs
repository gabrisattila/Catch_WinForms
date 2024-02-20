using Microsoft.VisualStudio.TestTools.UnitTesting;
using Catch.Model;
using Catch.Persistence;
using System;

namespace Test
{
    [TestClass]
    public class Test
    {
        private DataAccess _dataAccess;
        private GameTable _testTable;
        private GameModel _model;



        #region 11 teszt
        [TestMethod]
        public void Initialize11()
        {
            _dataAccess = new DataAccess();
            int m = 11;
            int[,] t = new int[m, m];
            _testTable = new GameTable(m, t);
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _testTable.T�bla[i, j] = r.Next(0, 2);
                }
            }
            _testTable.setP(false);
            _testTable.setE1(false);
            _testTable.setE2(false);

            _model = new GameModel(_dataAccess);
        }
        [TestMethod]
        public void LoadTest_11()
        {
            Initialize11();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def11.txt");
            Assert.AreEqual(_testTable.T�bla[_model.PLAYER.Pos[0], _model.PLAYER.Pos[1]],
                            _model.Table.T�bla[_model.PLAYER.Pos[0], _model.PLAYER.Pos[1]]);

            Assert.AreEqual(_testTable.T�bla[_model.ENEMY1.Pos[0], _model.ENEMY1.Pos[1]],
                            _model.Table.T�bla[_model.ENEMY1.Pos[0], _model.ENEMY1.Pos[1]]);

            Assert.AreEqual(_testTable.T�bla[_model.ENEMY2.Pos[0], _model.ENEMY2.Pos[1]],
                            _model.Table.T�bla[_model.ENEMY2.Pos[0], _model.ENEMY2.Pos[1]]);
        }

        [TestMethod]
        public void MovePlayer_And_PlayerDie_GameOver_Test_11()
        {
            Initialize11();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def11.txt");
            _model.MovePlayer('w');
            Assert.AreEqual(_model.Table.T�bla[0, 5], 3);
            // ugye felfel� nem tud mozogni, �gy az eredeti hely�n kell, hogy maradjon
            _model.MovePlayer('s');
            Assert.AreEqual(_model.Table.T�bla[1, 5], 3);
            _model.MovePlayer('d');
            Assert.AreEqual(_model.Table.T�bla[1, 6], 3);
            _model.MovePlayer('a');
            Assert.AreEqual(_model.Table.T�bla[1, 5], 3);
            _model.MovePlayer('a');
            Assert.AreEqual(_model.Table.T�bla[1, 4], 3);
            _model.MovePlayer('w');
            Assert.IsTrue(_model.IsGameOver); // akn�ra l�pett 
        }

        [TestMethod]
        public void EnemiesMove_And_Die_GameOver_Test_11()
        {
            Initialize11();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def11.txt");
            _model.Enemy1Move(1);
            _model.Enemy2Move(1);
            Assert.AreEqual(_model.Table.T�bla[9, 0], 2);
            Assert.AreEqual(_model.Table.T�bla[9, 10], 4);
            _model.Enemy1Move(1);
            Assert.IsFalse(_model.ENEMY1.Alive);
            _model.Enemy2Move(1);
            _model.Enemy2Move(1);
            Assert.IsFalse(_model.ENEMY2.Alive);
            Assert.IsTrue(_model.IsGameOver);
        }
        #endregion

        #region 15 teszt

        [TestMethod]
        public void Initialize15()
        {
            _dataAccess = new DataAccess();
            int m = 15;
            int[,] t = new int[m, m];
            _testTable = new GameTable(m, t);
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _testTable.T�bla[i, j] = r.Next(0, 2);
                }
            }
            _testTable.setP(false);
            _testTable.setE1(false);
            _testTable.setE2(false);

            _model = new GameModel(_dataAccess);
        }
        [TestMethod]
        public void LoadTest_15()
        {
            Initialize15();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def15.txt");
            Assert.AreEqual(_testTable.T�bla[_model.PLAYER.Pos[0], _model.PLAYER.Pos[1]],
                            _model.Table.T�bla[_model.PLAYER.Pos[0], _model.PLAYER.Pos[1]]);

            Assert.AreEqual(_testTable.T�bla[_model.ENEMY1.Pos[0], _model.ENEMY1.Pos[1]],
                            _model.Table.T�bla[_model.ENEMY1.Pos[0], _model.ENEMY1.Pos[1]]);

            Assert.AreEqual(_testTable.T�bla[_model.ENEMY2.Pos[0], _model.ENEMY2.Pos[1]],
                            _model.Table.T�bla[_model.ENEMY2.Pos[0], _model.ENEMY2.Pos[1]]);
        }

        [TestMethod]
        public void MovePlayer_And_PlayerDie_GameOver_Test_15()
        {
            Initialize11();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def15.txt");
            _model.MovePlayer('s');
            Assert.AreEqual(_model.Table.T�bla[1, 7], 3);
            _model.MovePlayer('d');
            Assert.IsTrue(_model.IsGameOver); // akn�ra l�pett 
        }

        [TestMethod]
        public void EnemiesMove_And_Die_GameOver_Test_15()
        {
            Initialize15();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def15.txt");
            _model.Enemy1Move(1);
            _model.Enemy2Move(1);
            Assert.AreEqual(_model.Table.T�bla[13, 0], 2);
            Assert.AreEqual(_model.Table.T�bla[13, 14], 4);
            _model.Enemy1Move(1);
            Assert.IsFalse(_model.ENEMY1.Alive);
            _model.Enemy2Move(1);
            Assert.IsFalse(_model.ENEMY2.Alive);
            Assert.IsTrue(_model.IsGameOver);
        }
        #endregion

        #region 21 teszt
        [TestMethod]
        public void Initialize21()
        {
            _dataAccess = new DataAccess();
            int m = 21;
            int[,] t = new int[m, m];
            _testTable = new GameTable(m, t);
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _testTable.T�bla[i, j] = r.Next(0, 2);
                }
            }
            _testTable.setP(false);
            _testTable.setE1(false);
            _testTable.setE2(false);

            _model = new GameModel(_dataAccess);
        }
        [TestMethod]
        public void LoadTest_21()
        {
            Initialize21();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def21.txt");
            Assert.AreEqual(_testTable.T�bla[_model.PLAYER.Pos[0], _model.PLAYER.Pos[1]],
                            _model.Table.T�bla[_model.PLAYER.Pos[0], _model.PLAYER.Pos[1]]);

            Assert.AreEqual(_testTable.T�bla[_model.ENEMY1.Pos[0], _model.ENEMY1.Pos[1]],
                            _model.Table.T�bla[_model.ENEMY1.Pos[0], _model.ENEMY1.Pos[1]]);

            Assert.AreEqual(_testTable.T�bla[_model.ENEMY2.Pos[0], _model.ENEMY2.Pos[1]],
                            _model.Table.T�bla[_model.ENEMY2.Pos[0], _model.ENEMY2.Pos[1]]);
        }

        [TestMethod]
        public void MovePlayer_And_PlayerDie_GameOver_Test_21()
        {
            Initialize11();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def21.txt");
            _model.MovePlayer('s');
            Assert.IsTrue(_model.IsGameOver); // akn�ra l�pett 
        }

        [TestMethod]
        public void EnemiesMove_And_Die_GameOver_Test_21()
        {
            Initialize15();
            _model.Loaddef("D:/Learn/7. f�l�v/EVA/7.f�l�v/BEAD/Catch/Catch/def21.txt");
            _model.Enemy1Move(1);
            _model.Enemy2Move(1);
            Assert.AreEqual(_model.Table.T�bla[19, 0], 2);
            Assert.AreEqual(_model.Table.T�bla[19, 20], 4);
            _model.Enemy1Move(1);
            Assert.IsFalse(_model.ENEMY1.Alive);
            _model.Enemy2Move(1);
            Assert.IsFalse(_model.ENEMY2.Alive);
            Assert.IsTrue(_model.IsGameOver);
        }

        #endregion

    }
}