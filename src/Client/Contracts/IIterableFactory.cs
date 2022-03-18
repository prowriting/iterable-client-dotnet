namespace Armut.Iterable.Client.Contracts
{
    public interface IIterableFactory
    {
        UserClient CreateUserClient();
        SubscriptionClient CreateSubscriptionClient();

        CommerceClient CreateCommerceClient();

        ListClient CreateListClient();

        EventClient CreateEventClient();
        
        InAppClient CreateInAppClient();
    }
}