namespace api.Controllers.Values;
public class GetValues : EndpointWithoutRequest<GetValuesResponse>
{
    public override void Configure()
    {
        Get("values");
        Permissions("ManageInventory");
    }


    public override async Task HandleAsync(CancellationToken ct)
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        var response = new GetValuesResponse() { Values = Enumerable.Range(0, 100).ToList() };
        await SendAsync(response);
    }
}
