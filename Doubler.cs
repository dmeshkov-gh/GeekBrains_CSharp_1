using System;
using System.Collections.Generic;
using System.Collections;

public class Doubler
{
    private int _current = 1;
    private int count = 0;

    public int Current
    {
        get => return _current;
    }
    public int Count
    {
        get => return count;
    }
    public int MinimalSteps
    {
        get
        {
            int finish = Finish;
            int steps = 0;
            while (finish != 1)
            {
                finish = finish % 2 == 0 ? finish / 2 : finish - 1;
                steps++
            }
            return steps;
        }
    }
    public int Finish { get; private set; }
    Stack<int> history = new Stack<int>();

    public Doubler()
    {
        Finish = new Random().Next(10, 101);
    }
    public void Plus()
    {
        history.Push(Current);
        Current++;
        Count++;
    }
    public void Multiply()
    {
        history.Push(Current);
        Current * 2;
        Count++;
    }
    public void Back()
    {
        history?.Pop();
    }
    public void Reset()
    {
        history.Clear();
        Current = 1;
        Count = 0;
    }
    public override string ToString()
    {
        return current.ToString();
    }
}
