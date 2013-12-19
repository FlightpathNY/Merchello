﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchello.Core.Models;
using Merchello.Core.Models.Interfaces;
using Merchello.Core.Models.TypeFields;
using Umbraco.Core.Services;

namespace Merchello.Core.Services
{
    /// <summary>
    /// Defines the ShippingService, which provides access to shipping operations
    /// </summary>
    public interface IShippingService : IService
    {
        /// <summary>
        /// Saves a single <see cref="IShipment"/> object
        /// </summary>
        /// <param name="shipment">The <see cref="IShipment"/> to save</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Save(IShipment shipment, bool raiseEvents = true);

        /// <summary>
        /// Saves a collection of <see cref="IShipment"/> objects
        /// </summary>
        /// <param name="shipmentList">Collection of <see cref="IShipment"/> to save</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Save(IEnumerable<IShipment> shipmentList, bool raiseEvents = true);

        /// <summary>
        /// Saves a single <see cref="shipCountry"/>
        /// </summary>
        /// <param name="shipCountry"></param>
        void Save(IShipCountry shipCountry);

       
        /// <summary>
        /// Deletes a single <see cref="IShipment"/> object
        /// </summary>
        /// <param name="shipment"><see cref="IShipment"/> to delete</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Delete(IShipment shipment, bool raiseEvents = true);

        /// <summary>
        /// Deletes a single <see cref="IShipCountry"/> object
        /// </summary>
        /// <param name="shipCountry"></param>
        void Delete(IShipCountry shipCountry);

        /// <summary>
        /// Deletes a collection of <see cref="IShipment"/> objects
        /// </summary>
        /// <param name="shipmentList">Collection of <see cref="IShipment"/> to delete</param>
        /// <param name="raiseEvents">Optional boolean indicating whether or not to raise events</param>
        void Delete(IEnumerable<IShipment> shipmentList, bool raiseEvents = true);

        /// <summary>
        /// Gets an <see cref="IShipment"/> object by its 'UniqueId'
        /// </summary>
        /// <param name="key">Guid pk of the Shipment to retrieve</param>
        /// <returns><see cref="IShipment"/></returns>
        IShipment GetByKey(Guid key);

        /// <summary>
        /// Gets a list of <see cref="IShipment"/> object given a ship method Key
        /// </summary>
        /// <param name="shipMethodKey">The pk of the shipMethod</param>
        /// <returns>A collection of <see cref="IShipment"/></returns>
        IEnumerable<IShipment> GetShipmentsForShipMethod(Guid shipMethodKey);

        /// <summary>
        /// Gets a single <see cref="IShipCountry"/> by it's unique key (Guid pk)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        IShipCountry GetShipCountryByKey(Guid key);

        /// <summary>
        /// Gets a single <see cref="IShipCountry"/>
        /// </summary>
        /// <param name="catalogKey">The warehouse catalog key (guid)</param>
        /// <param name="countryCode">The two letter ISO country code</param>
        /// <returns></returns>
        IShipCountry GetShipCountryByCountryCode(Guid catalogKey, string countryCode);

        /// <summary>
        /// Gets a list of <see cref="IShipCountry"/> objects given a <see cref="IWarehouseCatalog"/> key
        /// </summary>
        /// <param name="catalogKey">Guid</param>
        /// <returns>A collection of <see cref="IShipCountry"/></returns>
        IEnumerable<IShipCountry> GetShipCountriesByCatalogKey(Guid catalogKey);


            
        /// <summary>
        /// Gets list of <see cref="IShipment"/> objects given a list of Unique keys
        /// </summary>
        /// <param name="keys">List of Guid keys for Shipment objects to retrieve</param>
        /// <returns>List of <see cref="IShipment"/></returns>
        IEnumerable<IShipment> GetByKeys(IEnumerable<Guid> keys);

    }
}
