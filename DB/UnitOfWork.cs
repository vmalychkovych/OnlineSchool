using BookShop.DataAccess.Repository.IRepository;
using OnlineSchool.DB.AppDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _db;
		public IRoleRepository RoleRepository { get; private set; }
		public IUserRepository UserRepository { get; private set; }


        public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			RoleRepository = new RoleRepository(_db);
			UserRepository = new UserRepository(_db);
		}

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
