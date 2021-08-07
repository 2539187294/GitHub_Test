
using EF.Model.Models;
using IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Service
{
	public class UserService : BaseService, IUserinfoService
	{
		public UserService(DbContext context) : base(context)
		{
		}


		public IQueryable<User> Query(Expression<Func<User, bool>> funcWhere)
		{
			return base.Query(funcWhere);

		}

		#region Insert
		/// <summary>
		/// 即使保存  不需要再Commit
		/// </summary>
		/// <Userinfoypeparam name="T"></typeparam>
		/// <param name="t"></param>
		/// <returns></returns>
		public User Insert(User userinfo)
		{
			return base.Insert<User>(userinfo);

		}

		public IEnumerable<User> Insert(IEnumerable<User> userinfos)
		{
			this.Context.Set<User>().AddRange(userinfos);
			this.Commit();//一个链接  多个sql
			return userinfos;
		}
		#endregion

		#region Update
		/// <summary>
		///
		/// </summary>
		/// <Userinfoypeparam name="T"></typeparam>
		/// <param name="t"></param>
		public void Update(User userinfo)
		{

			if (userinfo == null) throw new Exception("userinfo is null");

			this.Context.Set<User>().Attach(userinfo);//将数据附加到上下文，支持实体修改和新实体，重置为UnChanged
			this.Context.Entry<User>(userinfo).State = EntityState.Modified;
			this.Commit();//保存 然后重置为UnChanged
		}

		public void Update(IEnumerable<User> userinfos)
		{
			foreach (var userinfo in userinfos)
			{
				this.Context.Set<User>().Attach(userinfo);
				this.Context.Entry<User>(userinfo).State = EntityState.Modified;
			}
			this.Commit();
		}

		#endregion

		#region Delete
		/// <summary>
		/// 先附加 再删除
		/// </summary>
		/// <Userinfoypeparam name="T"></typeparam>
		/// <param name="t"></param>
		public void Delete(User userinfo)
		{
			if (userinfo == null) throw new Exception("userinfo is null");
			this.Context.Set<User>().Attach(userinfo);
			this.Context.Set<User>().Remove(userinfo);
			this.Commit();
		}

		/// <summary>
		/// 还可以增加非即时commit版本的，
		/// 做成protected
		/// </summary>
		/// <Userinfoypeparam name="T"></typeparam>
		/// <param name="Id"></param>
		public void Delete(string Id)
		{
			User t = this.Find<User>(Id);//也可以附加
			if (t == null) throw new Exception("t is null");
			this.Context.Set<User>().Remove(t);
			this.Commit();
		}

		public void Delete(IEnumerable<User> userinfos)
		{
			foreach (var userinfo in userinfos)
			{
				this.Context.Set<User>().Attach(userinfo);
			}
			this.Context.Set<User>().RemoveRange(userinfos);
			this.Commit();
		}
		#endregion


		public void Commit()
		{
			this.Context.SaveChanges();
		}
		public virtual void Dispose()
		{
			if (Context != null)
			{
				this.Context.Dispose();
			}
		}

		public IQueryable<T> Query<T>(Expression<Func<User, bool>> funcWhere)
		{
			throw new NotImplementedException();
		}
	}
}
