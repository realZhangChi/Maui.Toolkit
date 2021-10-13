﻿namespace Maui.Toolkit.WeChat.Services.Identity;

public class NullUserInfoService : IUserInfoService
{
    public Task<UserInfo?> GetUserInfoFromWeChatAsync(string appId, string? openId = null)
    {
        return Task.FromResult((UserInfo?)null);
    }
}
