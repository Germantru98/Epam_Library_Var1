using DAL;
using Entities;
using System.Collections.Generic;

namespace BL
{
    public class UserLibraryBL
    {
        private UserLibraryDao userLibraryDao = new UserLibraryDao();

        public IEnumerable<UserLibraryBook> GetBooksByID(int Reader_ID)
        {
            return userLibraryDao.GetBooksByID(Reader_ID);
        }
    }
}