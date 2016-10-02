using System;
using System.Collections;
using System.Collections.Generic;

namespace myProject.Coding.ExtensionMethod
{
    /// <summary>
    /// Extension metody zostały stworzone, aby dodawać metody do interfejsów,
    /// oraz sealdowych metod! Są pisanie na publicznych rzeczach w obiekcie, chyba
    /// że użyjemy refleksji 
    /// </summary>
    public static class StringExtension
    {
        public static bool IsPalindrome(this string obj)
        {
            return true;
        }

        public static bool IsPalindrome(this string obj, string napis)
        {
            return true;
        }

        public static bool Whatever<T>(this IEnumerable<T> obj)
        {
            return true;
        }

        //metoda na typ generyczny (dostępna zatem w każdym typie)
        public static T IamExtensive<T>(this T obj) where T:IEnumerable //constraint
        {
            return default(T);
        }


        
    }
}