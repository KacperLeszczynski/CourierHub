﻿using CourierAPI.Helpers;
using System.Diagnostics.CodeAnalysis;

namespace CourierAPI.Models
{
	public record InquiryDTO(
		double DimX,
		double DimY,
		double DimZ,
		double Weight,
		DateTime DeliveryDate,
		string Name,
		LocationDTO StartLocation,
		LocationDTO EndLocation,
		bool HightPriority,
		bool WeekendDelivery,
		int Id,
        InquiryStatus Status = InquiryStatus.NotConsidered
        )
	{
		public InquiryDTO() : this(0, 0, 0, 0, DateTime.MinValue, "", new LocationDTO(), new LocationDTO(), false, false, 0)
		{
		}
	}
}

//public class InquiryDTO
//{
//    [SetsRequiredMembers]
//    public InquiryDTO(
//        double dimX, double dimY, double dimZ, double weight,
//        DateOnly deliveryDate, string name,
//        LocationDTO startLocation, LocationDTO endLocation,
//        bool hightPriority, bool weekendDelivery,
//        int id = -1
//        )
//    {
//        DimX = dimX; DimY = dimY; DimZ = dimZ;
//        Weight = weight;
//        DeliveryDate = deliveryDate;
//        StartLocation = startLocation;
//        Name = name;
//        EndLocation = endLocation;
//        HightPriority = hightPriority;
//        WeekendDelivery = weekendDelivery;
//        if (id != -1)
//            Id = id;
//    }

//    public required double DimX { get; set; }
//    public required double DimY { get; set; }
//    public required double DimZ { get; set; }
//    public required double Weight { get; set; }
//    public required DateOnly DeliveryDate { get; set; }

//    public required string Name { get; set; }
//    public required LocationDTO StartLocation { get; set; }
//    public required LocationDTO EndLocation { get; set; }
//    public required bool HightPriority { get; set; }
//    public required bool WeekendDelivery { get; set; }
//    public int Id { get; set; }
//}