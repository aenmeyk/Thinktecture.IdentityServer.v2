﻿/*
 * Copyright (c) Dominick Baier.  All rights reserved.
 * see license.txt
 */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Thinktecture.IdentityServer.Protocols;

namespace Thinktecture.IdentityServer.Web.ViewModels
{
    public class SignInModel
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember me?")]
        public bool EnableSSO { get; set; }

        public bool IsSigninRequest
        {
            get
            {
                var rp = new AuthenticationHelper().GetRelyingPartyDetailsFromReturnUrl(this.ReturnUrl);
                return rp != null;
            }
        }
        public string ReturnUrl { get; set; }
        public bool ShowClientCertificateLink { get; set; }
    }
}