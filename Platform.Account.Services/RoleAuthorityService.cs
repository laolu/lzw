﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq.Expressions;

using Platform.Component.Data;
using Platform.Account.Data;
using Platform.Account.IServices;
using Platform.Account.Data.Repositories;

namespace Platform.Account.Services
{
	public class RoleAuthorityService:IRoleAuthorityService
	{
	    private readonly IRoleAuthorityRepository _repository;

        private const long SYS_MENU_ROOT_ID = 1;
        private const long CENTER_MENU_ROOT_ID = 2;

	    #region 构造函数
	    public RoleAuthorityService(IRoleAuthorityRepository repository)
	    {
	       this._repository=repository;
	    }
	    #endregion
	    
	    
		#region 公共方法

        /// <summary>
        ///     插入实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Insert(RoleAuthority entity, bool isSave = true)
        {
            return _repository.Insert(entity, isSave);
        }
        

        /// <summary>
        ///     批量插入实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Insert(IEnumerable<RoleAuthority> entities, bool isSave = true)
        {
            return _repository.Insert(entities, isSave);
        }

        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(object id, bool isSave = true)
        {
            return _repository.Delete(id, isSave);
        }

        /// <summary>
        ///     删除实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(RoleAuthority entity, bool isSave = true)
        {
            return _repository.Delete(entity, isSave);
        }

        /// <summary>
        ///     删除实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(IEnumerable<RoleAuthority> entities, bool isSave = true)
        {
            return _repository.Delete(entities, isSave);
        }

        /// <summary>
        ///     删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate"> 查询条件谓语表达式 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(Expression<Func<RoleAuthority, bool>> predicate, bool isSave = true)
        {
            return _repository.Delete(predicate, isSave);
        }

        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Update(RoleAuthority entity, bool isSave = true)
        {
            return _repository.Update(entity, isSave);
        }

        /// <summary>
        ///     查找指定主键的实体记录
        /// </summary>
        /// <param name="key"> 指定主键 </param>
        /// <returns> 符合编号的记录，不存在返回null </returns>
        public RoleAuthority GetByKey(object key)
        {
            return _repository.GetByKey(key);
        }

        #endregion


        public IList<Menu> GetSysMenusByRoleID(long roleID, bool includeDeleted = false)
        {
            throw new NotImplementedException();
        }

        public IList<Menu> GetCenterMenusByRoleID(long roleID, bool includeDeleted = false)
        {
            throw new NotImplementedException();
        }
    }
}