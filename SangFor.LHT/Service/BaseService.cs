using IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Service
{
	public class BaseService : IBaseService
	{
		#region Identity

		/// <summary>
		/// 只允许子类可以访问
		/// </summary>
		protected DbContext Context { get; private set; }

		/// <summary>
		/// 构造函数注入
		/// </summary>
		/// <param name="context"></param>
		public BaseService(DbContext context)
		{
			Context = context;
		}
		#endregion Identity

		#region Query
		public T Find<T>(string id) where T : class
		{
			return this.Context.Set<T>().Find(id);
		}


		/// <summary>
		/// 这才是合理的做法，上端给条件，这里查询
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="funcWhere"></param>
		/// <returns></returns>
		public IQueryable<T> Query<T>(Expression<Func<T, bool>> funcWhere) where T : class
		{
			return this.Context.Set<T>().Where<T>(funcWhere);
		}
		#endregion

		#region Insert
		/// <summary>
		/// 即使保存  不需要再Commit
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="t"></param>
		/// <returns></returns>
		public T Insert<T>(T t) where T : class
		{

			this.Context.Set<T>().Add(t);
			this.Commit();//写在这里  就不需要单独commit  不写就需要 
			return t;
		}

		public IEnumerable<T> Insert<T>(IEnumerable<T> tList) where T : class
		{
			this.Context.Set<T>().AddRange(tList);
			this.Commit();//一个链接  多个sql
			return tList;
		}
		#endregion

		#region Update
		/// <summary>
		///
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="t"></param>
		public void Update<T>(T t) where T : class
		{

			if (t == null) throw new Exception("t is null");

			this.Context.Set<T>().Attach(t);//将数据附加到上下文，支持实体修改和新实体，重置为UnChanged
			this.Context.Entry<T>(t).State = EntityState.Modified;
			this.Commit();//保存 然后重置为UnChanged
		}

		public void Update<T>(IEnumerable<T> tList) where T : class
		{
			foreach (var t in tList)
			{
				this.Context.Set<T>().Attach(t);
				this.Context.Entry<T>(t).State = EntityState.Modified;
			}
			this.Commit();
		}

		#endregion

		#region Delete
		/// <summary>
		/// 先附加 再删除
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="t"></param>
		public void Delete<T>(T t) where T : class
		{
			if (t == null) throw new Exception("t is null");
			this.Context.Set<T>().Attach(t);
			this.Context.Set<T>().Remove(t);
			this.Commit();
		}

		/// <summary>
		/// 还可以增加非即时commit版本的，
		/// 做成protected
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Id"></param>
		public void Delete<T>(string Id) where T : class
		{
			T t = this.Find<T>(Id);//也可以附加
			if (t == null) throw new Exception("t is null");
			this.Context.Set<T>().Remove(t);
			this.Commit();
		}

		public void Delete<T>(IEnumerable<T> tList) where T : class
		{
			foreach (var t in tList)
			{
				this.Context.Set<T>().Attach(t);
			}
			this.Context.Set<T>().RemoveRange(tList);
			this.Commit();
		}
		#region Other
		public void Commit()
		{
			this.Context.SaveChanges();
		}
		public virtual void Dispose()
		{
			if (this.Context != null)
			{
				this.Context.Dispose();
			}
		}
		#endregion
		#endregion
	}
}
