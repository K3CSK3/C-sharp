﻿global using FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Infrastructure;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using Serilog;
global using Serilog.Events;
global using Serilog.Templates;
global using Serilog.Templates.Themes;
global using Solution.Common.Extensions;
global using Solution.Common.Interfaces;
global using Solution.Common.Models.Exceptions;
global using Solution.Common.Models.Settings;
global using Solution.Services;
global using Solution.Validators.Extensions;
global using Solution.Validators.Interceptors;
global using Swashbuckle.AspNetCore.SwaggerUI;
global using System.Diagnostics;
global using System.IdentityModel.Tokens.Jwt;
global using System.Net;
global using System.Reflection;
global using System.Runtime.ExceptionServices;
global using System.Text;
global using Solution.Common.Models.View;