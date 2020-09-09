// <snippetgettimezonecodebylocalizedname>


 private void GetTimeZoneCodeByLocaleAndName()
 {
     if (string.IsNullOrWhiteSpace(_timeZoneName) || !_localeId.HasValue)
         return;

     var request = new GetTimeZoneCodeByLocalizedNameRequest
     {
         LocaleId = _localeId.Value,
         LocalizedStandardName = _timeZoneName
     };

     var response = (GetTimeZoneCodeByLocalizedNameResponse)
         _serviceProxy.Execute(request);

     Console.WriteLine(String.Concat("Time zone code: ", response.TimeZoneCode,
         " retrieved for locale id: ", _localeId.Value, ", and time zone name: ",
         _timeZoneName));
 }

// </snippetgettimezonecodebylocalizedname>