' <snippetauditing2>


 Private Shared Sub DisplayAuditDetails(ByVal detail As AuditDetail)
     ' Write out some of the change history information in the audit record. 
     Dim record As Audit = CType(detail.AuditRecord, Audit)

     Console.WriteLine(vbLf &amp; "Audit record created on: {0}", record.CreatedOn.Value.ToLocalTime())
     Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}", record.ObjectId.LogicalName, record.FormattedValues("action"), record.FormattedValues("operation"))

     ' Show additional details for certain AuditDetail sub-types.
     Dim detailType = detail.GetType()
     If detailType Is GetType(AttributeAuditDetail) Then
         Dim attributeDetail = CType(detail, AttributeAuditDetail)

         ' Display the old and new attribute values.
         For Each attribute As KeyValuePair(Of String, Object) In attributeDetail.NewValue.Attributes
             Dim oldValue As String = "(no value)", newValue As String = "(no value)"

             'TODO Display the lookup values of those attributes that do not contain strings.
             If attributeDetail.OldValue.Contains(attribute.Key) Then
                 oldValue = attributeDetail.OldValue(attribute.Key).ToString()
             End If

             newValue = attributeDetail.NewValue(attribute.Key).ToString()

             Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, oldValue, newValue)
         Next attribute

         For Each attribute As KeyValuePair(Of String, Object) In attributeDetail.OldValue.Attributes
             If Not attributeDetail.NewValue.Contains(attribute.Key) Then
                 Dim newValue As String = "(no value)"

                 'TODO Display the lookup values of those attributes that do not contain strings.
                 Dim oldValue As String = attributeDetail.OldValue(attribute.Key).ToString()

                 Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, oldValue, newValue)
             End If
         Next attribute
     End If
     Console.WriteLine()
 End Sub

' </snippetauditing2>