﻿namespace TechOnIt.Infrastructure.WebServices.Techonits.Devices;

public interface IDeviceTechonitWebService
{
    public Task<List<Device>> GetDevices();
}