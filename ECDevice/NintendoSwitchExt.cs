﻿using System;
using System.IO.Ports;

namespace ECDevice
{
    public partial class NintendoSwitch
    {
        private static NintendoSwitch _instance;

        public static string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public static NintendoSwitch GetInstance()
        {
            if (_instance == null)
                _instance = new NintendoSwitch();
            return _instance;
        }

        public static DirectionKey GetDirectionFromHAT(HAT hat)
        {
            return hat switch
            {
                HAT.TOP => DirectionKey.Up,
                HAT.TOP_RIGHT => DirectionKey.Up | DirectionKey.Right,
                HAT.RIGHT => DirectionKey.Right,
                HAT.BOTTOM_RIGHT => DirectionKey.Down | DirectionKey.Right,
                HAT.BOTTOM => DirectionKey.Down,
                HAT.BOTTOM_LEFT => DirectionKey.Down | DirectionKey.Left,
                HAT.LEFT => DirectionKey.Left,
                HAT.TOP_LEFT => DirectionKey.Up | DirectionKey.Left,
                _ => DirectionKey.None,
            };
        }

        static void GetXYFromDirection(double degree, out byte x, out byte y)
        {
            double radian = degree * Math.PI / 180;
            double dy = Math.Round((Math.Tan(radian) * Math.Sign(Math.Cos(radian))).Clamp(-1, 1), 4);
            double dx = radian == 0 ? 1 : Math.Round((1 / Math.Tan(radian) * Math.Sign(Math.Sin(radian))).Clamp(-1, 1), 4);
            x = (byte)((dx + 1) / 2 * (STICK_MAX - STICK_MIN) + STICK_MIN);
            y = (byte)((-dy + 1) / 2 * (STICK_MAX - STICK_MIN) + STICK_MIN);
        }

        static void GetXYFromDirection(DirectionKey dkey, out byte x, out byte y)
        {
            if (dkey.HasFlag(DirectionKey.Left) && !dkey.HasFlag(DirectionKey.Right))
                x = STICK_MIN;
            else if (!dkey.HasFlag(DirectionKey.Left) && dkey.HasFlag(DirectionKey.Right))
                x = STICK_MAX;
            else
                x = STICK_CENTER;
            if (dkey.HasFlag(DirectionKey.Up) && !dkey.HasFlag(DirectionKey.Down))
                y = STICK_MIN;
            else if (!dkey.HasFlag(DirectionKey.Up) && dkey.HasFlag(DirectionKey.Down))
                y = STICK_MAX;
            else
                y = STICK_CENTER;
        }

        static HAT GetHATFromDirection(DirectionKey dkey)
        {
            if (dkey.HasFlag(DirectionKey.Up) && dkey.HasFlag(DirectionKey.Down))
                dkey &= ~DirectionKey.Up & ~DirectionKey.Down;
            if (dkey.HasFlag(DirectionKey.Left) && dkey.HasFlag(DirectionKey.Right))
                dkey &= ~DirectionKey.Left & ~DirectionKey.Right;
            if (dkey == DirectionKey.Up)
                return HAT.TOP;
            if (dkey == DirectionKey.Down)
                return HAT.BOTTOM;
            if (dkey == DirectionKey.Left)
                return HAT.LEFT;
            if (dkey == DirectionKey.Right)
                return HAT.RIGHT;
            if (dkey.HasFlag(DirectionKey.Up) && dkey.HasFlag(DirectionKey.Left))
                return HAT.TOP_LEFT;
            if (dkey.HasFlag(DirectionKey.Up) && dkey.HasFlag(DirectionKey.Right))
                return HAT.TOP_RIGHT;
            if (dkey.HasFlag(DirectionKey.Down) && dkey.HasFlag(DirectionKey.Left))
                return HAT.BOTTOM_LEFT;
            if (dkey.HasFlag(DirectionKey.Down) && dkey.HasFlag(DirectionKey.Right))
                return HAT.BOTTOM_RIGHT;
            return HAT.CENTER;
        }
    }
}
