﻿using System.Windows;
using System.Windows.Controls;
using Chess_Logic;

namespace Chess_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Image[,] pieceImages = new Image[8, 8];

        private GameState gameState;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();

            gameState = new GameState(Player.White, Board.Initial());
            DrawBoard(gameState.Board);
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int  j = 0; j < 8; j++)
                {
                    Image image = new Image();
                    pieceImages[i, j] = image;
                    PieceGrid.Children.Add(image);
                }
            }
        }
        private void DrawBoard(Board board)
        {
            for(int i = 0;i < 8;i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Piece piece = board[i , j];
                    pieceImages[i ,j].Source = Images.GetImage(piece);
                }
            }
        }

        private void ImageBrush_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
