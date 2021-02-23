---
title: "Custom channel activity create interaction (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Describes the input parameters required by the msdyncrm_CustomChannelActivityCreateInteraction action."
ms.date: 02/15/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Custom channel activity create interaction

The following table describes the input parameters required by the `msdyncrm_CustomChannelActivityCreateInteraction` action: 

|Input parameter|Type|Description|
|-----------|----------|---------|
|ActivityId |String|The `msdyncrm_activityid` attribute value of the `msdyncrm_customerjourneycustomchannelactivity` entity containing custom channel Activity Id.|
|CustomerJourney |EntityReference|The `msdyncrm_customerjourney` attribute value of the `msdyncrm_customerjourneycustomchannelactivity` entity containing Entity Reference to customer journey originating the call.| 
|CustomerJourneyIteration| EntityReference|The `msdyncrm_customerjourneyiteration` attribute value of the `msdyncrm_customerjourneycustomchannelactivity` entity containing Entity Reference to customer journey iteration.| 
|Contact |EntityReference| The `msdyncrm_contact` attribute value of the `msdyncrm_customerjourneycustomchannelactivity` entity containing Entity Reference to processed contact.| 
|EntityType  |String |The `msdyncrm_entitytype` attribute value of the `msdyncrm_customerjourneycustomchannelactivity` entity containing the string representing the entity type of custom entity created in [step1](create-entities-forms.md) and defined in the custom channel tile [definition](configure-tile-custom-channel.md#sample-tile-xml-file).| 
|EntityId |String |The `msdyncrm_entityid` attribute value of the `msdyncrm_customerjourneycustomchannelactivity` record id of the custom entity created in [step1](create-entities-forms.md) and defined by the `EntityType` element in the custom channel tile [definition](configure-tile-custom-channel.md#sample-tile-xml-file).|
|ResponseType |String |Id of one of the response types defined in the custom channel tile [definition](configure-tile-custom-channel.md#sample-tile-xml-file).| 
|TriggerKeyword |String |(Optional) Keyword for custom response type defined in the custom tile [definition](configure-tile-custom-channel.md#sample-tile-xml-file).| 

 
The XML below shows the section of the custom channel tile definition. This section defines three types of responses. The first two, `sent` and `delivered`, are the standard response types. The third one,  `keyword` allows passing additional textual value to the interaction.  

```XML
 <ResponseTypes> 
    <ResponseType id="sent"> 
      <Labels> 
        <!-- Labels should always have a Label for 1033 --> 
        <Label locId="1033">Sent</Label> 
        <Label locId="1031">[Sent]</Label> 
      </Labels> 
    </ResponseType> 
    <ResponseType id="delivered"> 
      <Labels> 
       <!-- Labels should always have a Label for 1033 --> 
        <Label locId="1033">Delivered</Label> 
        <Label locId="1031">[Delivered]</Label> 
      </Labels> 
    </ResponseType> 
    <ResponseType id="keyword" custom="True"> 
      <!-- there should be only one response type with attribute custom=true --> 
      <Labels> 
        <!-- Labels should always have a Label for 1033 --> 
        <Label locId="1033">Keyword match</Label> 
        <Label locId="1031">[Keyword match]</Label> 
      </Labels> 
    </ResponseType> 
  </ResponseTypes> 
 ```

## Emit custom Channel Activity Create Interaction

The following code shows how to emit Custom Channel Activity Create Interaction programmatically. In this example, reference activity is defined in the custom channel activity record. We emit the interaction with `ResponseType = keyword` and `TriggerKeyword = interested`.  

```csharp
    var orgServiceFactory = serviceProvider.GetService(typeof(IOrganizationServiceFactory)) as IOrganizationServiceFactory; 
    IOrganizationService orgService = orgServiceFactory.CreateOrganizationService(context.UserId);
    
    //Id of msdyncrm_customerjourneycustomchannelactivity entity 
    Guid Id = "<Record Guid>"; 

    //Get response from your service or use predefined response type for keyword based responses. 
    string responseType = "keyword"; 

    //Get keyword response from your service (Optional) 
    string triggerKeyWord = "interested"; 
    //Note: if you emmiting interaction on creation of msdyncrm_customerjourneycustomchannelactivity entity instance, there is no need to retrieve it, you can use Target  
    Entity customChannelRecord = orgService.Retrieve( "msdyncrm_customerjourneycustomchannelactivity",Id,new Microsoft.Xrm.Sdk.Query.ColumnSet(true)); 
    var emitInteractionRequest = new OrganizationRequest("msdyncrm_CustomChannelActivityCreateInteraction"); 
    emitInteractionRequest.Parameters.Add("ActivityId", customChannelRecord.GetAttributeValue<string>("msdyncrm_activityid")); 
    emitInteractionRequest.Parameters.Add("CustomerJourney", customChannelRecord.GetAttributeValue<EntityReference>("msdyncrm_customerjourney")); 
    emitInteractionRequest.Parameters.Add("CustomerJourneyIteration", customChannelRecord.GetAttributeValue<EntityReference>("msdyncrm_customerjourneyiteration")); 
    emitInteractionRequest.Parameters.Add("Contact", customChannelRecord.GetAttributeValue<EntityReference>("msdyncrm_contact")); 
    emitInteractionRequest.Parameters.Add("EntityId", customChannelRecord.GetAttributeValue<string>("msdyncrm_entityid")); 
    emitInteractionRequest.Parameters.Add("EntityType", customChannelRecord.GetAttributeValue<string>("msdyncrm_entitytype")); 
    emitInteractionRequest.Parameters.Add("ResponseType", responseType); 

    //Needed if response type has “custom” attribute set to “True” 
    emitInteractionRequest.Parameters.Add("TriggerKeyword", triggerKeyWord); 

    //Emit interaction 
    orgService.Execute(emitInteractionRequest); 
 ```

## See also
[Create custom channel](create-custom-channel.md)<br/>
[Configure the tile for custom channel](configure-tile-custom-channel.md)<br/>
[Extend customer journey using code](extend-customer-journey-using-code.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]