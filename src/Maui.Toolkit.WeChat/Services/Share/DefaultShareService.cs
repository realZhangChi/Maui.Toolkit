﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Maui.Toolkit.WeChat.Models.Share;

namespace Maui.Toolkit.WeChat.Services.Share;

public class DefaultShareService : IShareService
{
    private readonly IShareHandler _shareHandler;

    public DefaultShareService(IShareHandler shareHandler)
    {
        _shareHandler = shareHandler;
    }

    public Task ShareImageAsync(ImageMessage message)
    {
        return _shareHandler.ShareImageAsync(message);
    }

    public Task ShareMusicAsync(MusicMessage message)
    {
        return _shareHandler.ShareMusicAsync(message);
    }

    public Task ShareTextAsync(TextMessage message)
    {
        return _shareHandler.ShareTextAsync(message);
    }

    public Task ShareVideoAsync(VideoMessage message)
    {
        return _shareHandler.ShareVideoAsync(message);
    }

    public Task ShareWebPageAsync(WebPageMessage message)
    {
        return _shareHandler.ShareWebPageAsync(message);
    }
}
