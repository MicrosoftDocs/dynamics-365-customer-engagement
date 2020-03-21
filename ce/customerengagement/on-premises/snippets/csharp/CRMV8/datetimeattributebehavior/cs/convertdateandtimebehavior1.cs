// <snippetconvertdateandtimebehavior1>


 ConvertDateAndTimeBehaviorRequest request = new ConvertDateAndTimeBehaviorRequest()
 {
     Attributes = new EntityAttributeCollection() 
             { 
                 new KeyValuePair<string, StringCollection>("account", new StringCollection() 
                 { "new_sampledatetimeattribute" }) 
             },
     ConversionRule = DateTimeBehaviorConversionRule.SpecificTimeZone.Value,
     TimeZoneCode = 190, // Time zone code for India Standard Time (IST) in CRM
     AutoConvert = false // Conversion must be done using ConversionRule
 };

 // Execute the request
 ConvertDateAndTimeBehaviorResponse response = (ConvertDateAndTimeBehaviorResponse)_serviceProxy.Execute(request);

// </snippetconvertdateandtimebehavior1>