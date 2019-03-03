---
title: "Channel Integration Framework (CIF) (Hosted Control) | MicrosoftDocs"
description: "Learn about using the Channel Integration Framework hosted control type to integrate channel providers into Unified Service Desk client application to experience the functionalities of the channel provider (softphone, chatbot, message (sms), chat)."
ms.custom: 
  - dyn365-USD
ms.date: 03/08/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: CD120606-2A4A-427A-913A-FE00821FA330
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---

# Channel Integration Framework (Hosted Control)

Use the **Channel Integration Framework** type of hosted control to integrate your channel provider with Unified Service Desk client application. You can create multiple Channel Integration Framework type of hosted control to host different channels. To learn more, see [Integrate channel provider using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md).

To create a Channel Integration Framework type of hosted control, see [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md)

## Predefined UII actions

The following actions are supported for this type of hosted control.

### Close

This action is used to close the hosted control.

### FireEvent  

Fires a user-defined event from this hosted control.  

|Parameter|Description|  
|---------------|-----------------|  
|name|Name of the user-defined event.|  

All subsequent name=value pairs become the parameters to the event. For more information about creating a user-defined event, see [Create a user-defined event](../unified-service-desk/create-user-defined-event.md).  

### MoveToPanel  

This action is used to move hosted controls between panels at runtime.  

|Parameter|Description|  
|---------------|-----------------|  
|app|Name of the hosted control to be moved.|  
|panel|Target panel for the hosted control.| 

### Popup  

Pops up a URL from the hosted control and runs the window navigation rules against it for routing the popup to the appropriate location.  

|Parameter|Description|  
|---------------|-----------------|  
|url|Routes a popup from this hosted control using this URL as if it were a popup requested from the displayed control.|  
|frame|The frame from which this popup originated.| 

### RunScript  

This action injects JavaScript into the main frame of the application. You should avoid using [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps client SDK calls with this action; instead, use the **RunXrmCommand** action.  

|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|

### RunXrmCommand  

This action is used to inject [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps SDK JavaScript into the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps form.  

|Parameter|Description|  
|---------------|-----------------|  
||The data parameter is the JavaScript that will be injected into the form. **Note:**  The replacement parameters can be used in the script, and they will be replaced before the script is executed.|  

### SetSize  
 
This action explicitly sets the width and height of the hosted control. This is particularly useful when using "auto" in your panel layouts.  

|Parameter|Description|  
|---------------|-----------------|  
|width|The width of the hosted control.|  
|height|The height of the hosted control.| 

### SetUserCanClose  

Enables the user to close the hosted control by clicking the X icon at the top-right corner of the hosted control tab.  

|Parameter|Description|  
|---------------|-----------------|  
|UserCanClose|Set this to `true` to enable the user to close the hosted control. Otherwise, set false.|

### RaiseCifClientEvent

This action sends the data raised from the client side event to the hosted control.

|Parameter|Description|  
|---------------|-----------------|  
|event| The client side events from where you want to raise the data. |
|data| The data parameter takes eventData values.<br><br>Pass the data as a string that was received from the event by using replacement parameters. <br>`data = [[data]+]`.<br><br> Supported client-side events are as follows:<br> <ul> <li>[onclicktoact](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onclicktoact)</li> <li>[onmodechanged](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onmodechanged)</li> <li>[onpagenavigate](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onpagenavigate)</li> <li>[onsendkbarticle](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onsendkbarticle)</li> <li>[onsizechanged](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/events/onsizechanged)</li> </ul> See the above mentioned client-side events for the eventData values to pass.|

### UpdateCifContext




## Predefined events

The following events are supported for this type of hosted control.

### CreateRecord

Creates an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The logical name of the entity. |
| data | String defining the attributes and values for the new entity record. |
| corrId | <!-- Check with Aniket ---> |

To learn more, see [createRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/createrecord)

### RetrieveRecord

Retrieves an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of the record you want to retrieve. |
| id | GUID of the entity record you want to retrieve. |
| options | OData system query options, **$select** and **$expand**, to retrieve your data.<br> <ul> <li>Use the **$select** system query option to limit the properties returned by including a comma-separated list of property names. This is an important performance best practice. If properties aren’t specified using **$select**, all properties will be returned.</li> <li>Use the <b>$expand</b> system query option to control what data from related entities is returned. If you just include the name of the navigation property, you’ll receive all the properties for related records. You can limit the properties returned for related records using the **$select** system query option in parentheses after the navigation property name. Use this for both *single-valued* and *collection-valued* navigation properties.</li> </ul> <br>You specify the query options starting with `?`. You can also specify multiple query options by using `&` to separate the query options. For example:<br>`?$select=name&amp;$expand=primarycontactid($select=contactid,fullname)` |

To learn more, see [retrieveRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/retrieverecord)

### UpdateRecord

Updates an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of the record you want to update.  |
| id | GUID of the entity record you want to update. |
| data | String containing `key: value` pairs, where `key` is the property of the entity and `value` is the value of the property you want to update. |

To learn more, see [updateRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/updaterecord)

### DeleteRecord

Deletes an entity record.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of the record you want to delete.  |
| data | String defining the attributes and values for the new entity record. |
| id | GUID of the entity record you want to delete. |

To learn more, see [deleteRecord (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/deleterecord)

### GetEntityMetadata

Returns the entity metadata for the specified entity.

|Parameter|Description|  
|---------------|-----------------|
| entityLogicalName | The entity logical name of entity.  |
| attributes | The attributes for which you want to get metadata. |

To learn more, see [getEntityMetadata (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/getentitymetadata)

### GetEnvironment

Gets the current Unified Interface app and page details. The details include appId, pageType, and recordId (If available).

There are no parameters for this event.

To see learn more, see [getEnvironment (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/getenvironment)

### OpenForm

Opens an entity form or a quick create form.


To learn more, see [openForm (CIF JavaScript API Reference)](/dynamics365/customer-engagement/developer/channel-integration-framework/reference/microsoft-ciframework/openform)

### RenderSearchPage

### SearchAndOpenMultipleRecords

### PageDocumentComplete

## See also



