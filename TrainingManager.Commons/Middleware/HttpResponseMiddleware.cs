using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Commons;

#nullable enable
namespace TrainingManager.Commons.Middleware
{
	public static class CatchExceptionExtention
	{
		public static IApplicationBuilder UseExceptionToHttpResponse(this IApplicationBuilder app, Action<Exception, HttpContext>? onException = null) =>
			app.UseMiddleware<HttpResponseMiddleware>(onException);
	}
	public class HttpResponseMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly Action<Exception, HttpContext>? _onException;
		public HttpResponseMiddleware(RequestDelegate next, Action<Exception, HttpContext>? onException = null)
		{
			_next = next;
			_onException = onException;
		}
		public async Task Invoke(HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);
			}
			catch (KeyNotFoundException e)
			{
				httpContext.Response.StatusCode = 404;
				await httpContext.Response.WriteAsync(e.Message);
				_onException?.Invoke(e, httpContext);
			}
			catch (ArgumentException e)
			{
				httpContext.Response.StatusCode = 400;
				await httpContext.Response.WriteAsync(e.Message);
				_onException?.Invoke(e, httpContext);
			}
			catch (Exception e)
			{
				httpContext.Response.StatusCode = 500;
				await httpContext.Response.WriteAsync(e.FullInfo(true));
				_onException?.Invoke(e, httpContext);
			}
		}
	}
}
