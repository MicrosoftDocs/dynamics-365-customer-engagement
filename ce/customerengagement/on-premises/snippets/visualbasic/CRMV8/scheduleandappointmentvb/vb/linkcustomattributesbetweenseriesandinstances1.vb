' <snippetlinkcustomattributesbetweenseriesandinstances1>



 ' Create a custom string attribute for the appointment instance
 Dim customAppointmentInstanceAttribute As StringAttributeMetadata = _
     New StringAttributeMetadata With {.LogicalName = "new_customAppInstanceAttribute", .DisplayName = _
         New Label("CustomAppInstanceAttribute", 1033), .Description = _
         New Label("Sample Custom Appointment Instance Attribute", 1033), .MaxLength = 500, .RequiredLevel = _
         New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), .SchemaName = "new_customAppInstanceAttribute"}

 Dim instanceAttributeRequest As CreateAttributeRequest = _
     New CreateAttributeRequest With {.Attribute = customAppointmentInstanceAttribute, .EntityName = "appointment"}

 Dim instanceAttributeResponse As CreateAttributeResponse = _
     CType(_serviceProxy.Execute(instanceAttributeRequest), CreateAttributeResponse)
 _instanceAttributeID = instanceAttributeResponse.AttributeId

 ' Create a custom string attribute for the recurring appointment master (series)
 Dim customAppointmentSeriesAttribute As StringAttributeMetadata = _
     New StringAttributeMetadata With {.LogicalName = "new_customAppSeriesAttribute", .DisplayName = _
         New Label("CustomAppSeriesAttribute", 1033), .Description = _
         New Label("Sample Custom Appointment Series Attribute", 1033), .MaxLength = 500, .RequiredLevel = _
         New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), _
                     .SchemaName = "new_customAppSeriesAttribute", .LinkedAttributeId = _instanceAttributeID}

 Dim seriesAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With { _
     .Attribute = customAppointmentSeriesAttribute, .EntityName = "recurringappointmentmaster"}

 Dim seriesAttributeResponse As CreateAttributeResponse = _
     CType(_serviceProxy.Execute(seriesAttributeRequest), CreateAttributeResponse)
 _seriesAttributeID = seriesAttributeResponse.AttributeId

 ' Publish all the changes to the solution.
 Dim createRequest As New PublishAllXmlRequest()
 _serviceProxy.Execute(createRequest)

 Console.WriteLine("Created a custom string attribute, {0}, for the appointment.", _
                   customAppointmentInstanceAttribute.LogicalName)
 Console.WriteLine("Created a custom string attribute, {0}, for the recurring appointment, and linked it with {1}.", _
                   customAppointmentSeriesAttribute.LogicalName, customAppointmentInstanceAttribute.LogicalName)

' </snippetlinkcustomattributesbetweenseriesandinstances1>