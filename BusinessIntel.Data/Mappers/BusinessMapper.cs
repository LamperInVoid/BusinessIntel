using BusinessIntel.Core.Models;
using BusinessIntel.Data.Entities;

namespace BusinessIntel.Data.Mappers;

public static class BusinessMapper
{
    public static BusinessEntity ToEntity(Business model)
    {
        return new BusinessEntity
        {
            Id = model.Id,
            Name = model.Name,
            Category = model.Category,
            Address = model.Address,
            Phone = model.Phone,
            Website = model.Website,
            Rating = model.Rating,
            ReviewCount = model.ReviewCount,
            Latitude = model.Latitude,
            Longitude = model.Longitude
        };
    }

    public static Business ToModel(BusinessEntity entity)
    {
        return new Business
        {
            Id = entity.Id,
            Name = entity.Name,
            Category = entity.Category,
            Address = entity.Address,
            Phone = entity.Phone,
            Website = entity.Website,
            Rating = entity.Rating,
            ReviewCount = entity.ReviewCount,
            Latitude = entity.Latitude,
            Longitude = entity.Longitude
        };
    }
}
