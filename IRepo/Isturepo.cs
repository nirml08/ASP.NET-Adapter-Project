using adapter.Model;

namespace adapter.IRepo
{
    public interface Isturepo
    {
        public List<student> getall_students();
        public student get_studentbyid(int id);
    }
}
