using AdminUI.Code.Web;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AdminUI.Date.Repostiory
{

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> QueryById(object objId);
        Task<TEntity> QueryById(object objId, bool blnUseCache = false);
        Task<bool> Add(TEntity model);

        Task<int> SubmitForm(TEntity model, TEntity models);
        Task<bool> DeleteById(object id);
        Task<bool> Delete(TEntity model);
        Task<bool> DeleteByIds(object[] ids);
        Task<bool> Update(TEntity model);
        Task<bool> Update(TEntity entity, string strWhere);
        Task<bool> Update(TEntity entity, List<string> lstColumns = null, List<string> lstIgnoreColumns = null, string strWhere = "");
        Task<List<TEntity>> Query();
     
        Task<List<TEntity>> Query(object id);
        Task<List<TEntity>> Query(Paginated paginated);

        Task<List<TEntity>> Query(string strWhere, Paginated paginated);

        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Paginated paginated);

        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression);
        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, string strOrderByFileds);
        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Expression<Func<TEntity, object>> orderByExpression, bool isAsc = true);
        Task<List<TEntity>> Query(string strWhere, string strOrderByFileds);
        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, Expression<Func<TEntity, object>> strOrderByFileds, int intTop);
        Task<List<TEntity>> Query(string strWhere, int intTop, string strOrderByFileds);
        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExpression, int intPageIndex, int intPageSize, string strOrderByFileds);
        Task<List<TEntity>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFileds);
        Task<List<TEntity>> QueryPage(Expression<Func<TEntity, bool>> whereExpression, int intPageIndex = 0, int intPageSize = 20, string strOrderByFileds = null);
    }
}
