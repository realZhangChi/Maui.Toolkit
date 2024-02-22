﻿using Booster.DynamicProxy;
using Booster.ExceptionHandle;

namespace Booster.MVVM;

public class ViewModelInterceptor(IExceptionNotifier exceptionNotifier) : BoosterInterceptor
{
    public override async Task InterceptAsync(IBoosterMethodInvocation invocation)
    {
        try
        {
            await invocation.ProcessAsync();
        }
        catch (Exception e)
        {
            await exceptionNotifier.NotifyAsync(e);
        }
    }
}