using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;

public class Fraction{

    private int _bottumNumber;
    private int _topNumber;

    public Fraction(){

       _topNumber = 1;
       _bottumNumber = 1;
    }

    public Fraction(int wholeNumber){

        _topNumber = wholeNumber;
        _bottumNumber = 1;
   
    }

    public Fraction(int top, int bottom ){

        _topNumber = top;
        _bottumNumber = bottom;

    }

    public string GetFractionString(){

        string text = $"{_topNumber}/{_bottumNumber}";
        return text;
    }

    public double GetDecimalString(){

        return (double)_topNumber /(double)_bottumNumber;
    }
}