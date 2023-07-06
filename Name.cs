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

        public override string ToString()
        {
            return _name;
        }



        
    }
    
}