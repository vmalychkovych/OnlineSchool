using BookShop.DataAccess.Repository.IRepository;
using OnlineSchool.DB.AppDBContext;
using OnlineSchool.Models;


namespace BookShop.DataAccess.Repository
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		private readonly ApplicationDbContext _db;
		public UserRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(User role)
		{
			_db.Update(role);
		}
	}
}
