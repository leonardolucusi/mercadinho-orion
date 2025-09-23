using System;
using System.ComponentModel;
using System.Reflection;

namespace Mapper;
public class Class1
{
    public static void Test()
    {
        Console.WriteLine("HELLO WORLD");
    }
    
    public static T MapFrom<T, U>(T source, U destination)
    where T : class
    where U : class
    {
        Console.WriteLine(source);
        return source;
    }
    
    // public static T MapFromType<T>(T source)
    // where T : notnull
    // {
    //     int test = 2;
    //     switch (source)
    //     { 
    //         case typeof(T).IsAssignableFrom(test.Type):
    //             break;
    //     } 
    //     return source;
    // }
    
    public static TTarget ConvertValue<TSource, TTarget>(TSource value)
    {
        if (value == null)
        {
            return default(TTarget);;
        }
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(TSource));
        if(converter != null && converter.CanConvertTo(typeof(TTarget)))
            return (TTarget)converter.ConvertTo(value, typeof(TTarget));
        
        return default;
    }   
}