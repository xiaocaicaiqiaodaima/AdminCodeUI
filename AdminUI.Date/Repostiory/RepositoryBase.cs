using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AdminUI.Code.Web;
using AdminUI.Date.Models;
using Microsoft.EntityFrameworkCore;


namespace AdminUI.Date.Repostiory
{
    /// <summary>
    /// 仓储实现
    /// </summary>
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, new()
    {
        public NFineDBContext _context { get; }

        public RepositoryBase(NFineDBContext context)
        {
            _context = context;
        }
        public async Task<TEntity> QueryById(object objId)
        {
            return await _context.Set<TEntity>().FindAsync(objId);

        }

        public async Task<TEntity> QueryById(object objId, bool blnUseCache = false)
        {
            return await _context.Set<TEntity>().FindAsync(objId, blnUseCache);
        }

        public async Task<bool> Add(TEntity entity)
        {

            await Task.FromResult(_context.Entry<TEntity>(entity).State = EntityState.Added);
            var list = _context.SaveChanges()>0?true:false;
            return list;
        }

     public async Task<int> SubmitForm(TEntity entity, TEntity entitys)
        {
            await Task.FromResult(_context.Entry<TEntity>(entity).State = EntityState.Added);
            await Task.FromResult(_context.Entry<TEntity>(entitys).State = EntityState.Added);
            var list = _context.SaveChanges();
            return list;
           
        }

        public async Task<bool> DeleteById(object id)
        {
            var mode = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Remove(mode);
            var ret = _context.SaveChanges() > 0;
            return ret;
            ;
        }

        public async Task<bool> Delete(TEntity model)
        {
            await Task.FromResult(_context.Entry<TEntity>(model).State = EntityState.Deleted);
            var ret = _context.SaveChanges() > 0;
            return ret;
        }

        public async Task<bool> DeleteByIds(object[] ids)
        {
            var mode = await _context.Set<TEntity>().FindAsync(ids);
            _context.Set<TEntity>().Remove(mode);
            var ret = _context.SaveChanges() > 0;
            return ret;
        }

        public async Task<bool> Update(TEntity model)
        {
            await Task.FromResult(_context.Entry<TEntity>(model).State = EntityState.Modified);
            var ret = _context.SaveChanges() > 0;
            return ret;
        }

        public async Task<bool> Update(TEntity entity, string strWhere)
        {
            await Task.FromResult(_context.Entry<TEntity>(entity).State = EntityState.Modified);
            var ret = _context.SaveChanges() > 0;
            return ret;
        }

        public async Task<bool> Update(TEntity entity,
            List<string> lstColumns = null,
            List<string> lstIgnoreColumns = null,
            string strWhere = "")
        {
            await Task.FromResult(_context.Entry<TEntity>(entity).State = EntityState.Modified);
            var ret = _context.SaveChanges() > 0;
            return ret;
        }
        public async Task<List<TEntity>> SQLQ(string sql) {
            return await _context.Set<TEntity>().FromSqlRaw(sql).ToListAsync();
           
        }
        public async Task<List<TEntity>> Query()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> Query(object id)
        {
            return await _context.Set<List<TEntity>>().FindAsync(id);
        }
        //分页查询
        public async Task<List<TEntity>> Query(Paginated paginated)
        {
            var count = _context.Set<TEntity>().Count();
            paginated.records = count;
            return await (PaginatedList<TEntity>.CreateAsync(_context.Set<TEntity>().AsNoTracking(), paginated.page, paginated.limit));
           
        }
       //分页排序查询
        public async Task<List<TEntity>> Query(string strWhere, Paginated paginated)
        {
            paginated.sord = "asc";
            bool isAsc = paginated.sord.ToLower() == "asc" ? true : false;
            //string[] _order = paginated.sidx.Split(',');
            string[] _order = strWhere.Split(',');
            MethodCallExpression resultExp = null;
            var tempData = await Task.FromResult(_context.Set<TEntity>().AsQueryable());
            foreach (string item in _order)
            {
                string _orderPart = item;
                _orderPart = Regex.Replace(_orderPart, @"\s+", " ");
                string[] _orderArry = _orderPart.Split(' ');
                string _orderField = _orderArry[0];
                bool sort = isAsc;
                if (_orderArry.Length == 2)
                {
                    isAsc = _orderArry[1].ToUpper() == "ASC" ? true : false;
                }
                var parameter = Expression.Parameter(typeof(TEntity), "t");
                var property = typeof(TEntity).GetProperty(_orderField);
                var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                var orderByExp = Expression.Lambda(propertyAccess, parameter);
                resultExp = Expression.Call(typeof(Queryable), isAsc ? "OrderBy" : "OrderByDescending", new Type[] { typeof(TEntity), property.PropertyType }, tempData.Expression, Expression.Quote(orderByExp));
            }
            tempData = tempData.Provider.CreateQuery<TEntity>(resultExp);
            paginated.records = tempData.Count();
            tempData = tempData.Skip<TEntity>(paginated.limit * (paginated.page - 1)).Take<TEntity>(paginated.limit).AsQueryable();
            return tempData.ToList();

        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Paginated paginated)
        {
            var count = await _context.Set<TEntity>().Where(whereExpression).ToListAsync();
            paginated.records = count.Count;
            var cm = await (PaginatedList<TEntity>.CreateAsync(_context.Set<TEntity>().Where(whereExpression).AsNoTracking(), paginated.page, paginated.limit));
            return cm;





        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression)
        {

            return await _context.Set<TEntity>().Where(whereExpression).ToListAsync();
        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression,
            string strOrderByFileds)
        {
            return await _context.Set<TEntity>().Where(whereExpression).ToListAsync();
        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression,
            Expression<Func<TEntity, object>> orderByExpression,
            bool isAsc = true)
        {
            var list = await _context.Set<TEntity>().OrderByDescending(orderByExpression).Where(whereExpression).ToListAsync();

            return list;
        }

        public async Task<List<TEntity>> Query(string strWhere, string strOrderByFileds)
        {
            return await _context.Set<List<TEntity>>().FindAsync(strWhere, strOrderByFileds);
        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Expression<Func<TEntity, object>> strOrderByFileds, int intTop)
        {
            return await _context.Set<TEntity>().OrderByDescending(strOrderByFileds).Take(intTop).Where(whereExpression).ToListAsync();
        }

        public async Task<List<TEntity>> Query(string strWhere, int intTop, string strOrderByFileds)
        {
            return await _context.Set<List<TEntity>>().FindAsync(strWhere, intTop, strOrderByFileds);
        }

        public async Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            return await _context.Set<TEntity>().Where(whereExpression).ToListAsync();
        }

        public async Task<List<TEntity>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFileds)
        {
            return await _context.Set<List<TEntity>>().FindAsync(strWhere, intPageIndex, intPageSize, strOrderByFileds);
        }

        public async Task<List<TEntity>> QueryPage(Expression<Func<TEntity, bool>> whereExpression, int intPageIndex = 0, int intPageSize = 20, string strOrderByFileds = null)
        {
            return await _context.Set<TEntity>().Where(whereExpression).ToListAsync();
        }
    }
}
