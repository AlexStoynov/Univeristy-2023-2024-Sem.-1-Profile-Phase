namespace SchoolApplicastion.Classes
{
    public class Room
    {
        private List<Student> students;
        private int roomCapacity;

        public int RoomNum { get; private set; }

        public Room(int roomNum)
        {
            this.RoomNum = roomNum;
            students = new List<Student>();
            roomCapacity = 24;
        }

        public void AddStudent(string name, int id)
        {
            Student student = new Student(name, id);
            students.Add(student);
        }

        public void RemoveStudent(string name)
        {
            Student studentToRemove = students.Find(x => x.Name == name);
            students.Remove(studentToRemove);
        }

        public void ChangeCapacity(int newCap)
        {
            if (newCap > 0)
            {
                this.roomCapacity = newCap;
            }
            else
            {
                this.roomCapacity = 0;
            }
        }
    }
}