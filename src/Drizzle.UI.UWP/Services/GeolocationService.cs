﻿using Drizzle.Common.Exceptions;
using Drizzle.Common.Services;
using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace Drizzle.UI.UWP.Services;

// API Ref:
// https://learn.microsoft.com/en-us/windows/uwp/maps-and-location/get-location
public class GeolocationService : IGeolocationService
{
    private readonly IResourceService resources;

    public GeolocationService(IResourceService resources)
    {
        this.resources = resources;
    }

    public async Task<GeoLocation> GetLocationAsync()
    {
        var accessStatus = await Geolocator.RequestAccessAsync();
        switch (accessStatus)
        {
            case GeolocationAccessStatus.Allowed:
                // If DesiredAccuracy or DesiredAccuracyInMeters are not set (or value is 0), DesiredAccuracy.Default is used.
                var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };

                // Subscribe to the StatusChanged event to get updates of location status changes.
                //geolocator.StatusChanged += OnStatusChanged;

                var pos = await geolocator.GetGeopositionAsync();
                return new GeoLocation() { 
                    Latitude = (float)pos.Coordinate.Point.Position.Latitude, 
                    Longitude = (float)pos.Coordinate.Point.Position.Longitude 
                };
            case GeolocationAccessStatus.Denied:
                throw new AccessDeniedException(resources.GetString("StringGeolocationErrorAccessDenied"));
            case GeolocationAccessStatus.Unspecified:
                throw new UnspecifiedException(resources.GetString("StringGeolocationErrorAccessUnspecified"));
            default:
                throw new NotImplementedException();
        }
    }
}
