using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseDemoApp;

public class AzureDataAccess
{
    private readonly IConfiguration _configuration;

    public AzureDataAccess(IConfiguration configuration)
    {
        _configuration = configuration;

    }

    public async Task<List<T>> LoadData<T, U>(string storedProcedure, 
    U Parameters, string conectionStringName = "default")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(conectionStringName));
        List<T> rows = (await connection.QueryAsync<T>(storedProcedure, Parameters, commandType: CommandType.StoredProcedure)).ToList();
        return rows;

    }
    
        


}
