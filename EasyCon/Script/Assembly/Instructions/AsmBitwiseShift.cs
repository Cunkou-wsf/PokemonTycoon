﻿using EasyCon.Script.Assembly;
using EasyCon.Script.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCon.Script.Assembly.Instructions
{
    public enum BitwiseShiftOperator
    {
        ShiftLeft = 0,
        ShiftRight = 1,
    }

    abstract class AsmBitwiseShift<T> : Instruction
        where T : AsmBitwiseShift<T>, new()
    {

        public readonly uint Op;
        public uint RegDst;
        public int Value;

        public AsmBitwiseShift()
        {
            Op = (uint)(Attribute.GetCustomAttribute(typeof(T), typeof(AsmBinaryOperatorAttribute)) as AsmBinaryOperatorAttribute).Operator;
        }

        public static Instruction Create(uint regdst, ValBase value)
        {
            if (value is ValReg)
            {
                return Failed.InvalidArgument;
            }
            else
            {
                var val = (value as ValInstant).Val;
                if (val < 0 || val >= 1 << 4)
                    return Failed.OutOfRange;
                var ins = new AsmBinaryOpInstant<T>();
                ins.RegDst = regdst;
                ins.Value = val;
                return ins;
            }
        }

        public override void WriteBytes(Stream stream)
        {
            WriteBits(stream, 0, 1);
            WriteBits(stream, 0b0101, 4);
            WriteBits(stream, 0b110, 3);
            WriteBits(stream, Op, 1);
            WriteBits(stream, RegDst, 3);
            WriteBits(stream, Value, 4);
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class AsmBitwiseShiftOperatorAttribute : Attribute
    {
        public readonly BitwiseShiftOperator Operator;

        public AsmBitwiseShiftOperatorAttribute(BitwiseShiftOperator @operator)
        {
            Operator = @operator;
        }
    }

    [AsmBitwiseShiftOperator(BitwiseShiftOperator.ShiftLeft)]
    class AsmShiftLeft : AsmBitwiseShift<AsmShiftLeft>
    { }

    [AsmBitwiseShiftOperator(BitwiseShiftOperator.ShiftRight)]
    class AsmShiftRight : AsmBitwiseShift<AsmShiftRight>
    { }
}
