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
    public enum BinaryOperator
    {
        Mov = 0b000,
        Add = 0b001,
        Mul = 0b010,
        Div = 0b011,
        Mod = 0b100,
        And = 0b101,
        Or = 0b110,
        Xor = 0b111,
    }

    abstract class AsmBinaryOp<T> : Instruction
        where T : AsmBinaryOp<T>, new()
    {

        public readonly uint Op;
        public uint RegDst;
        public uint RegSrc;

        public AsmBinaryOp()
        {
            Op = (uint)(Attribute.GetCustomAttribute(typeof(T), typeof(AsmBinaryOperatorAttribute)) as AsmBinaryOperatorAttribute).Operator;
        }

        public static Instruction Create(uint regdst, ValBase value)
        {
            if (value is ValReg)
            {
                var ins = new T();
                ins.RegDst = regdst;
                ins.RegSrc = (value as ValReg).Index;
                return ins;
            }
            else if (value is ValInstant)
            {
                var val = (value as ValInstant).Val;
                if (val < -(1 << 15) || val >= 1 << 15)
                    return Failed.OutOfRange;
                var ins = new AsmBinaryOpInstant<T>();
                ins.RegDst = regdst;
                ins.Value = (value as ValInstant).Val;
                return ins;
            }
            else
                return Failed.NotImplemented;
        }

        public override void WriteBytes(Stream stream)
        {
            WriteBits(stream, 0, 1);
            WriteBits(stream, 0b0101, 4);
            WriteBits(stream, 0b10, 2);
            WriteBits(stream, Op, 3);
            WriteBits(stream, RegDst, 3);
            WriteBits(stream, RegSrc, 3);
        }
    }

    class AsmBinaryOpInstant<T> : Instruction
    {
        public override int ByteCount => 4;

        public readonly uint Op;
        public uint RegDst;
        public int Value;

        public AsmBinaryOpInstant()
        {
            Op = (uint)(Attribute.GetCustomAttribute(typeof(T), typeof(AsmBinaryOperatorAttribute)) as AsmBinaryOperatorAttribute).Operator;
        }

        public override void WriteBytes(Stream stream)
        {
            WriteBits(stream, 0, 1);
            WriteBits(stream, 0b0101, 4);
            WriteBits(stream, 0, 1);
            WriteBits(stream, 0b000, 3);
            WriteBits(stream, 0, 1);
            WriteBits(stream, Op, 3);
            WriteBits(stream, RegDst, 3);
            WriteBits(stream, Value, 16);
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    class AsmBinaryOperatorAttribute : Attribute
    {
        public readonly BinaryOperator Operator;

        public AsmBinaryOperatorAttribute(BinaryOperator @operator)
        {
            Operator = @operator;
        }
    }

    [AsmBinaryOperator(BinaryOperator.Mov)]
    class AsmMov : AsmBinaryOp<AsmMov>
    {
        public static Instruction Create(uint regdst, ValBase value)
        {
            var ins = AsmMovCompressed.Create(regdst, value);
            if (ins.Success)
                return ins;
            return AsmBinaryOp<AsmMov>.Create(regdst, value);
        }
    }

    [AsmBinaryOperator(BinaryOperator.Add)]
    class AsmAdd : AsmBinaryOp<AsmAdd>
    { }

    [AsmBinaryOperator(BinaryOperator.Mul)]
    class AsmMul : AsmBinaryOp<AsmMul>
    { }

    [AsmBinaryOperator(BinaryOperator.Div)]
    class AsmDiv : AsmBinaryOp<AsmDiv>
    { }

    [AsmBinaryOperator(BinaryOperator.Mod)]
    class AsmMod : AsmBinaryOp<AsmMod>
    { }

    [AsmBinaryOperator(BinaryOperator.And)]
    class AsmAnd : AsmBinaryOp<AsmAnd>
    { }

    [AsmBinaryOperator(BinaryOperator.Or)]
    class AsmOr : AsmBinaryOp<AsmOr>
    { }

    [AsmBinaryOperator(BinaryOperator.Xor)]
    class AsmXor : AsmBinaryOp<AsmXor>
    { }

    class AsmMovCompressed : Instruction
    {
        public uint RegDst;
        public int Value;

        public static Instruction Create(uint regdst, ValBase value)
        {
            if (!(value is ValInstant))
                return Failed.InvalidArgument;
            var val = (value as ValInstant).Val;
            if (val < -(1 << 6) || val >= 1 << 6)
                return Failed.OutOfRange;
            var ins = new AsmMovCompressed();
            ins.RegDst = regdst;
            ins.Value = val;
            return ins;
        }

        public override void WriteBytes(Stream stream)
        {
            WriteBits(stream, 0, 1);
            WriteBits(stream, 0b0101, 4);
            WriteBits(stream, 0, 1);
            WriteBits(stream, RegDst, 3);
            WriteBits(stream, Value, 7);
        }
    }
}
