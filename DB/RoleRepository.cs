using BookShop.DataAccess.Repository.IRepository;
using OnlineSchool.DB.AppDBContext;
using OnlineSchool.Models;


namespace BookShop.DataAccess.Repository
{
	public class RoleRepository : Repository<User>, IRoleRepository
	{
		private readonly ApplicationDbContext _db;
		public RoleRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(User role)
		{
			_db.Update(role);
		}
	}
}
