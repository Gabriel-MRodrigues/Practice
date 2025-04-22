using LMS_BL;

namespace LMS_UnitTests;

[TestClass]
public sealed class UserTests
{
    private List<User> _users;
    [TestInitialize]
    public void Setup()
    {
        _users = new List<User>()
        {
            new Student("Gabriel", 508865),
            new Teacher("Nick", 123456),
            new Librarian("Sarah", 654321)
        };
    }
    [TestMethod]
    public void Test_If_User_Role_Matches_Type()
    {
        // it means that every time we instanciate a different type of user,
        // their Role matches their Type.
        // For example: new Student X has Role of "Student" and Type of Student
        foreach(User user in _users)
        {
            Assert.AreEqual(user.Role, user.GetType().Name);
        }
    }
}
