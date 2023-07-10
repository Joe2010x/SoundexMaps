namespace SoundexMap
{
    public class Name
    {
        private string _name;

        public Name (string input) 
        {
            _name = input;
        }

        public char Initial {get { return  _name[0];} }

        public string Remains {get {return _name.Substring(1);}}

        public Name  RemoveConsecutiveConsonants ()
        {
            var result ="";
            for (var i=0; i< Remains.Length-1; i++)
            {
                result += Remains[i];
                if (Remains.Substring(i,2).ToLower() == "ck") i++;
            }
            result += Remains.Substring(Remains.Length-2) == "ck" ? "" : Remains.Last().ToString();
            return new Name(Initial + result);
        } 

        public Name RemoveAllVowels ()
        {
            var result = "";
            var vowelSet = new List<string>() {"a", "e","i","o","u","y","w","h"};
            foreach (var charx in Remains)
            {
                result += vowelSet.Contains(charx.ToString().ToLower()) ? "" : charx;
            }
            return new Name (Initial + result);
        }

        public Name ReplaceByDigits ()
        {
            var case1 = "bfpv";
            var case2 = "cgjkqsxz";
            var case3 = "df";
            var case4 = "l";
            var case5 = "mn";
            var case6 = "r";
            var result = "";
            foreach (var item in Remains)
            {
                if (case1.Contains(item)) result+= 1;
                if (case2.Contains(item)) result+= 2;
                if (case3.Contains(item)) result+= 3;
                if (case4.Contains(item)) result+= 4;
                if (case5.Contains(item)) result+= 5;
                if (case6.Contains(item)) result+= 6;
               
            }
            return new Name (Initial+result);
        }

        public Name EndingZero ()
        {
            while (_name.Length<=3)
                _name += "0";
            return new Name(_name);
        }

        public override string ToString()
        {
            return _name;
        }



        
    }
    
}