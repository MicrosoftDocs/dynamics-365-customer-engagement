// <snippetlocaltimefromutctime>


 private void RetrieveLocalTimeFromUTCTime(DateTime utcTime)
 {
     if (!_timeZoneCode.HasValue)
         return;                

     var request = new LocalTimeFromUtcTimeRequest
     {
         TimeZoneCode = _timeZoneCode.Value,
         UtcTime = utcTime.ToUniversalTime()
     };

     var response = (LocalTimeFromUtcTimeResponse)_serviceProxy.Execute(request);

     Console.WriteLine(String.Concat("Calling LocalTimeFromUtcTimeRequest.  UTC time: ",
         utcTime.ToString("MM/dd/yyyy HH:mm:ss"), ". Local time: ",
         response.LocalTime.ToString("MM/dd/yyyy HH:mm:ss")));
 }

// </snippetlocaltimefromutctime>