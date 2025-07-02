using adapter.Model;

namespace adapter.IServices
{
    public interface Istudentservices
    {
        List<student> getall_students();
       student get_studentbyid(int id);
    }
}
