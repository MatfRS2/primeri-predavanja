﻿using _03_clean_architecture_ardalis.UseCases.Contributors;
using _03_clean_architecture_ardalis.UseCases.Contributors.List;

namespace _03_clean_architecture_ardalis.Infrastructure.Data.Queries;

public class ListContributorsQueryService(AppDbContext _db) : IListContributorsQueryService
{
  // You can use EF, Dapper, SqlClient, etc. for queries -
  // this is just an example

  public async Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    // NOTE: This will fail if testing with EF InMemory provider!
    var result = await _db.Database.SqlQuery<ContributorDTO>(
      $"SELECT Id, Name, PhoneNumber_Number AS PhoneNumber FROM Contributors") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}