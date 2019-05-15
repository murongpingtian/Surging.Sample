﻿using Hl.Core.Maintenance;
using Hl.Identity.IApplication.Roles.Dtos;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using System;
using System.Threading.Tasks;

namespace Hl.Identity.IApplication.Roles
{
    [ServiceBundle("v1/api/role/{service}")]
    public interface IRoleApplication : IServiceKey
    {
        /// <summary>
        /// 创建角色接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Service(Director = Maintainer.Liuhll, Date = "2019-5-15", Name = "创建角色接口")]
        Task<string> Create(CreateRoleInput input);

        /// <summary>
        /// 更新角色接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Service(Director = Maintainer.Liuhll, Date = "2019-5-15", Name = "更新角色接口")]
        Task<string> Update(UpdateRoleInput input);
    }
}
