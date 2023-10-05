using OnlineSchool.Models;

namespace BookShop.DataAccess.Repository.IRepository
{
	public interface IUserRepository : IRepository<User>
	{
		void Update(User category);
	}
}
