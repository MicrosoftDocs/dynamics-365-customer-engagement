// <snippetgetalltimezoneswithdisplayname>


 private void RetrieveAllTimeZonesForLocale()
 {
     if (!_localeId.HasValue)
         return;
     
     Console.WriteLine(String.Concat("Retrieving time zones for locale id: ",
         _localeId.Value));

     var response = (GetAllTimeZonesWithDisplayNameResponse) _serviceProxy.Execute(
         new GetAllTimeZonesWithDisplayNameRequest
         {
             LocaleId = _localeId.Value,
         });

     for (int i = 0; i < response.EntityCollection.Entities.Count; i++)
     {
         var timeZoneDefinition = response.EntityCollection
             .Entities[i].ToEntity<TimeZoneDefinition>();

         Console.WriteLine(String.Concat(timeZoneDefinition.UserInterfaceName,
             " found for ", _localeId.Value));
     }
 }

// </snippetgetalltimezoneswithdisplayname>