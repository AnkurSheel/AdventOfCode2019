﻿using System;
using System.Collections.Generic;

namespace AdventOfCode2019.Day3
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CrossedWires
    {
        private int[,] _grid;
        private readonly Coordinate _center = new Coordinate();

        public int GetDistanceToClosestIntersection(List<string> data)
        {
            var dimension = Convert.ToInt32(data[0]);
            var wire1 = data[1];
            var wire2 = data[2];

            _grid = new int[dimension * 2 , dimension * 2];

            _center.X = dimension;
            _center.Y = dimension;

            var intersections = new List<Coordinate>();
            MarkWireOnGrid(wire1, (x, y) => _grid[x, y] = 1);
            MarkWireOnGrid(wire2, (x, y) =>
            {
                if (_grid[x, y] == 1)
                {
                    _grid[x, y] = 3;
                    intersections.Add(new Coordinate {X = x, Y = y});
                }

                _grid[x, y] = 2;
            });
            int bestDistance = Int32.MaxValue;
            foreach (var intersection in intersections)
            {
                var distance = Math.Abs(intersection.Y - _center.Y) + Math.Abs(intersection.X - _center.X);
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                }
            }


            return bestDistance;
        }

        private void MarkWireOnGrid(string wire, Action<int, int> callback)
        {
            var currentX = _center.X;
            var currentY = _center.Y;

            var tokens = wire.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in tokens)
            {
                var direction = token[0];
                var units = Convert.ToInt32(token.Substring(1));
                for (var i = 0; i < units; i++)
                {
                    if (direction == 'U')
                    {
                        currentY--;
                    }
                    else if (direction == 'D')
                    {
                        currentY++;
                    }
                    else if (direction == 'L')
                    {
                        currentX--;
                    }
                    else if (direction == 'R')
                    {
                        currentX++;
                    }

                    callback(currentX, currentY);
                }
            }
        }
    }
}