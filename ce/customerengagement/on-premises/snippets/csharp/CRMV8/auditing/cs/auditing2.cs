// <snippetauditing2>


 private static void DisplayAuditDetails(AuditDetail detail)
 {
     // Write out some of the change history information in the audit record. 
     Audit record = (Audit)detail.AuditRecord;

     Console.WriteLine("\nAudit record created on: {0}", record.CreatedOn.Value.ToLocalTime());
     Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}",
         record.ObjectId.LogicalName, record.FormattedValues["action"],
         record.FormattedValues["operation"]);

     // Show additional details for certain AuditDetail sub-types.
     var detailType = detail.GetType();
     if (detailType == typeof(AttributeAuditDetail))
     {
         var attributeDetail = (AttributeAuditDetail)detail;

         // Display the old and new attribute values.
         foreach (KeyValuePair<String, object> attribute in attributeDetail.NewValue.Attributes)
         {
             String oldValue = "(no value)", newValue = "(no value)";

             //TODO Display the lookup values of those attributes that do not contain strings.
             if (attributeDetail.OldValue.Contains(attribute.Key))
                 oldValue = attributeDetail.OldValue[attribute.Key].ToString();

             newValue = attributeDetail.NewValue[attribute.Key].ToString();

             Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}",
                 attribute.Key, oldValue, newValue);
         }

         foreach (KeyValuePair<String, object> attribute in attributeDetail.OldValue.Attributes)
         {
             if (!attributeDetail.NewValue.Contains(attribute.Key))
             {
                 String newValue = "(no value)";

                 //TODO Display the lookup values of those attributes that do not contain strings.
                 String oldValue = attributeDetail.OldValue[attribute.Key].ToString();

                 Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}",
                     attribute.Key, oldValue, newValue);
             }
         }
     }
     Console.WriteLine();
 }

// </snippetauditing2>