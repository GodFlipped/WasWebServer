// -----------------------------------------------------------------------
// <copyright file="CamelCaseJsonConverter.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Buffers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

namespace WasWebServerCore.Filters
{
    /// <summary>
    /// CustomJsonConverter
    /// </summary>
    ///
    /// 以前的 Controller 返回的 JSON 数据都是 PascalCase 格式,
    /// 为了让新的 Controller 支持返回 camelCase 格式的 JSON 数据, 同时不影响以前的代码,
    /// 特添加该类, 添加到需要返回 camelCase 格式的数据的 Controller 上面
    /// 
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CamelCaseJsonConverter : ActionFilterAttribute
    {
        /// <summary>
        /// OnActionExecuted
        /// </summary>
        /// <param name="context">context</param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context?.Result == null)
            {
                return;
            }

            var settings = JsonSerializerSettingsProvider.CreateSerializerSettings();
            settings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

            var result = context.Result as OkObjectResult;
            result?.Formatters.Add(
                new NewtonsoftJsonOutputFormatter(settings, ArrayPool<char>.Shared, new MvcOptions()));
        }
    }
}