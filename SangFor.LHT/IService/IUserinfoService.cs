using EF.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace IService
{
	public interface IUserinfoService
	{
		IQueryable<User> Query(Expression<Func<User, bool>> funcWhere);

		#region Insert
		/// <summary>
		/// 即使保存  不需要再Commit
		/// </summary>
		/// <Userinfoypeparam name="T"></typeparam>
		/// <param name="t"></param>
		/// <returns></returns>
		User Insert(User userinfo);

		IEnumerable<User> Insert(IEnumerable<User> userinfos);
		#endregion

		#region Update
		/// <summary>
		///
		/// </summary>
		/// <Userinfoypeparam name="T"></typeparam>
		/// <param name="t"></param>
		void Update(User userinfo);

		void Update(IEnumerable<User> userinfos);

		#endregion

		#region Delete
		void Delete(User userinfo);
		void Delete(string Id);
		void Delete(IEnumerable<User> userinfos);
		#endregion

	}
}
