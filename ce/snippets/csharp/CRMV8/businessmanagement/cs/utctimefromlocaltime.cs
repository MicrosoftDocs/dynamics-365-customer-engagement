// <snippetutctimefromlocaltime>


 private void RetrieveUTCTimeFromLocalTime(DateTime localTime)
 {
     if (!_timeZoneCode.HasValue)
         return;   

     var request = new UtcTimeFromLocalTimeRequest
     {
         TimeZoneCode = _timeZoneCode.Value,
         LocalTime = localTime
     };

     var response = (UtcTimeFromLocalTimeResponse)_serviceProxy.Execute(request);

     Console.WriteLine(String.Concat("Calling UtcTimeFromLocalTimeRequest.  Local time: ",
         localTime.ToString("MM/dd/yyyy HH:mm:ss"), ". UTC time: ",
         response.UtcTime.ToString("MM/dd/yyyy HH:mm:ss")));
 }

// </snippetutctimefromlocaltime>