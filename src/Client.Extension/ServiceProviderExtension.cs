﻿using Armut.Iterable.Client.Contracts;
using Armut.Iterable.Client.Core;
using Microsoft.Extensions.DependencyInjection;
#if NETSTANDARD2
using System;
#endif

namespace Armut.Iterable.Client.Extension
{
    public static class ServiceProviderExtension
    {

        public static void AddIterableClient(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddSingleton<IRestClient, RestClient>()
                .AddTransient<IUserClient, UserClient>()
                .AddTransient<ISubscriptionClient, SubscriptionClient>()
                .AddTransient<IInAppClient, InAppClient>()
                .AddTransient<IListClient, ListClient>()
                .AddTransient<IEventClient, EventClient>()
                .AddTransient<ICommerceClient, CommerceClient>();
        }

#if NETSTANDARD2
        public static void AddIterableClient(this IServiceCollection serviceCollection, string apiKey)
        {
            serviceCollection
                .AddHttpClient<IRestClient, RestClient>(client =>
                {
                    client.BaseAddress = new Uri("https://api.iterable.com/");
                    client.DefaultRequestHeaders.Add("Api-Key", apiKey);
                });

            serviceCollection
                .AddTransient<IUserClient, UserClient>()
                .AddTransient<ISubscriptionClient, SubscriptionClient>()
                .AddTransient<IInAppClient, InAppClient>()
                .AddTransient<IListClient, ListClient>()
                .AddTransient<IEventClient, EventClient>()
                .AddTransient<ICommerceClient, CommerceClient>();
        }
#endif
    }
}