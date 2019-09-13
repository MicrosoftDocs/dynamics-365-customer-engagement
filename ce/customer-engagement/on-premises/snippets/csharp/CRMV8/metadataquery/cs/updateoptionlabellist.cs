// <snippetupdateoptionlabellist>


 protected String updateOptionLabelList(EntityQueryExpression entityQueryExpression, String clientVersionStamp)
 {
  //Retrieve metadata changes and add them to the cache
  RetrieveMetadataChangesResponse updateResponse;
  try
  {
   updateResponse = getMetadataChanges(entityQueryExpression, clientVersionStamp, DeletedMetadataFilters.OptionSet);
   addOptionLabelsToCache(updateResponse.EntityMetadata, true);
   removeOptionLabelsFromCache(updateResponse.DeletedMetadata, true);

  }
  catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
  {
   // Check for ErrorCodes.ExpiredVersionStamp (0x80044352)
   // Will occur when the timestamp exceeds the Organization.ExpireSubscriptionsInDays value, which is 90 by default.
   if (ex.Detail.ErrorCode == unchecked((int)0x80044352))
   {
    //reinitialize cache
    _optionLabelList.Clear();

    updateResponse = getMetadataChanges(entityQueryExpression, null, DeletedMetadataFilters.OptionSet);
    //Add them to the cache and display the changes
    addOptionLabelsToCache(updateResponse.EntityMetadata, true);

   }
   else
   {
    throw ex;
   }

  }
  return updateResponse.ServerVersionStamp;
 }

// </snippetupdateoptionlabellist>