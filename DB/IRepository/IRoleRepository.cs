using OnlineSchool.Models;

namespace BookShop.DataAccess.Repository.IRepository
{
	public interface IRoleRepository : IRepository<User>
	{
		void Update(User category);
	}
}
