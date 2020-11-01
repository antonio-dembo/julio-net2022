
namespace classes
{
    public class Person {
        public Person(){
            Name = "unkwnown" ;
        }

        public Person(string name){
            Name = name;
        }

        // Auto-implemented readonly property
        public string Name {get;}

        public override string ToString(){
            return $"This is {Name}";
        }
    } // Person
} // namespace