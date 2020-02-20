using EFCApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCApp
{
    static class Operations
    {
        public static void Create(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static User Read(int id)
        {
            using (Context context = new Context())
            {
                foreach (User user in context.Users)
                {
                    if (user.Id == id)
                        return user;
                }
                return null;
            }
        }
        public static void Update(User user)
        {
            using (Context context = new Context() )
            {
                context.Users.Update(user);
                context.SaveChanges();
            }

        }
        public static void Delete(User user)
        {
            using(Context context = new Context())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

    }
}
