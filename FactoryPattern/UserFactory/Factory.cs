using UserConcritClass;
using UserInterface;

namespace UserFactory
{
    public static class Factory
    {
        public static IUser Generate(int userType)
        {
            IUser _user;
            if (userType == 1)
                _user = new Administrator();
            else if (userType == 2)
                _user = new CustomerSupport();
            else
                _user = null;

            return _user;
        }
    }
}
