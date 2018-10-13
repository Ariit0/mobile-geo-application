﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeoApp.Data
{
    public class LocationItemManager
    {
        IDataService restService;

        public List<Properties> CurrentLocations { get; set; }

        public LocationItemManager(IDataService service)
        {
            restService = service;
        }

        public Task<List<Properties>> GetLocationsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveLocationAsync(Properties location)
        {
            return restService.SaveLocationAsync(location);
        }

        public Task DeleteLocationAsync(Properties location)
        {
            return restService.DeleteLocationAsync(location.id);
        }
    }
}

