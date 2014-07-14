using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

using Platform.Component.Data;
using Platform.Account.Data;
using Platform.Account.IServices;
using Platform.Account.Data.Repositories;

namespace Platform.Account.Services
{
    public class UserAuthorityService : IUserAuthorityService
    {
        private readonly IUserAuthorityRepository _userAuthorityRepository;
        private readonly IMenuRepository _menuRepository;
        private const int SYS_MENU_ROOT_ID = 1;
        private const int CENTER_MENU_ROOT_ID = 2;

        #region 构造函数
        public UserAuthorityService(IUserAuthorityRepository userAuthorityRepository, IMenuRepository menuRepository)
        {
            this._userAuthorityRepository = userAuthorityRepository;
            this._menuRepository = menuRepository;
        }
        #endregion


        #region 公共方法

        /// <summary>
        ///     插入实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Insert(UserAuthority entity, bool isSave = true)
        {
            return _userAuthorityRepository.Insert(entity, isSave);
        }


        /// <summary>
        ///     批量插入实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Insert(IEnumerable<UserAuthority> entities, bool isSave = true)
        {
            return _userAuthorityRepository.Insert(entities, isSave);
        }

        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(object id, bool isSave = true)
        {
            return _userAuthorityRepository.Delete(id, isSave);
        }

        /// <summary>
        ///     删除实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(UserAuthority entity, bool isSave = true)
        {
            return _userAuthorityRepository.Delete(entity, isSave);
        }

        /// <summary>
        ///     删除实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(IEnumerable<UserAuthority> entities, bool isSave = true)
        {
            return _userAuthorityRepository.Delete(entities, isSave);
        }

        /// <summary>
        ///     删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate"> 查询条件谓语表达式 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(Expression<Func<UserAuthority, bool>> predicate, bool isSave = true)
        {
            return _userAuthorityRepository.Delete(predicate, isSave);
        }

        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Update(UserAuthority entity, bool isSave = true)
        {
            return _userAuthorityRepository.Update(entity, isSave);
        }

        /// <summary>
        ///     查找指定主键的实体记录
        /// </summary>
        /// <param name="key"> 指定主键 </param>
        /// <returns> 符合编号的记录，不存在返回null </returns>
        public UserAuthority GetByKey(object key)
        {
            return _userAuthorityRepository.GetByKey(key);
        }

        #endregion

        public IList<Menu> GetAllSysMenus(bool includeDeleted = false)
        {
            var menus = _menuRepository.Entities.Where(x => x.IsDeleted == includeDeleted &&x.ParentID==null&& x.MenuType == SYS_MENU_ROOT_ID).OrderByDescending(x => x.OrderCode).ToList();
            return menus;
        }

        public IList<Menu> GetAllCenterMenus(bool includeDeleted = false)
        {
            return _menuRepository.Entities.Where(x => x.IsDeleted == includeDeleted && x.ParentID == null && x.MenuType == CENTER_MENU_ROOT_ID).OrderBy(x => x.OrderCode).ToList();
        }

        public IList<Menu> GetSysMenusByUserID(long userID, bool includeDeleted = false)
        {
            return _userAuthorityRepository.Entities.Where(x => x.IsDeleted == includeDeleted && x.Menu.ParentID == null && x.UserID == userID && x.Menu.MenuType == SYS_MENU_ROOT_ID).Select(x => x.Menu).OrderByDescending(x => x.OrderCode).ToList();
        }

        public IList<Menu> GetCenterMenusByUserID(long userID, bool includeDeleted = false)
        {
            return _userAuthorityRepository.Entities.Where(x => x.IsDeleted == includeDeleted && x.Menu.ParentID == null && x.UserID == userID && x.Menu.MenuType == CENTER_MENU_ROOT_ID).Select(x => x.Menu).OrderBy(x => x.OrderCode).ToList();
        }
    }
}