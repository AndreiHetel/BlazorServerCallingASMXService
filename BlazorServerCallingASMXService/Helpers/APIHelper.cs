using System.ServiceModel;
using WSCalculator;
namespace BlazorServerCallingASMXService.Helpers;

public class APIHelper(string baseURL)
{
    private readonly EndpointAddress? _endpointAddress = new(baseURL);

    public async Task<int> AddNumbers(int A, int B )
    {        
        using WSCalculator.CalculatorSoapClient client = new(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap, _endpointAddress);
        return await client.AddAsync(A,B);
    }
}
