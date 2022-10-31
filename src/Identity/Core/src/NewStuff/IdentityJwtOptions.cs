// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace Microsoft.AspNetCore.Identity;

/// <summary>
/// 
/// </summary>
public class IdentityJwtOptions : AuthenticationSchemeOptions
{
    /// <summary>
    /// Gets or sets the parameters used to validate identity tokens.
    /// </summary>
    /// <remarks>Contains the types and definitions required for validating a token.</remarks>
    /// <exception cref="ArgumentNullException">if 'value' is null.</exception>
    public TokenValidationParameters TokenValidationParameters { get; set; } = new TokenValidationParameters();
}
