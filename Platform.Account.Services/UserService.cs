using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq.Expressions;
using System.Linq;

using Platform.Component.Data;
using Platform.Account.Data;
using Platform.Account.IServices;
using Platform.Account.Data.Repositories;
using System.Web.Security;

namespace Platform.Account.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        #region 构造函数
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        #endregion


        #region 公共方法
        /// <summary>
        ///     获取 当前实体的查询数据集
        /// </summary>
        public IQueryable<User> Entities() {
            return _userRepository.Entities;
        }

        /// <summary>
        ///     插入实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Insert(User entity, bool isSave = true)
        {
            return _userRepository.Insert(entity, isSave);
        }


        /// <summary>
        ///     批量插入实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Insert(IEnumerable<User> entities, bool isSave = true)
        {
            return _userRepository.Insert(entities, isSave);
        }

        /// <summary>
        ///     删除指定编号的记录
        /// </summary>
        /// <param name="id"> 实体记录编号 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(object id, bool isSave = true)
        {
            return _userRepository.Delete(id, isSave);
        }

        /// <summary>
        ///     删除实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(User entity, bool isSave = true)
        {
            return _userRepository.Delete(entity, isSave);
        }

        /// <summary>
        ///     删除实体记录集合
        /// </summary>
        /// <param name="entities"> 实体记录集合 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(IEnumerable<User> entities, bool isSave = true)
        {
            return _userRepository.Delete(entities, isSave);
        }

        /// <summary>
        ///     删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate"> 查询条件谓语表达式 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Delete(Expression<Func<User, bool>> predicate, bool isSave = true)
        {
            return _userRepository.Delete(predicate, isSave);
        }

        /// <summary>
        ///     更新实体记录
        /// </summary>
        /// <param name="entity"> 实体对象 </param>
        /// <param name="isSave"> 是否执行保存 </param>
        /// <returns> 操作影响的行数 </returns>
        public int Update(User entity, bool isSave = true)
        {
            return _userRepository.Update(entity, isSave);
        }

        /// <summary>
        ///     查找指定主键的实体记录
        /// </summary>
        /// <param name="key"> 指定主键 </param>
        /// <returns> 符合编号的记录，不存在返回null </returns>
        public User GetByKey(object key)
        {
            return _userRepository.GetByKey(key);
        }

        #endregion

        public bool ValidateUser(string loginName, string password)
        {
            string hashPassword=FormsAuthentication.HashPasswordForStoringInConfigFile(password,"md5");
            int count = _userRepository.Entities.Where(x => x.LoginName == loginName && x.Password == hashPassword).Count();
            if (count > 0)
                return true;
            return false;
        }


        public User GetUserInfoByLoginName(string loginName)
        {
           return _userRepository.Entities.SingleOrDefault(x => x.LoginName == loginName);
        }
    }
}