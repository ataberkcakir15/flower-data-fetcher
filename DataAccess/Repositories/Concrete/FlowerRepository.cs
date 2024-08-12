using Core.Models.Response;
using Dapper;
using DataAccess.Queries;
using DataAccess.Repositories.Abstract;
using System.Data.SqlClient;

namespace DataAccess.Repositories.Concrete
{
    public class FlowerRepository : IFlowerRepository
    {
        public async Task<List<GetFlowersInformationResponseModel>> GetFlowerInformationAsync()
        {
            using var connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Flowers;Trusted_Connection=true");
            var response = await connection.QueryAsync<GetFlowersInformationResponseModel>(
                sql: FlowerQueries.GET_FLOWER_INFORMATION,
                commandTimeout: 0);
            return response.ToList();
        }
    }
}
