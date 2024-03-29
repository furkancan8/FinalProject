﻿using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Business.Constans;

namespace Business.BusinessAspect.Autofac
{
    //JWT İÇİN KULLANILIR
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');//gelen rolleri parçalara ayır array at
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)//metotdan önce çalıştır
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();//o an kullanıcın rollerini bul
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))//claim içinde _roles varsa dön
                {
                    return; 
                }
            }
            throw new Exception(Messages.AuthorizationDenied);//hata ver
        }
    }
}
