
    public class Trainee:System.IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id},{Name}";
        }
        int System.IComparable.CompareTo(object obj)
        {
            Trainee Train = obj as Trainee;

            return Id.CompareTo(Train.Id);

        }

    }