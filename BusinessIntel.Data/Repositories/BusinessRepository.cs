using BusinessIntel.Core.Interfaces;
using BusinessIntel.Core.Models;
using BusinessIntel.Core.Results;
using BusinessIntel.Data.Context;
using BusinessIntel.Data.Mappers;
using Microsoft.EntityFrameworkCore;

namespace BusinessIntel.Data.Repositories;

public sealed class BusinessRepository : IBusinessRepository
{
    private readonly AppDbContext _context;

    public BusinessRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<RepositoryResult> AddAsync(Business business)
    {
        var entity = BusinessMapper.ToEntity(business);

        await _context.Businesses.AddAsync(entity);
        await _context.SaveChangesAsync();

        return RepositoryResult.Ok("Business added.");
    }

    public async Task<List<Business>> GetAllAsync()
    {
        var entities =
            await _context.Businesses.ToListAsync();

        return entities
            .Select(BusinessMapper.ToModel)
            .ToList();
    }

    public async Task<Business?> GetByIdAsync(Guid id)
    {
        var entity =
            await _context.Businesses
                .FirstOrDefaultAsync(x => x.Id == id);

        return entity is null
            ? null
            : BusinessMapper.ToModel(entity);
    }

    public async Task<RepositoryResult> DeleteAsync(Guid id)
    {
        var entity =
            await _context.Businesses
                .FirstOrDefaultAsync(x => x.Id == id);

        if (entity is null)
            return RepositoryResult.Fail("Business not found.");

        _context.Businesses.Remove(entity);

        await _context.SaveChangesAsync();

        return RepositoryResult.Ok("Business deleted.");
    }

    public async Task<RepositoryResult> UpdateAsync(Business business)
    {
        var entity =
            await _context.Businesses
                .FirstOrDefaultAsync(x => x.Id == business.Id);

        if (entity is null)
            return RepositoryResult.Fail("Business not found.");

        entity.Name = business.Name;
        entity.Category = business.Category;
        entity.Address = business.Address;
        entity.Phone = business.Phone;
        entity.Website = business.Website;
        entity.Rating = business.Rating;
        entity.ReviewCount = business.ReviewCount;
        entity.Latitude = business.Latitude;
        entity.Longitude = business.Longitude;

        await _context.SaveChangesAsync();

        return RepositoryResult.Ok("Business updated.");
    }
}
